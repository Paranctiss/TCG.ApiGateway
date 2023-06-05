using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdateOcelotFiles.OcelotClasses;

namespace UpdateOcelotFiles.Helpers
{
    public static class JsonHelper
    {
        public static OcelotFile Desarialize(string filePath)
        {
            return JsonConvert.DeserializeObject<OcelotFile>(File.ReadAllText(filePath));
        }

        public static void UpdateOcelotFile(string filePath, OcelotFile ocelotFile)
        {
            var ocelotFileString = JsonConvert.SerializeObject(ocelotFile);
            File.WriteAllText(filePath, ocelotFileString);
        }
    }
}
