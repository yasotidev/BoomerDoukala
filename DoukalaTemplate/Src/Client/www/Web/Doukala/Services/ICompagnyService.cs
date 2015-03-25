using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Doukala.Server.Core.Data;
using Doukala.Server.Core.Entities;

namespace Doukala.Services
{
    public interface ICompagnyService : IDisposable
    {
        IDataContext DataContext { get; }
        IQueryable<Compagny> Query { get; }
        IQueryable<Compagny> GetAll();
        IQueryable<Compagny> GetAllReadOnly();
        Compagny GetById(int? id);
        void Create(Compagny compagny);
        void SaveOrUpdate();
        void Remove(Compagny compagny);
        IEnumerable<Compagny> Find(Expression<Func<Compagny, bool>> expression, int maxHits = 100);
        long Count();
        long Count(Expression<Func<Compagny, bool>> expression);
        void Dispose(bool disposing);
    }
}