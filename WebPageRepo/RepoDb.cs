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
        string _webSiteUrl;
        WebCmsContext webCmsContext = new WebCmsContext();

        public RepoDb(string webSiteUrl)
        {
            this._webSiteUrl = webSiteUrl;
        }



        public WebPage GetPageBy(string webPageName)
        {

            WebSite webSite = webCmsContext.DbSetWebSites.Where(ws => ws.Url == this._webSiteUrl).First();
            WebPage webPage = webCmsContext.DbSetWebPages.Where(p => p.WebSiteId == webSite.Id).First();

            return webPage;

            
            
            //page.Title = (from t in webPageContext.DbSetTitles join p in webPageContext.DbSetCustomPages on t.Id equals p.TitleRefId where p.Id == page.Id select t).First();

            //return page;




            //page.Body.Content = "Get data from db via sqlcommand (pagename, Body, Content)";

            //return webPageContext.DbSetCustomPages.Find(1);


            //page.Body = webPageContext.DbSetBody.Find(1);

            // page = webPageContext.DbSetCustomPages.Find(2);

            //var title = (from t in webPageContext.DbSetTitles select t).First();  // OK
            //var title3 = webPageContext.DbSetTitles.First(t => t.Id == page.TitleRefId);  // OK

            //var pageAndTitle = webPageContext.DbSetTitles.Join(       // OK
            //    inner: webPageContext.DbSetCustomPages,
            //    outerKeySelector: t => t.Id,
            //    innerKeySelector: p => p.TitleRefId,
            //    resultSelector: (t, p) => new { Custompage = p, Title = t }
            //    ).First();

        }
    }
}
