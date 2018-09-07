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
    public partial class Bottom : CommomControls
    {
        #region Field

        #endregion

        #region Constructor
        public Bottom() : base()
        {
            InitializeComponent();
        }
        public Bottom(StudentHelperMainForm owner) : base()
        {
            InitializeComponent();
            this.Owner = owner;
        }
        #endregion

        #region Property



        #endregion

        #region Method
        private void buttonConfiguration_Click(object sender, EventArgs e)
        {
            Owner.ButtonClickedForMain("Configuration");
        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {
            Owner.ButtonClickedForMain("Operation");
        }
        #endregion

        private void buttonPlan_Click(object sender, EventArgs e)
        {
            Owner.ButtonClickedForMain("Plan");
        }
    }
}
