using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateOcelotFiles.Helpers
{
    public static class PathHelper
    {
        public static string GetPath(string fileName)
        {
            return Path.GetDirectoryName(
                                                Directory.GetParent(
                                                      Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName)
                                                .Parent.FullName) + $"\\TCG.APIGateway\\TCG.APIGateway\\{fileName}";

        }
    }
}
