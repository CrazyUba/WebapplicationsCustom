using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPageCommon;

namespace WebPageEF
{
    public class WebPageContext : DbContext
    {
        public DbSet<Body> DbSetBody { get; set; }
        //public DbSet<CustomPage> DbSetCustomPages { get; set; }

        //string x = ConfigurationManager.ConnectionStrings["WebPageContext"].ConnectionString

        public WebPageContext()
        {

            string configFilename = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;

            if (!File.Exists(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile))
            {
                throw new Exception("Config-File '" + AppDomain.CurrentDomain.SetupInformation.ConfigurationFile + "' does not exist");
            }

            string strConnectionString = ConfigurationManager.ConnectionStrings["WebPageContext"].ConnectionString;

            if (string.IsNullOrEmpty(strConnectionString))
            {
                throw new Exception("Config-File '" + AppDomain.CurrentDomain.SetupInformation.ConfigurationFile + "' exist. But 'connectionString' is empty.");
            }

            //CustomPage customPage = new CustomPage();
            //Body body = new Body { Content = "Hey, EF-Test" };
            //List<Body> bodies = new List<Body>();
            //customPage.Bodies = bodies;
            //customPage.Bodies.Add(body);

            //try
            //{
            //    DbSetCustomPages.Add(customPage);
            //    this.SaveChanges();
            //}
            //catch (Exception exc)
            //{
            //    string innerExceptionMessage = "";
            //    string innerInnerExceptionMessage = "";

            //    if (exc.InnerException != null)
            //    {
            //        innerExceptionMessage = exc.InnerException.Message;
            //    }

            //    if (exc.InnerException != null && exc.InnerException.InnerException != null)
            //    {
            //        innerInnerExceptionMessage = exc.InnerException.InnerException.Message;
            //    }

            //    throw new Exception(exc.Message + " Inner-Exception: '" + innerExceptionMessage + "' Inner-Inner-Exception: '" + innerInnerExceptionMessage + "'");
            //}


           
            
            
/*            
            Body body = new Body();
            body.Content = "44";

            try
            {
                DbSetBody.Add(body);
                this.SaveChanges();
            }
            catch (Exception exc)
            {
                string innerExceptionMessage = "";
                string innerInnerExceptionMessage = "";

                if (exc.InnerException != null)
                {
                    innerExceptionMessage = exc.InnerException.Message;
                }

                if (exc.InnerException != null && exc.InnerException.InnerException != null)
                {
                    innerInnerExceptionMessage = exc.InnerException.InnerException.Message;
                }

                throw new Exception(exc.Message + " Inner-Exception: '" + innerExceptionMessage + "' Inner-Inner-Exception: '" + innerInnerExceptionMessage + "'");
            }
            */
        }
    
    }


}
