using Microsoft.EntityFrameworkCore;
using Prueba.Trade.DataAccess.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.Trade.DataAccess
{
    public class PruebaTredaDBContext : DbContext, IPruebaTredaDBContext
    {


        public PruebaTredaDBContext(DbContextOptions options) : base(options) { }

        public PruebaTredaDBContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //AdminEntityConfig.SetEntityBuilder(modelBuilder.Entity<AdminEntity>());
            //BookingEntityConfig.SetEntityBuilder(modelBuilder.Entity<BookingEntity>());
            

            base.OnModelCreating(modelBuilder);

        }
    }
}
