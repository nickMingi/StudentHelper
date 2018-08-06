using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;

namespace StudentHelper
{
    #region Maintenance Classe
    public partial class Maintenance : CommomControls
    {
        #region Define
        public enum ConfigurationSelection
        {
            CollegeConfiguration,
            UserConfiguration,
        }
        #endregion

        #region Field
        private Student _Student;
        private College _College;
        private int _PreviousItemCal;
        #endregion

        #region Property

        public int PreviousItemCal
        {
            get { return this._PreviousItemCal; }
            set { this._PreviousItemCal = value; }
        }


        public College College
        {
            get { return this._College; }
            set { this._College = value; }
        }


        public Student Student
        {
            get { return this._Student; }
            set { this._Student = value; }
        }

        #endregion

        #region Constructor
        public Maintenance() : base()
        {
            InitializeComponent();
            this.Student = new Student();
            this.College = new College();
        }

        public Maintenance(StudentHelperMainForm owner) : base(owner)
        {
            InitializeComponent();
            this.Student = new Student();
            this.College = new College();
        }
        #endregion

        #region OnDisplay
        public void OnDisplay()
        {
            int ret = 0;
            if(this.Owner.Configuration.ConfigurationDirectory == null)
            {
                MessageBox.Show("Directory is not selected, Display will not work.");
                this.Owner.Alarm.AlarmMaker(this.ToString(), -1);
                //this.Owner.Configuration.DirectorySelect();
                return;
            }

            string[] tempFiles = Directory.GetFiles(this.Owner.Configuration.ConfigurationDirectory,"*.json", System.IO.SearchOption.TopDirectoryOnly);
            if (tempFiles.Count() <= 0)
            {
                MessageBox.Show("Please check directory. No Json file found.");
                Owner.Alarm.AlarmMaker(this.ToString(), -2, "NoJsonFile");
            }
            Dictionary<string,JObject> jsonItems = new Dictionary<string,JObject>();
            jsonItems.Clear();
            foreach (string tempFile in tempFiles)
            {

                 string result = string.Empty;
                 var jobj = new JObject();
                 using (StreamReader r = new StreamReader(tempFile))
                 {
                     var json = r.ReadToEnd();
                     jobj = JObject.Parse(json);
                     //foreach (var item in jobj.Properties())
                     //{
                     //    item.Value = item.Value.ToString().Replace("v1","v2");
                     //}
                     result = jobj.ToString();
                     Console.WriteLine(result);
                 }
                 jsonItems.Add(jobj["UserConfiguration"]["UserName"].ToString(),jobj);

                
            }

            if(PreviousItemCal != jsonItems.Count)
            {
                this.comboBoxUserList.Items.Clear();
                PreviousItemCal = jsonItems.Count;

                foreach (KeyValuePair<string,JObject> info in jsonItems)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = info.Key;
                    item.Value = info.Value;
                    this.comboBoxUserList.Items.Add(item);

                    if (this.comboBoxUserList.SelectedIndex < 0)
                    {
                        // Initial
                        this.comboBoxUserList.SelectedIndex = 0;
                    }
                }
            }

            if (this.comboBoxUserList.Items.Count > 0)
            {
                var jobj = new JObject();
                if (this.comboBoxUserList.SelectedIndex < 0)
                {
                    this.comboBoxUserList.SelectedIndex = 0;
                }
                else
                {
                    if (jsonItems.TryGetValue(this.comboBoxUserList.SelectedItem.ToString(), out jobj))
                    {

                        JsonSaver(jobj);

                        this.labelUserNameDisplayTwo.Text = Student.Username;
                        this.labelUserNameDisplay.Text = Student.Username;
                        this.labelCollegeDisplay.Text = Student.College;
                        this.labelDegreeDisplay.Text = Student.Degree;
                        this.labelYearOfGradeDisplay.Text = Student.Year;
                        int numberOfClasses = Student.StudentClasses.Count;
                        this.labelNumberOfClassesDisplay.Text = string.Format("{0}", numberOfClasses);
                        this.labelAverageGradeDisplay.Text = Student.StudentAverageGradeCal(Student.StudentClasses);
                        ret = Student.RemainingCreditCostCalculator(this.College);
                        this.Student.GraduationGrade = this.Student.GraduationGradeCal(this.labelAverageGradeDisplay.Text);

                    }
                }
            }

            if (ret != 0)
            {
                this.comboBoxUserList.SelectedIndex = -1;
                Owner.Alarm.AlarmMaker(this.ToString(), ret);
            }
        }
        #endregion

        #region Method

