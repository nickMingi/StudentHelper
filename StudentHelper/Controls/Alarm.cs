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
    public partial class Alarm : CommomControls
    {
        #region Define
        public enum ErrorList
        {
            DirectoryNotSelected = -1,
            NoJsonFileFound = -2,
            DirectoryNotExist = -3,
            GradeOfYearError = -4,
            GradeCreditInvalid = -5,
            GradeIsNotAppropriate = -6,
            RemainingCreditLessthanZero = -7,
            RemainingCostLessthanZero = -8,

            UserNameNull = -9999,
            GraduationCreditNull = -8888,
            CostNull = -7777,
        }
        #endregion

        #region Field
        private List<String> _AlarmName;
        private List<List<string>> _Alarms;

        #endregion

        #region Constructor
        public Alarm() : base()
        {
            InitializeComponent();
            AlarmName = new List<string>();
            Alarmss = new List<List<string>>();
        }
        public Alarm(StudentHelperMainForm owner) : base(owner)
        {
            InitializeComponent();
            AlarmName = new List<string>();
            Alarmss = new List<List<string>>();
        }
        #endregion

        #region Property

        public List<String> AlarmName
        {
            get { return this._AlarmName; }
            set { this._AlarmName = value; }
        }

        public List<List<string>> Alarmss
        {
            get { return this._Alarms; }
            set { this._Alarms = value; }
        }

        #endregion

        #region Method

        #region AlarmMaker
        public void AlarmMaker(string section, int alarmCode)
        {
            Owner.ButtonClickedForMain("Alarm");
            ErrorList error = (ErrorList)alarmCode;
            AlarmName.Add(section);
            AlarmName.Add(error.ToString());

            Alarmss.Add(AlarmName);
            OnDisplay();
        }

        public void AlarmMaker(string section, int alarmCode, string contents)
        {
            Owner.ButtonClickedForMain("Alarm");
            ErrorList error = (ErrorList)alarmCode;
            AlarmName.Add(section);
            AlarmName.Add(error.ToString());
            AlarmName.Add(contents);

            Alarmss.Add(AlarmName);
            OnDisplay();
        }
        #endregion

        #region OnDisplay
        public void OnDisplay()
        {
            if (Alarmss.Count > 0 )
            {
                this.dataGridViewAlarmList.Rows.Clear();
                for (int i = 0; i < Alarmss.Count; i++)
                {
                    this.dataGridViewAlarmList.Rows.Add();
                    this.dataGridViewAlarmList.Rows[i].Cells[0].Value = Alarmss[i][0].ToString();
                    this.dataGridViewAlarmList.Rows[i].Cells[1].Value = Alarmss[i][1].ToString();
                    if (Alarmss[i].Count>2)
                        this.dataGridViewAlarmList.Rows[i].Cells[2].Value = Alarmss[i][2].ToString();
                }
            }
            else
            {
                MessageBox.Show("All Alarms Cleared! Move to Configuration.");
                Owner.ButtonClickedForMain("Configuration");
            }
        }
        #endregion

        #endregion

        #region Confirm Button
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (Alarmss.Count > 0)
            {
                this.dataGridViewAlarmList.Rows.Clear();
                this.Alarmss.Clear();
                this.AlarmName.Clear();
            }
        }
        #endregion
    }
}
