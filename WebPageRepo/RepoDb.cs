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


            //page.Body = webPageContext.DbSetBody.Find(1);
           
            page = webPageContext.DbSetCustomPages.Find(2);
            var titles = from t in webPageContext.DbSetTitles join p in webPageContext.DbSetCustomPages on t.Id equals p.TitleRefId where p.Id == page.Id select t;

            //var title = (from t in webPageContext.DbSetTitles select t).First();  // OK
            var title3 = webPageContext.DbSetTitles.First(t => t.Id == page.TitleRefId);  // OK

            var pageAndTitle = webPageContext.DbSetTitles.Join(
                inner: webPageContext.DbSetCustomPages,
                outerKeySelector: t => t.Id,
                innerKeySelector: p => p.TitleRefId,
                resultSelector: (t, p) => new { Custompage = p, Title = t }
                ).First();

            page.Title = titles.First();
            return page;
        }
    }
}
