using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateOcelotFiles.OcelotClasses.Routes
{
    public class Route
    {
        public string UpstreamPathTemplate { get; set; }
        public List<string> UpstreamHttpMethod { get; set; }
        public string DownstreamScheme { get; set; }
        public List<DownstreamHostAndPortItem> DownstreamHostAndPorts { get; set; }
        public string DownstreamPathTemplate { get; set; }
        public string SwaggerKey { get; set; }
    }
}
