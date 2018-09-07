using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;

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

        #region Method

        protected virtual void OnDisplay()
        {

        }

        protected virtual string FileNameSelector()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.AddExtension = true;
            saveFile.DefaultExt = "csv";
            string filename = null;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                filename = saveFile.FileName;
            }
            else
            {
                this.Owner.Alarm.AlarmMaker(this.ToString(),-2000,"No File Name");
                return null;
            }

            return filename;
        }

        protected virtual JObject FileReadAndSaveToJson(string tempFile)
        {
            string result = string.Empty;
            var jobj = new JObject();
            using (StreamReader r = new StreamReader(tempFile))
            {
                var json = r.ReadToEnd();
                jobj = JObject.Parse(json);
                result = jobj.ToString();
                Console.WriteLine(result);
            }

            return jobj;
        }
        #endregion
    }
}
