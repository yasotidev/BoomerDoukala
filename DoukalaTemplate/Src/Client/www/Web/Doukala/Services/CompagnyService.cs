using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Doukala.Server.Core.Data;
using Doukala.Server.Core.Entities;

namespace Doukala.Services
{
    public class CompagnyService :  ICompagnyService
    {

        #region Members

        protected readonly DefaultContext Context = new DefaultContext();

        protected IDbSet<Compagny> DbSet;

        public CompagnyService()
        {
            DbSet = Context.Set<Compagny>();
        }

        public IDataContext DataContext
        {
            get { return Context; }
        } 
        #endregion
        
        #region Methods

        #region Query custom

        public  IQueryable<Compagny> Query
        {
            get { return DbSet; }
        }

        #endregion

        #region GetAll

        public virtual IQueryable<Compagny> GetAll()
        {
            return Query; //_context.Compagnies.ToList();
        }

        #endregion

        #region GetAll ReadOnly

        public virtual IQueryable<Compagny> GetAllReadOnly()
        {
            return Query.AsNoTracking(); //Context.Compagnies.AsNoTracking();
        }

        #endregion


        #region GetById

        public virtual Compagny GetById(int? id)
        {
            return Query.SingleOrDefault(o => o.Id == id) ;// _context.Compagnies.Find(id);
        }

        #endregion  
               
        #region Add

        public virtual void Create(Compagny compagny)
        {
            Context.Compagnies.Add(compagny);
        }

        #endregion         

        #region SaveChnages

        public virtual void SaveOrUpdate()
        {
            Context.SaveChanges();
        }

        #endregion       

        #region Remove

        public virtual void Remove(Compagny compagny)
        {
            DbSet.Remove(compagny);// _context.Compagnies.Remove(compagny);
        }

        #endregion

        #region Find

        public virtual IEnumerable<Compagny> Find(Expression<Func<Compagny, bool>> expression, int maxHits = 100)
        {
            return Query.Where(expression).Take(maxHits);
        }

        #endregion


        #region Count

        public long Count()
        {
            return DbSet.LongCount();
        }

        public long Count(Expression<Func<Compagny, bool>> expression)
        {
            return expression != null ? DbSet.Where(expression).LongCount() : Count();
        }

        #endregion


        #region Dispose

        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                Context.Dispose();
            }
            GC.SuppressFinalize(this);
        }
        public void Dispose()
        {
            Context.Dispose();
        }
        #endregion   

       #endregion
    }
}