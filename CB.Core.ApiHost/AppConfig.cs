using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CB.Core.ApiHost
{
    public class AppConfig
    {
        public Urls Urls { get; set; }
    }
    public class Urls
    {
        public string URL_AUDITORIA_API { get; set; }
        public string URL_MENSAJERIA_API { get; set; }
    }
}
