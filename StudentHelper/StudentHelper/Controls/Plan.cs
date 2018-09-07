using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHelper
{
    public partial class Plan : CommomControls
    {
        public Plan() : base()
        {
            InitializeComponent();
        }

        public Plan(StudentHelperMainForm owner) : base(owner)
        {
            InitializeComponent();
        }

        private string _LatestUserName;

        public string LatestUserName
        {
            get { return _LatestUserName; }
            set { _LatestUserName = value; }
        }


        #region Method

        public void Display()
        {
            OnDisplay();
        }

        protected override void OnDisplay()
        {
            base.OnDisplay();
            if (LatestUserName == null || LatestUserName != this.Owner.Maintenance.Student.Username)
            {
                if (this.Owner.Maintenance.Student == null)
                {
                    this.Owner.Alarm.AlarmMaker(this.ToString(),-3500,"Student is null");
                    return;
                }
                LatestUserName = this.Owner.Maintenance.Student.Username;
                int ret = planSaver(this.Owner.Maintenance.Student.StartSemester);   
            }
            
        }

        public int planSaver(string startSemester)
        {
            int ret = 0;
            this.dataGridViewPlan.Columns[0].HeaderText = startSemester;
            string firstSemester = startSemester.Substring(4);
            int firstYear = int.Parse( startSemester.Substring(0,4));
            int semesterFollower = 0;
            switch (firstSemester)
            {
                case "SPRING":
                    semesterFollower = 0;
                    break;
                case "SUMMER":
                    semesterFollower = 1;
                    break;
                case "FALL":
                    semesterFollower = 2;
                    break;
                default:
                    break;
            }

            this.dataGridViewPlan.Rows.Clear();
            for (int i = 0; i < 12; i++)
            {
                int count = 0;
                Student.Semesters semesters = (Student.Semesters)semesterFollower;
                this.dataGridViewPlan.Columns[i].HeaderText = string.Format("{0}",firstYear)+semesters.ToString();

                foreach (var item in this.Owner.Maintenance.Student.StudentClasses)
                {
                    string semester = item.year + item.semester;
                    if(semester == this.dataGridViewPlan.Columns[i].HeaderText)
                    {
                        if ((i == 0) || this.dataGridViewPlan.Rows.Count-1 <= count)
                            this.dataGridViewPlan.Rows.Add();


                        this.dataGridViewPlan.Rows[count].Cells[i].Value = item.classes;
                        count++;
                    }
                }

                if (semesterFollower == 2)
                {
                    semesterFollower = 0;
                    firstYear++;
                }
                else
                {
                    semesterFollower++;
                }
            }
            
            return ret;
        }
        #endregion
    }
}