        #region JsonSaver
        private void JsonSaver(JObject jobj)
        {
            this.Student.Username = jobj["UserConfiguration"]["UserName"].ToString();
            this.Student.College = jobj["UserConfiguration"]["College"].ToString();
            this.Student.Degree = jobj["UserConfiguration"]["Degree"].ToString();
            this.Student.Year = jobj["UserConfiguration"]["YearOfGrade"].ToString();
            int numberOfClasses = jobj["UserConfiguration"]["MyClasses"].Count();
            List<Student.Classes> studentClasses = new List<Student.Classes>();
            for (int i = 0; i < numberOfClasses; i++)
            {
                Student.Classes classes = new Student.Classes();
                classes.classes = jobj["UserConfiguration"]["MyClasses"][i]["Classes"].ToString();
                classes.grades = jobj["UserConfiguration"]["MyClasses"][i]["Grades"].ToString();
                studentClasses.Add(classes);
            }
            Student.StudentClasses = studentClasses;

            numberOfClasses = jobj["CollegeConfiguration"]["MustTakeClasses"].Count();
            List<College.Classes> collegeClasses = new List<College.Classes>();
            for (int i = 0; i < numberOfClasses; i++)
            {
                College.Classes classes = new College.Classes();
                classes.section = jobj["CollegeConfiguration"]["MustTakeClasses"][i]["Section"].ToString();
                classes.classes = jobj["CollegeConfiguration"]["MustTakeClasses"][i]["Class"].ToString();
                collegeClasses.Add(classes);
            }
            this.College.Cost = jobj["CollegeConfiguration"]["Cost"].ToString();
            this.College.GraduationCredit = jobj["CollegeConfiguration"]["GraduationCredit"].ToString();
            College.CollegeClasses = collegeClasses;
        }
        #endregion

        #region Calculate
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if(this.comboBoxUserList.Items.Count <= 0)
            {
                MessageBox.Show("Please check Configuration Directory No Json File Found!");
                this.Owner.Alarm.AlarmMaker(this.ToString(), -2);
                return;
            }

            this.dataGridViewMustTakeDisplay.Rows.Clear();

            this.textBoxRemainingCredit.Text = this.Student.RemainingCredit;
            this.textBoxRemainingCost.Text = this.Student.RemainingCost;
            this.textBoxGraduationGrade.Text = this.Student.GraduationGrade;

            CompareClasses(Student, College);

            for (int i = 0; i < Student.MustTakeClasses.Count; i++)
            {
                this.dataGridViewMustTakeDisplay.Rows.Add();
                this.dataGridViewMustTakeDisplay.Rows[i].Cells[0].Value = Student.MustTakeClasses[i].section;
                this.dataGridViewMustTakeDisplay.Rows[i].Cells[1].Value = Student.MustTakeClasses[i].classes;
            }

            MessageBox.Show("Calculate Finished!");
        }
        #endregion

        #region Compare Classes
        private void CompareClasses(Student student, College college)
        {
            List<College.Classes> mustTakeClasses = new List<College.Classes>();

            foreach (var item in college.CollegeClasses)
            {
                bool check = false;
                for (int i = 0; i < student.StudentClasses.Count; i++)
                {
                    if(student.StudentClasses[i].classes.ToString().Equals(item.classes))
                    {
                        check = true;
                    }
                }

                if (!check)
                    mustTakeClasses.Add(item);
            }

            this.Student.MustTakeClasses = mustTakeClasses;
        }
        #endregion

        #region CSV Saver
        private void buttonSaveCSV_Click(object sender, EventArgs e)
        {
            int ret = 0;
            FileStream fs = null;
            StreamWriter fileWriter = null;
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.AddExtension = true;
            saveFile.DefaultExt = "csv";
            string filename = null;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                filename = saveFile.FileName;
            }

            try
            {
                FileInfo fi = new FileInfo(filename);
                if (!fi.Directory.Exists)
                    System.IO.Directory.CreateDirectory(fi.DirectoryName);
                if (!fi.Exists)
                {
                    fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.Read);
                    fileWriter = new StreamWriter(fs);
                    fileWriter.WriteLine("Time , Remaining Credit, Remaining Cost, Expected Graduation Grade, Student Must Take Classes   ");
                }
                else
                {
                    fs = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.Read);
                    fileWriter = new StreamWriter(fs);
                }
            }
            catch (IOException)
            {
                ret = -1;
                throw;
            }

            try
            {
                string star = "*****";
                string twoStar = star + star;
                string fiveStar = star + star + star + star + star;
                string tenStar = fiveStar + fiveStar;
                fileWriter.WriteLine(" ");
                fileWriter.WriteLine(twoStar + "," + twoStar + "," + fiveStar + "," + twoStar + ",*****");
                
                fileWriter.Write("[{0}],{1},{2},",System.DateTime.Now.ToString("yyyy-MM-dd HH:mm"),Student.RemainingCredit,Student.RemainingCost);
                fileWriter.Write("{0},",Student.GraduationGrade);
                for (int i = 0; i < Student.MustTakeClasses.Count; i++)
                {
                    fileWriter.Write("{0},", Student.MustTakeClasses[i].classes);
                }
            }
            catch (IOException)
            {
                ret = -2;
                throw;
            }
            finally
            {
                if(fileWriter != null)
                {
                    fileWriter.Close();
                    fileWriter = null;
                }
                if (fs != null)
                {
                    fs.Close();
                    fs = null;
                }
            }

        }
        #endregion
        #endregion

    }
    #endregion

    #region ComboBox Class
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
    #endregion
}
