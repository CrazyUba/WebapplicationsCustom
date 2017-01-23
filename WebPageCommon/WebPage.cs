

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPageCommon
{
    public class WebPage
    {
        public int  Id { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }


        public int WebSiteId { get; set; }      // EF-Property to create the foreign key

        [ForeignKey("WebSiteId")]
        public WebSite WebSite { get; set; }    // EF-Property to create the foreign key

    }
}
