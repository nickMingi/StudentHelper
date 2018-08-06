using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHelper
{
    public class College
    {
        #region Define
        public struct Classes
        {
            public string section;
            public string classes;
        };
        #endregion

        #region Field
        private string _GraduationCredit;
        private string _Cost;
        private List<Classes> _Classes;
        #endregion

        #region Property
        
        public string GraduationCredit
        {
            get { return _GraduationCredit; }
            set { _GraduationCredit = value; }
        }
        
        public string Cost
        {
            get { return _Cost; }
            set { _Cost = value; }
        }

        public List<Classes> CollegeClasses
        {
            get { return this._Classes; }
            set { this._Classes = value; }
        }

        #endregion

        #region Constructor
        public College()
        {

        }
        #endregion



    }
}
