namespace WebApplication1.DbContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;

    public class BussinessDbContext : DbContext
    {
        public BussinessDbContext() :base() { 

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
        

    }
}
