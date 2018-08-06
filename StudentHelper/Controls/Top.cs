using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace StudentHelper
{
    public partial class Top : UserControl
    {

        #region Field
        private StudentHelperMainForm _Owner;

        #endregion

        #region Constructor
        public Top()
        {
            InitializeComponent();
            this.labelVersion.Text = Version;
        }

        public Top(StudentHelperMainForm owner)
        {
            InitializeComponent();
            this.Owner = owner;
            this.labelVersion.Text = Version;
        }
        #endregion

        #region Property

        public StudentHelperMainForm Owner
        {
            get { return _Owner; }
            set { _Owner = value; }
        }

        #endregion

        public static string Version
        {
            get
            {
                Assembly asm = Assembly.GetExecutingAssembly();
                FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(asm.Location);
                return String.Format("{0}", fvi.FileVersion);
            }
        }

        private void buttonAlarm_Click(object sender, EventArgs e)
        {
            Owner.ButtonClickedForMain("Alarm");
        }
    }
}
