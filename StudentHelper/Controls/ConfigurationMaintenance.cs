using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentHelperCPUNamespace;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;

namespace StudentHelper
{
    public partial class ConfigurationMaintenance : UserControl
    {
        #region Field
        private string _ConfigurationDirectory;
        private StudentHelperMainForm _Owner;
        #endregion

        #region Constructor
        public ConfigurationMaintenance()
        {
            InitializeComponent();
        }
        public ConfigurationMaintenance(StudentHelperMainForm owner)
        {
            InitializeComponent();
            this.Owner = owner;
        }
        #endregion

        #region Property


        public StudentHelperMainForm Owner
        {
            get { return _Owner; }
            set { _Owner = value; }
        }


        public string ConfigurationDirectory
        {
            get { return _ConfigurationDirectory; }
            set { _ConfigurationDirectory = value; }
        }

        #endregion

        #region Method

        #region Configuration Contents Checker
        private int nullChecker(out string contents)
        {
            int ret = 0;
            contents = null;

            if(this.textBoxUserName.Text.Equals(""))
            {
                ret = -9999;
                contents = "UserName should not be null";
                return ret;
            }

            if(this.textBoxGraduationCredits.Text.Equals(""))
            {
                ret = -8888;
                contents = "Graduation credit should not be null";
                return ret;
            }

            if(this.textBoxCostCredits.Text.Equals(""))
            {
                ret = -7777;
                contents = "Cost should not be null";
                return ret;
            }

            return ret;
        }

        protected int ContentsChecker(out string contents)
        {
            int ret = 0;
            contents = null;
            if ((ret = nullChecker(out contents)) != 0) return ret;

            int year = int.Parse(this.textBoxYearOfGrade.Text);
            int credit = int.Parse(this.textBoxGraduationCredits.Text);

            if (year <= 0 || year > 5)
            {
                ret = -4;
                contents = "Year Of Grade Must be over 0 and less than 6";
                return ret;
            }

            if (credit < 60 || credit > 180)
            {
                ret = -5;
                contents = "Graduation Credit Must be over 59 and less than 181";
                return ret;
            }

            return ret;
        }

        protected int GradeChecker(out string contents, string grade)
        {
            int ret = 0;
            contents = "";

            grade = grade.ToUpper();

            switch (grade)
            {
                case "A":
                case "B":
                case "C":
                case "D":
                case "F":
                    break;
                default:
                    ret = -6;
                    contents ="Grade is not acceptable. Please Check.";
                    break;
            }

            return ret;
        }
        #endregion

