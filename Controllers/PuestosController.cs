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
    public class PuestosController : Controller
    {
        private RICHIJOBEntities db = new RICHIJOBEntities();

        // GET: Puestos
        [AllowAnonymous]
        public ActionResult Index()
        {
            var rJ_PUESTOS = db.RJ_PUESTOS.Include(r => r.RJ_CATEGORIAS);
            return View(rJ_PUESTOS.ToList());
        }

        // GET: Puestos/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RJ_PUESTOS rJ_PUESTOS = db.RJ_PUESTOS.Find(id);
            if (rJ_PUESTOS == null)
            {
                return HttpNotFound();
            }
            return View(rJ_PUESTOS);
        }

        // GET: Puestos/Create
        [AllowAnonymous]
        public ActionResult Create()
        {
            ViewBag.RJ_CATEGORIAS_ID = new SelectList(db.RJ_CATEGORIAS, "RJ_CATEGORIAS_ID", "DESCRIPCION");
            return View();
        }

        // POST: Puestos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RJ_PUESTOS_ID,COMPANIA,TIPO,LOGO,URL,POSICION,UBICACION,RJ_CATEGORIAS_ID,DESCRIPCION,EMAIL,PERMISOS_AFILIADOS,FECHA_INICIO,FECHA_FINAL,ESTADO")] RJ_PUESTOS rJ_PUESTOS)
        {
            if (ModelState.IsValid)
            {
                db.RJ_PUESTOS.Add(rJ_PUESTOS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RJ_CATEGORIAS_ID = new SelectList(db.RJ_CATEGORIAS, "RJ_CATEGORIAS_ID", "DESCRIPCION", rJ_PUESTOS.RJ_CATEGORIAS_ID);
            return View(rJ_PUESTOS);
        }

        // GET: Puestos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RJ_PUESTOS rJ_PUESTOS = db.RJ_PUESTOS.Find(id);
            if (rJ_PUESTOS == null)
            {
                return HttpNotFound();
            }
            ViewBag.RJ_CATEGORIAS_ID = new SelectList(db.RJ_CATEGORIAS, "RJ_CATEGORIAS_ID", "DESCRIPCION", rJ_PUESTOS.RJ_CATEGORIAS_ID);
            return View(rJ_PUESTOS);
        }

        // POST: Puestos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RJ_PUESTOS_ID,COMPANIA,TIPO,LOGO,URL,POSICION,UBICACION,RJ_CATEGORIAS_ID,DESCRIPCION,EMAIL,PERMISOS_AFILIADOS,FECHA_INICIO,FECHA_FINAL,ESTADO")] RJ_PUESTOS rJ_PUESTOS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rJ_PUESTOS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RJ_CATEGORIAS_ID = new SelectList(db.RJ_CATEGORIAS, "RJ_CATEGORIAS_ID", "DESCRIPCION", rJ_PUESTOS.RJ_CATEGORIAS_ID);
            return View(rJ_PUESTOS);
        }

        // GET: Puestos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RJ_PUESTOS rJ_PUESTOS = db.RJ_PUESTOS.Find(id);
            if (rJ_PUESTOS == null)
            {
                return HttpNotFound();
            }
            return View(rJ_PUESTOS);
        }

        // POST: Puestos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RJ_PUESTOS rJ_PUESTOS = db.RJ_PUESTOS.Find(id);
            db.RJ_PUESTOS.Remove(rJ_PUESTOS);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public ActionResult Categoria(int? id)
        {
            var rJ_PUESTOS = db.RJ_PUESTOS.Where(p => p.RJ_CATEGORIAS_ID == id);
            return View(rJ_PUESTOS);
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
