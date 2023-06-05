using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateOcelotFiles.OcelotClasses.SwaggerEndPoints
{
    public class SwaggerEndPoint
    {
        public string Key { get; set; }
        public List<ConfigItem> Config { get; set; }
    }
}