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
    public class WebSiteController : Controller
    {
        private WebCmsContext db = new WebCmsContext();

        // GET: WebSite
        public ActionResult Index()
        {
            return View(db.DbSetWebSites.ToList());
        }

        // GET: WebSite/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WebSite webSite = db.DbSetWebSites.Find(id);
            if (webSite == null)
            {
                return HttpNotFound();
            }
            return View(webSite);
        }

        // GET: WebSite/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WebSite/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Url,WebSiteTitle")] WebSite webSite)
        {
            if (ModelState.IsValid)
            {
                db.DbSetWebSites.Add(webSite);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(webSite);
        }

        // GET: WebSite/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WebSite webSite = db.DbSetWebSites.Find(id);
            if (webSite == null)
            {
                return HttpNotFound();
            }
            return View(webSite);
        }

        // POST: WebSite/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Url,WebSiteTitle")] WebSite webSite)
        {
            if (ModelState.IsValid)
            {
                db.Entry(webSite).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(webSite);
        }

        // GET: WebSite/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WebSite webSite = db.DbSetWebSites.Find(id);
            if (webSite == null)
            {
                return HttpNotFound();
            }
            return View(webSite);
        }

        // POST: WebSite/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WebSite webSite = db.DbSetWebSites.Find(id);
            db.DbSetWebSites.Remove(webSite);
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
