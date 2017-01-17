using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPageCommon;
using WebPageEF;

namespace WebPageRepo
{
    public class RepoDb : IRepository
    {
        string pageName;
        WebPageContext webPageContext = new WebPageContext();

        public RepoDb(string pageName)
        {
            this.pageName = pageName;
        }



        public CustomPage GetPage()
        {
            CustomPage page = new CustomPage();

            //page.Body.Content = "Get data from db via sqlcommand (pagename, Body, Content)";

            //return webPageContext.DbSetCustomPages.Find(1);


            page.Body = webPageContext.DbSetBody.Find(1);

            return page;
        }
    }
}
