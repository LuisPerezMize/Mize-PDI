using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDILibrary.Engine
{
    class ParseJsonFormObject
    {
        public void ParseJsonForm(string Json)
        {
            string data = Json.Replace("'", "\"");
            var value = Newtonsoft.Json.JsonConvert.DeserializeObject<Model.form>(data);
            int i = 0;
        }
    }
}
