using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Richi.Shop._1;

namespace Richi.Shop._1.Controllers
{
    [Authorize]
    public class CategoriasController : Controller
    {
        private RICHIJOBEntities db = new RICHIJOBEntities();

        // GET: Categorias
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View(db.RJ_CATEGORIAS.ToList());
        }

        // GET: Categorias/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RJ_CATEGORIAS rJ_CATEGORIAS = db.RJ_CATEGORIAS.Find(id);
            if (rJ_CATEGORIAS == null)
            {
                return HttpNotFound();
            }
            return View(rJ_CATEGORIAS);
        }

        // GET: Categorias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categorias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RJ_CATEGORIAS_ID,DESCRIPCION,ESTADO")] RJ_CATEGORIAS rJ_CATEGORIAS)
        {
            if (ModelState.IsValid)
            {
                db.RJ_CATEGORIAS.Add(rJ_CATEGORIAS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rJ_CATEGORIAS);
        }

        // GET: Categorias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RJ_CATEGORIAS rJ_CATEGORIAS = db.RJ_CATEGORIAS.Find(id);
            if (rJ_CATEGORIAS == null)
            {
                return HttpNotFound();
            }
            return View(rJ_CATEGORIAS);
        }

        // POST: Categorias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RJ_CATEGORIAS_ID,DESCRIPCION,ESTADO")] RJ_CATEGORIAS rJ_CATEGORIAS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rJ_CATEGORIAS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rJ_CATEGORIAS);
        }

        // GET: Categorias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RJ_CATEGORIAS rJ_CATEGORIAS = db.RJ_CATEGORIAS.Find(id);
            if (rJ_CATEGORIAS == null)
            {
                return HttpNotFound();
            }
            return View(rJ_CATEGORIAS);
        }

        // POST: Categorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RJ_CATEGORIAS rJ_CATEGORIAS = db.RJ_CATEGORIAS.Find(id);
            db.RJ_CATEGORIAS.Remove(rJ_CATEGORIAS);
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
