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
    public class WebCmsContext : DbContext
    {
        public DbSet<WebSite> DbSetWebSites { get; set; }
        public DbSet<WebPage> DbSetWebPages { get; set; }


        public WebCmsContext()
        {

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<WebCmsContext, WebPageEF.Migrations.Configuration>());
            CheckForConfigFile();

            //Head head = new Head { Content = "This is the head" };

            try
            {
                //DbSetHeads.Add(head);
                //this.SaveChanges();
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

        private static void CheckForConfigFile()
        {
            string configFilename = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;

            if (!File.Exists(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile))
            {
                throw new Exception("Config-File '" + AppDomain.CurrentDomain.SetupInformation.ConfigurationFile + "' does not exist");
            }

            string strConnectionString = ConfigurationManager.ConnectionStrings["WebCmsContext"].ConnectionString;

            if (string.IsNullOrEmpty(strConnectionString))
            {
                throw new Exception("Config-File '" + AppDomain.CurrentDomain.SetupInformation.ConfigurationFile + "' exist. But 'connectionString' is empty.");
            }
        }
    }


}
