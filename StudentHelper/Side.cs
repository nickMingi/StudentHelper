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
        public Side()
        {
            InitializeComponent();
        }

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
