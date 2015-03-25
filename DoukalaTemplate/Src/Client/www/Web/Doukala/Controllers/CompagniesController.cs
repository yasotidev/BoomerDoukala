using System.Net;
using System.Web.Mvc;
using Doukala.Server.Core.Entities;
using Doukala.Services;
using Doukala.ViewModels;

namespace Doukala.Controllers
{
    public class CompagniesController : Controller
    {

        #region Members

        protected ICompagnyService CompagnyService;

        #endregion


        #region Contructor

        public CompagniesController()
            : this(new CompagnyService())
        {

        }

        //public CompagniesController()
        //{

        //}
        public CompagniesController(ICompagnyService service)
        {
            CompagnyService = service;
        }

        #endregion

        #region Metods

        #region  // GET: Compagnies

        // GET: Compagnies
        public ActionResult Index()
        {
            var compagnies = CompagnyService
                .GetAll();//.AsEnumerable();

           return View(compagnies);
        }

        #endregion


        #region    // GET: Compagnies/Details/5

        // GET: Compagnies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }


            Compagny compagny = CompagnyService.GetById(id);

            
            var model = new CompagnyViewModel
            {
                Logo = compagny.Logo,
                Nom = compagny.Nom,
                Activity = compagny.Activity,
                CodeNaf = compagny.CodeNaf,
                Description = compagny.Description,
                IntraCommunityVat = compagny.IntraCommunityVat,
                Email = compagny.Email,
                WebSite = compagny.WebSite,
                Address = new AddressViewModel
                {
                    Street = compagny.Address.Street,
                    Option = compagny.Address.Option,
                    ZipCode = compagny.Address.ZipCode,
                    City = compagny.Address.City,
                    State = compagny.Address.State,
                    Country = compagny.Address.Country,
                }   


            };
            if (compagny == null)
            {
                return HttpNotFound();
            }
            return View(compagny);
        }

        #endregion


        #region   // GET: Compagnies/Create

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
        public ActionResult Create(
            [Bind(
                Include =
                    "Id,LogoAvatar,Logo,Nom,Description,Address,Activity,CodeNaf,SiretNumber,IntraCommunityVat,Email,WebSite,Manager,CreatedDate,ModifiedDate,RowVersion"
                )] Compagny compagny)
        {
            if (ModelState.IsValid)
            {
                CompagnyService.Create(compagny);
                CompagnyService.SaveOrUpdate();


                return RedirectToAction("Index");
            }

            return View(compagny);
        }

        #endregion


        #region   // GET: Compagnies/Edit/5

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
        public ActionResult Edit(
            [Bind(
                Include =
                    "Id,LogoAvatar,Logo,Nom,Description,Address,Activity,CodeNaf,SiretNumber,IntraCommunityVat,Email,WebSite,Manager,CreatedDate,ModifiedDate,RowVersion"
                )] Compagny compagny)
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

        #endregion


        #region  // GET: Compagnies/Delete/5

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

        #endregion

        #region Search

        public ActionResult Search()
        {
            var model = new CompagnySearchViewModel();
            return View(model);
        }

        #endregion


        #endregion

         


    }
}
