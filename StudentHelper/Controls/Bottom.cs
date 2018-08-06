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
    public partial class Bottom : UserControl
    {
        #region Field
        private StudentHelperMainForm _Owner;
        #endregion

        #region Constructor
        public Bottom()
        {
            InitializeComponent();
        }
        public Bottom(StudentHelperMainForm owner)
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

        private void buttonConfiguration_Click(object sender, EventArgs e)
        {
            Owner.ButtonClickedForMain("Configuration");
        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {
            Owner.ButtonClickedForMain("Operation");
        }
    }
}
