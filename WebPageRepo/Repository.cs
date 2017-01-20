using System;
using WebPageCommon;

namespace WebPageRepo
{
    public class Repository : IRepository
    {
        public Repository(string customerName, string pageName)
        {
            Body = "MyBodyTest";
        }

        public string Body { get; set; }

        public string GetBody()
        {
            throw new NotImplementedException();
        }

        public WebPage GetPageBy(string customerName)
        {
            throw new NotImplementedException();
        }

        public string GetTitle()
        {
            return "TestTitle_PageAbout";
        }

        public string SetCustomerAndPageName()
        {
            throw new NotImplementedException();
        }
    }
}
