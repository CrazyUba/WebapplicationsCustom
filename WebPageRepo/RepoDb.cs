using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPageCommon;

namespace WebPageRepo
{
    class RepoDb : IRepository
    {
        string pageName;

        public RepoDb(string pageName)
        {
            this.pageName = pageName;
        }

        public CustomPage GetPage()
        {
            CustomPage page = new CustomPage();

            page.Body.Content = "Get data from db via sqlcommand (pagename, Body, Content)";

            return page;
        }
    }
}
