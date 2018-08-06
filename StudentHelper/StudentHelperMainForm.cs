using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHelper
{
    public partial class StudentHelperMainForm : Form
    {
        #region Field
        #endregion

        #region Constructor
        public StudentHelperMainForm()
        {
            InitializeComponent();

        }
        public StudentHelperMainForm(string caption)
        {

        }
        #endregion

        #region Property
        [DefaultValue(false)]
        public bool AllowUserClosing { get; set; }
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
        #endregion
    }
}
