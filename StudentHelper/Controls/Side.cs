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
    public partial class Side : UserControl
    {

        #region Field
        private StudentHelperMainForm _Owner;

        #endregion

        #region Constructor
        public Side()
        {
            InitializeComponent();
        }
        public Side(StudentHelperMainForm owner)
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

        #endregion

        private void buttonExit_Click(object sender, EventArgs e)
        {
            var ExitConfirm = MessageBox.Show("Are you sure to EXIT the Program??", "EXIT",MessageBoxButtons.YesNo);
            if ( ExitConfirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
