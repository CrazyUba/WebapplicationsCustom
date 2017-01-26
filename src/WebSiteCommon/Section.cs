using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSiteCommon
{
    public class Section
    {
        public string Title { get; set; }
        public Carousel Carousel { get; set; }

        public Link LinkToMoreInformation { get; set; }
    }
}
