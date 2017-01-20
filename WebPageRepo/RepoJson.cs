using Newtonsoft.Json;
using System;
using System.IO;
using WebPageCommon;

namespace WebPageRepo
{
    public class RepoJson : IRepository
    {

        WebPage page;
       // string customerName;
        string pageName;


        public RepoJson(string pageName)
        {
           // this.customerName = customerName;
            this.pageName = pageName;

            LoadJson();
        }

     

        public string GetTitle()
        {
            //return page.Title.ToString() ?? "";
            return "";
        }

        public WebPage GetPageBy(string customerName)
        {
            return page;
        }

        //public class AboutPage
        //{
        //    public string Title { get; set; }
        //    public string Body { get; set; }
        //}


        public void LoadJson()
        {
            try
            {
                using (StreamReader file = File.OpenText(@".\Data\" + pageName + "Data.json"))
                {
                    string json = file.ReadToEnd();
                    page = JsonConvert.DeserializeObject<WebPage>(json);
                    //string a = page?.Body.Content;
                    //string b = page?.Title;
                    //string c = page.Carousel.PictureList[0] ?? "";
//                    int x = 4;
                }
            }
            catch (Exception e)
            {
                throw new Exception(this.GetType().FullName + "::RepoJsonLoadJson: " + e.Message);
            }

        }

        public string GetBody()
        {
            //return page.Body.Content ?? "";
            return "body";
        }
    }
}
