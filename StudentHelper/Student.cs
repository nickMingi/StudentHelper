using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHelper
{
    public class Student
    {
        #region Define
        public struct Classes
        {
            public string classes;
            public string grades;
        };
        #endregion

        #region Field
        private string _Year;
        private string _Degree;
        private string _College;
        private string _Username;
        private List<Classes> _Classes;
        private string _RemainingCredit;
        private string _RemainingCost;
        private string _GraduationGrade;
        private List<College.Classes> _MustTakeClasses;
        #endregion

        #region Property


        public List<College.Classes> MustTakeClasses
        {
            get { return _MustTakeClasses; }
            set { _MustTakeClasses = value; }
        }

        public string GraduationGrade
        {
            get { return _GraduationGrade; }
            set { _GraduationGrade = value; }
        }

        public string RemainingCost
        {
            get { return this._RemainingCost; }
            set { this._RemainingCost = value; }
        }

        public string RemainingCredit
        {
            get { return this._RemainingCredit; }
            set { this._RemainingCredit = value; }
        }

        public string Year
        {
            get { return this._Year; }
            set { this._Year = value; }
        }

        public string Degree
        {
            get { return this._Degree; }
            set { this._Degree = value; }
        }

        public string College
        {
            get { return this._College; }
            set { this._College = value; }
        }

        public string Username
        {
            get { return this._Username; }
            set { this._Username = value; }
        }

        public List<Classes> StudentClasses
        {
            get { return this._Classes; }
            set { this._Classes = value; }
        }


        #endregion

        #region Constructor
        public Student()
        {
            this.Username = Username;
            this.College = College;
            this.Degree = Degree;
            this.Year = Year;
            this.StudentClasses = StudentClasses;
        }
        #endregion

        #region Method

        #region Remaining Credit and Cost
        public int RemainingCreditCostCalculator(College college)
        {
            int ret = 0;

            int remainingcredit = int.Parse(college.GraduationCredit) - this.StudentClasses.Count * 3;
            if(remainingcredit <= 0)
            {
                return ret = -7;
            }
            this.RemainingCredit = string.Format("{0}",remainingcredit);

            int remainingcost = int.Parse(college.Cost) * (remainingcredit / 3);
            if(remainingcost <= 0)
            {
                return ret = -8;
            }
            this.RemainingCost = string.Format("{0}",remainingcost);

            return ret;
        }
        #endregion

        #region Student Average Grade
        public string StudentAverageGradeCal(List<Classes> classes)
        {
            string result = String.Empty;

            List<int> aveGrade = new List<int>();
            int value = 0;
            for (int i = 0; i < classes.Count; i++)
            {
                switch (classes[i].grades)
                {
                    case "A":
                        value = 100;
                        break;
                    case "B":
                        value = 89;
                        break;
                    case "C":
                        value = 79;
                        break;
                    case "D":
                        value = 69;
                        break;
                    case "F":
                        value = 59;
                        break;
                }
                aveGrade.Add(value);
            }

            int sum = 0;
            foreach (int item in aveGrade)
            {
                sum += item;
            }

            if(sum>0)
                sum = sum / aveGrade.Count();

            if (sum >= 90)
            {
                result = "A";
            }
            else if (sum >= 80)
            {
                result = "B";
            }
            else if (sum >= 70)
            {
                result = "C";
            }
            else if (sum >= 60)
            {
                result = "D";
            }
            else
            {
                result = "F";
            }
            return result;
        }
        #endregion

        #region Graduation Grade Cal
        public string GraduationGradeCal(string aveGrade)
        {
            string result = null;
            result = aveGrade;
            return result;
        }
        #endregion

        #endregion

    }
}
