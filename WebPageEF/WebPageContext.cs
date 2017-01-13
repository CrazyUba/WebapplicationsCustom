using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPageCommon;

namespace WebPageEF
{
    public class WebPageContext : DbContext
    {
        public DbSet<Body> DbSetBody { get; set; }

        //string x = ConfigurationManager.ConnectionStrings["WebPageContext"].ConnectionString

        public WebPageContext():base("Server=SMW7W004;Database=WebCMS;User Id=ASPDemo;Password=ASPDemo;")
        {
            Body body = new Body();
            body.Content = "44";
            DbSetBody.Add(body);
            this.SaveChanges();
        }
    
    }


}
