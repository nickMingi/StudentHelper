using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace StudentHelperCPUNamespace
{
    public class StudentHelperCPU
    {
        #region Constructor
        public StudentHelperCPU()
        {

        }
        #endregion

        #region Method
        public void MakeJsonFile()
        {
            var json = new JObject();
            json.Add("Property","Mingi");

            string str_json = JsonConvert.SerializeObject(json);
            System.Diagnostics.Debug.WriteLine(str_json);
            JsonConvert.SerializeObject(json,Formatting.Indented);
        }
        #endregion
    }
}
