using System.Net;
using System.Web.Mvc;
using Doukala.Models;
using Doukala.Services;

namespace Doukala.Controllers
{
    public class CompagniesController : Controller
    {
        
        protected CompagnyService CompagnyService;

        public CompagniesController()
            :this(new CompagnyService())
        {
            
        }

        public CompagniesController(CompagnyService service)
        {
            CompagnyService = service;
        }
        // GET: Compagnies
        public ActionResult Index()
        {
            return View(CompagnyService.GetAll());
        }

        // GET: Compagnies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }


            Compagny compagny = CompagnyService.GetById(id); 
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
                CompagnyService.Create(compagny);
                CompagnyService.SaveOrUpdate();
                
               
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
            Compagny compagny = CompagnyService.GetById(id);
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
            Compagny entityCompagny = CompagnyService.GetById(compagny.Id);
            if (ModelState.IsValid)
            {
                UpdateModel(entityCompagny);
                CompagnyService.SaveOrUpdate();
                
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
            Compagny compagny = CompagnyService.GetById(id);
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

            Compagny compagny = CompagnyService.GetById(id);

            CompagnyService.Remove(compagny);
            CompagnyService.SaveOrUpdate();
           
            return RedirectToAction("Index");
        }
    }
}
