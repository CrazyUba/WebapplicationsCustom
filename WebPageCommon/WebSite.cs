using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPageCommon
{
    public class WebSite
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public string WebSiteTitle { get; set; }

        public List<WebPage> WebPages { get; set; }
    }
}
