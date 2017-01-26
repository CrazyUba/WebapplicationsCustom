
namespace WebSiteCommon
{
    public interface IRepository
    {
       // string GetTitle();

        //string GetBody();

        WebPage GetPageBy(string webPageName);

    }
}
