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
    public partial class Top : CommomControls
    {

        #region Field

        #endregion

        #region Constructor
        public Top() : base()
        {
            InitializeComponent();
            this.labelVersion.Text = Version;
        }

        public Top(StudentHelperMainForm owner) : base(owner)
        {
            InitializeComponent();
            this.labelVersion.Text = Version;
        }
        #endregion

        #region Property

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
