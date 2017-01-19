

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPageCommon
{
    public class CustomPage
    {
        public int  Id { get; set; }

        public string Description { get; set; }
        public Customer Customer { get; set; }

        public int TitleRefId { get; set; }

        [ForeignKey("TitleRefId")]
        public Title Title { get; set; }

        public SubTitle SubTitle { get; set; }


    }
}
