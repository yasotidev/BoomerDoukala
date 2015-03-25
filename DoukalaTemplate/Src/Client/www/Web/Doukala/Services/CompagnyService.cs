using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Doukala.Models;

namespace Doukala.Services
{
    public class CompagnyService : IDisposable
    {

        private readonly DefaultContext _context = new DefaultContext();

        protected IDbSet<Compagny> DbSet;

        public virtual IQueryable<Compagny> Query
        {
            get { return DbSet; }
        }  
        #region Methods

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

        public virtual List<Compagny> GetAll()
        {
            return _context.Compagnies.ToList();
        }

        public virtual Compagny GetById(int? id)
        {
          return  _context.Compagnies.Find(id);
        }

        public virtual  void Create(Compagny compagny)
        {
            _context.Compagnies.Add(compagny);
        }

        public virtual void SaveOrUpdate()
        {
            _context.SaveChanges();
        }

        internal static void Remove(Compagny compagny)
        {
            throw new NotImplementedException();
        }
    }
}