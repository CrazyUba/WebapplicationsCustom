﻿using System.Collections.Generic;

namespace WebSiteCommon
{
    public class NavigationBar
    {
        public List<Link> Links { get; set; }

        public NavigationBar()
        {
            Links = new List<Link>();
            Links.Add(new Link { Name = "TestLink" });
        }

    }
}