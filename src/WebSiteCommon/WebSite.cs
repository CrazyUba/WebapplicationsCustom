using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSiteCommon
{
    public class WebSite
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public string WebSiteTitle { get; set; }

        public List<WebPage> WebPages { get; set; }
    }
}
