

namespace WebPageCommon
{
    public class CustomPage
    {
        //private string customerName;
        //private string pageName;
      //  private IRepository repo;

        public string Title { get; set; }

        public Header Header { get; set; }

        public Body Body { get; set; }

        public Carousel Carousel { get; set; }

        //public Head Head { get; set; }

        //public Footer Footer { get; set; }


        public CustomPage()
        {
            //Title = new Title();
            Body = new Body();
            Header = new Header();
            //Head = new Head();
            //Footer = new Footer();

        }

        //public CustomPage(IRepository repo) : this()
        //{
        //    this.repo = repo;
        //    this.Title = this.repo.GetTitle();
        //    this.Body.Content = this.repo.GetBody();

        //    //this = repo.GetPage();
        //}

    }
    
    
}
