using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCwithDB.Models;

namespace MVCwithDB.DataAccessLAyer
{
    public class SalesERPDAL: DbContext
    {
        public DbSet<Employee> employee { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("TblEmployee");
            base.OnModelCreating(modelBuilder);
        }
    }
}