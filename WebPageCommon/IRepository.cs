
namespace WebPageCommon
{
    public interface IRepository
    {
       // string GetTitle();

        //string GetBody();

        WebPage GetPageBy(string webPageName);

    }
}
