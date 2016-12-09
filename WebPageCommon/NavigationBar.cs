using System.Collections.Generic;

namespace WebPageCommon
{
    public class NavigationBar : HTMLSection
    {
        public List<Link> Links { get; set; }

        public NavigationBar()
        {
            Links = new List<Link>();
            Links.Add(new Link { Name = "TestLink" });
        }

    }
}