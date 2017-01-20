

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPageCommon
{
    public class WebPage
    {
        public int  Id { get; set; }

        public string Name { get; set; }
        //public int TitleRefId { get; set; }

        //[ForeignKey("TitleRefId")]
        //public Title Title { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

    }
}
