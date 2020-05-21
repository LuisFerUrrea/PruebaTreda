using Microsoft.EntityFrameworkCore;
using Prueba.Trade.DataAccess.Contracts;
using Prueba.Trade.DataAccess.Contracts.Entities;
using Prueba.Trade.DataAccess.EntityConfig;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.Trade.DataAccess
{
    public class PruebaTredaDBContext : DbContext, IPruebaTredaDBContext
    {

        public DbSet<ProductoEntity> Productos { get; set; }

        public DbSet<TiendaEntity> Tiendas { get; set; }



        public PruebaTredaDBContext(DbContextOptions options) : base(options) { }

        public PruebaTredaDBContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ProductoEntityConfig.SetEntityBuilder(modelBuilder.Entity<ProductoEntity>());
            TiendaEntityConfig.SetEntityBuilder(modelBuilder.Entity<TiendaEntity>());

            base.OnModelCreating(modelBuilder);

        }
    }
}
