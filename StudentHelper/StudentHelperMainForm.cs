using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentHelperCPUNamespace;

namespace StudentHelper
{
    public partial class StudentHelperMainForm : Form
    {
        #region Field
        private Maintenance _Maintenance;
        private ConfigurationMaintenance _Configuration;
        private Bottom _Bottom;
        private Top _Top;
        private Side _Side;
        private Alarm _Alarm;

        #endregion

        #region Constructor
        public StudentHelperMainForm()
        {
            InitializeComponent();
            Configuration = new ConfigurationMaintenance(this);
            Maintenance = new Maintenance(this);
            Bottom = new Bottom(this);
            Top = new Top(this);
            Side = new Side(this);
            Alarm = new Alarm(this);
            this.groupBoxMainControl.Controls.Add(Configuration);
            this.groupBoxBottomControl.Controls.Add(Bottom);
            this.groupBoxTopControl.Controls.Add(Top);
            this.groupBoxSideControl.Controls.Add(Side);

            OnDisplay();

            //Timer timer = new Timer();
            //timer.Interval = 1000;
            //timer.Start();
        }
        public StudentHelperMainForm(string caption)
        {

        }

        //public StudentHelper Target => new StudentHelper();
        #endregion

        #region Property
        [DefaultValue(false)]
        public bool AllowUserClosing { get; set; }


        public Alarm Alarm
        {
            get { return _Alarm; }
            set { _Alarm = value; }
        }


        public Side Side
        {
            get { return _Side; }
            set { _Side = value; }
        }


        public Top Top
        {
            get { return _Top; }
            set { _Top = value; }
        }

        public Bottom Bottom
        {
            get { return _Bottom; }
            set { _Bottom = value; }
        }

        public ConfigurationMaintenance Configuration
        {
            get { return this._Configuration; }
            set { this._Configuration = value; }
        }
        
        public Maintenance  Maintenance
        {
            get { return this._Maintenance; }
            set { this._Maintenance = value; }
        }
        #endregion

        #region Form Members
        protected override void OnLoad(EventArgs e)
        {
            //FormChild form = null;
            //ISupportForm supportForm = 
            //base.OnLoad(e);

            //if (supportForm != null)
            //{
            //    form = 
            //}
        }

        protected async void OnDisplay()
        {
            bool check = true;
            while (check)
            {
                if (this.groupBoxMainControl.Controls.ContainsKey("Maintenance"))
                {
                        check = await IntervalCal(2000);
                        Maintenance.OnDisplay();
                }
                else if (this.groupBoxMainControl.Controls.ContainsKey("Alarm"))
                {
                        check = await IntervalCal(2000);
                        Alarm.OnDisplay();
                }
                else
                {
                        check = await IntervalCal(2000);
                }
            }
        }

        private async Task<bool> IntervalCal(int interval)
        {
            bool result = true;
            
                await Task.Delay(interval);
                
            return result;
        }
        #endregion

        #region Method

        #region Main Form Button
        public void ButtonClickedForMain(string buttonName)
        {
            this.groupBoxMainControl.Controls.Clear();
            switch (buttonName)
            {
                case "Configuration":
                    this.groupBoxMainControl.Controls.Add(Configuration);
                    break;
                case "Operation":
                    this.groupBoxMainControl.Controls.Add(Maintenance);
                    break;
                case "Alarm":
                    this.groupBoxMainControl.Controls.Add(Alarm);
                    break;
            }
        }
        #endregion

        #endregion
    }
}
