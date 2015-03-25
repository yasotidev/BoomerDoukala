using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Doukala.Models;

namespace Doukala.Controllers
{
    public class CompagniesController : Controller
    {
        private DefaultContext db = new DefaultContext();

        // GET: Compagnies
        public ActionResult Index()
        {
            return View(db.Compagnies.ToList());
        }

        // GET: Compagnies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Compagny compagny = db.Compagnies.Find(id);
            if (compagny == null)
            {
                return HttpNotFound();
            }
            return View(compagny);
        }

        // GET: Compagnies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Compagnies/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,LogoAvatar,Logo,Nom,Description,Address,Activity,CodeNaf,SiretNumber,IntraCommunityVat,Email,WebSite,Manager,CreatedDate,ModifiedDate,RowVersion")] Compagny compagny)
        {
            if (ModelState.IsValid)
            {
                db.Compagnies.Add(compagny);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(compagny);
        }

        // GET: Compagnies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Compagny compagny = db.Compagnies.Find(id);
            if (compagny == null)
            {
                return HttpNotFound();
            }
            return View(compagny);
        }

        // POST: Compagnies/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,LogoAvatar,Logo,Nom,Description,Address,Activity,CodeNaf,SiretNumber,IntraCommunityVat,Email,WebSite,Manager,CreatedDate,ModifiedDate,RowVersion")] Compagny compagny)
        {
            if (ModelState.IsValid)
            {
                db.Entry(compagny).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(compagny);
        }

        // GET: Compagnies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Compagny compagny = db.Compagnies.Find(id);
            if (compagny == null)
            {
                return HttpNotFound();
            }
            return View(compagny);
        }

        // POST: Compagnies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Compagny compagny = db.Compagnies.Find(id);
            db.Compagnies.Remove(compagny);
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
