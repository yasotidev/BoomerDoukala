﻿using System.Data.Entity;

namespace Doukala.Models
{
    public class DefaultContext : DataContext<DefaultContext>
    {

        public DbSet<Compagny> Compagnies { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ComplexType<Address>();
            modelBuilder.ComplexType<Manager>();
        }
    }
}