        #region Save Button
        private void buttonConfigurationSave_Click(object sender, EventArgs e)
        {
            int ret = 0;
            string contents = null;
            var json = new JObject();

            var jsonCollegeConfig = new JObject();
            var jsonUserConfig = new JObject();
            var jarrayGrade = new JArray();
            var jarrayClass = new JArray();

            if ((ret = ContentsChecker(out contents)) != 0)
            {
                Owner.Alarm.AlarmMaker(this.ToString(), ret, contents);
                return;
            }

            //var json1 = JObject.Parse("\"" +this.textBoxUserName.Text+"\"");
            //var json2 = JObject.Parse("\"" +this.textBoxCollege.Text+"\"");
            //var jsonArrayClasses1 = JObject.Parse("\"" + this.dataGridViewClasses.Columns[0].ToString() + "\"");
            //var jsonArrayGrades1 = JObject.Parse("\"" + this.dataGridViewClasses.Columns[1].ToString() + "\"");
            ////var jsonArray1 = (string)jsonArrayClasses1 + (string)jsonArrayGrades1;
            //string str_jsonArray = JsonConvert.SerializeObject(jarray);
            //var json5 = JObject.Parse("{Classes:" + str_jsonArray + "}");
            

            #region CollegeConfig
            for (int i = 0; i < this.dataGridViewMustTakeClassesConfig.Rows.Count-1; i++)
            {
                var jsonClasses = new JObject();
                jsonClasses.Add("Section", this.dataGridViewMustTakeClassesConfig.Rows[i].Cells[0].Value.ToString().ToUpper());
                jsonClasses.Add("Class", this.dataGridViewMustTakeClassesConfig.Rows[i].Cells[1].Value.ToString().ToUpper());
                jarrayClass.Add(jsonClasses);
            }
            jsonCollegeConfig.Add("MustTakeClasses", jarrayClass);
            jsonCollegeConfig.Add("Cost", this.textBoxCostCredits.Text);
            jsonCollegeConfig.Add("GraduationCredit", this.textBoxGraduationCredits.Text);
            #endregion
            json.Add("CollegeConfiguration" , jsonCollegeConfig);

            #region UserConfig
            jsonUserConfig.Add("UserName", this.textBoxUserName.Text);
            jsonUserConfig.Add("College", this.textBoxCollege.Text.ToUpper());
            jsonUserConfig.Add("Degree", this.textBoxDegree.Text.ToUpper());
            jsonUserConfig.Add("YearOfGrade", this.textBoxYearOfGrade.Text);

            for (int i = 0; i < this.dataGridViewClasses.Rows.Count-1; i++)
            {
                var jsonClasses = new JObject();
                jsonClasses.Add("Classes", this.dataGridViewClasses.Rows[i].Cells[0].Value.ToString().ToUpper());
                jsonClasses.Add("Grades", this.dataGridViewClasses.Rows[i].Cells[1].Value.ToString().ToUpper());
                if ((ret = GradeChecker(out contents, this.dataGridViewClasses.Rows[i].Cells[1].Value.ToString())) != 0)
                {
                    Owner.Alarm.AlarmMaker(this.ToString(), ret, contents);
                    return;
                }
                jarrayGrade.Add(jsonClasses);
            }
            jsonUserConfig.Add("MyClasses", jarrayGrade);
            #endregion
            json.Add("UserConfiguration" , jsonUserConfig);

            string str_json = JsonConvert.SerializeObject(json);
            System.Diagnostics.Debug.WriteLine(str_json);
            JsonConvert.SerializeObject(json, Formatting.Indented);

            string textValue = json.ToString();

            
            if (ConfigurationDirectory == null)
            {
                MessageBox.Show("json File Created Failed Directory is not selected Yet!");
                this.Owner.Alarm.AlarmMaker(this.ToString(), -1);
                return;
            }
            else
            {
                string savePath = ConfigurationDirectory;
                savePath +=  this.textBoxUserName.Text + ".json";
                FileInfo fi = new FileInfo(savePath);
                if(fi.Exists)
                {
                    if (MessageBox.Show("File Already Exist, Want to Override?","FileExist",MessageBoxButtons.YesNo) == DialogResult.No )
                    {
                        return;
                    }
                }
                        if (fi.Directory.Exists)
                        {
                            System.IO.File.WriteAllText(savePath, textValue, Encoding.Default);
                            MessageBox.Show("json File Created!");
                        }
            }
        }
        #endregion

        public void DirectorySelect()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            ConfigurationDirectory = dialog.SelectedPath;
        }

        private void buttonDirectorySelect_Click(object sender, EventArgs e)
        {
            DirectorySelect();
        }

        #region ConfigurationReset
        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.textBoxCollege.Text = null;
            this.textBoxCostCredits.Text = null;
            this.textBoxDegree.Text = null;
            this.textBoxGraduationCredits.Text = null;
            this.textBoxUserName.Text = null;
            this.textBoxYearOfGrade.Text = null;
            this.dataGridViewClasses.Rows.Clear();
            this.dataGridViewMustTakeClassesConfig.Rows.Clear();
        }
        #endregion

        #region Only Number Input
        private void textIntervale_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only Number Input
            if(!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))) // Only number and backspace
            {
                e.Handled = true;
            }
        }
        #endregion

        #endregion
    }
}
