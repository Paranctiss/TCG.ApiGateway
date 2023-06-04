using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdateOcelotFiles.OcelotClasses.Routes;
using UpdateOcelotFiles.OcelotClasses.SwaggerEndPoints;

namespace UpdateOcelotFiles.OcelotClasses
{
    public class OcelotFile
    {
        public List<Route> Routes { get; set; }
        public List<SwaggerEndPoint> SwaggerEndPoints { get; set; }
    }
}
