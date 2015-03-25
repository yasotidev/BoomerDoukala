using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Doukala.Models;

namespace Doukala.Services
{
    public class CompagnyService : IDisposable
    {

        #region Members

        private readonly DefaultContext _context = new DefaultContext();

        protected IDbSet<Compagny> DbSet;

        #endregion
        
        #region Methods

        #region Query custom

        public virtual IQueryable<Compagny> Query
        {
            get { return DbSet; }
        }

        #endregion

        #region GetAll

        public virtual List<Compagny> GetAll()
        {
            return _context.Compagnies.ToList();
        }

        #endregion    

        #region GetById

        public virtual Compagny GetById(int? id)
        {
            return _context.Compagnies.Find(id);
        }

        #endregion  
               
        #region Add

        public virtual void Create(Compagny compagny)
        {
            _context.Compagnies.Add(compagny);
        }

        #endregion         

        #region SaveChnages

        public virtual void SaveOrUpdate()
        {
            _context.SaveChanges();
        }

        #endregion       

        #region Remove

        public virtual void Remove(Compagny compagny)
        {
            _context.Compagnies.Remove(compagny);
        }

        #endregion

        #region Dispose

        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }
        public void Dispose()
        {
            _context.Dispose();
        }
        #endregion   

       #endregion
    }
}