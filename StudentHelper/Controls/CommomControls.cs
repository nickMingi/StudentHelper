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
    public partial class CommomControls : UserControl
    {
        #region Field
        private StudentHelperMainForm _Owner;
        #endregion

        #region Constructor
        public CommomControls()
        {
            InitializeComponent();
        }
        public CommomControls(StudentHelperMainForm owner)
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
    }
}
