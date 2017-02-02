using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebPageCommon;
using WebPageEF;

namespace CustomWeb2.Controllers
{
    [Authorize]
    public class WebPageController : Controller
    {
        private WebCmsContext db = new WebCmsContext();

        // GET: WebPage  
        public ActionResult Index()
        {
            var dbSetWebPages = db.DbSetWebPages.Include(w => w.WebSite);
            return View(dbSetWebPages.ToList());
        }

        // GET: WebPage/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WebPage webPage = db.DbSetWebPages.Find(id);
            if (webPage == null)
            {
                return HttpNotFound();
            }
            return View(webPage);
        }

        // GET: WebPage/Create
        public ActionResult Create()
        {
            ViewBag.WebSiteId = new SelectList(db.DbSetWebSites, "Id", "Url");
            return View();
        }

        // POST: WebPage/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Title,SubTitle,WebSiteId")] WebPage webPage)
        {
            if (ModelState.IsValid)
            {
                db.DbSetWebPages.Add(webPage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.WebSiteId = new SelectList(db.DbSetWebSites, "Id", "Url", webPage.WebSiteId);
            return View(webPage);
        }
        
        // GET: WebPage/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WebPage webPage = db.DbSetWebPages.Find(id);
            if (webPage == null)
            {
                return HttpNotFound();
            }
            ViewBag.WebSiteId = new SelectList(db.DbSetWebSites, "Id", "Url", webPage.WebSiteId);
            return View(webPage);
        }

        // POST: WebPage/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Title,SubTitle,WebSiteId")] WebPage webPage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(webPage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.WebSiteId = new SelectList(db.DbSetWebSites, "Id", "Url", webPage.WebSiteId);
            return View(webPage);
        }

        // GET: WebPage/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WebPage webPage = db.DbSetWebPages.Find(id);
            if (webPage == null)
            {
                return HttpNotFound();
            }
            return View(webPage);
        }

        // POST: WebPage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WebPage webPage = db.DbSetWebPages.Find(id);
            db.DbSetWebPages.Remove(webPage);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
