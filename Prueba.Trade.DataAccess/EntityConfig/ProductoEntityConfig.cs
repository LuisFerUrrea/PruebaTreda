using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prueba.Trade.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.Trade.DataAccess.EntityConfig
{
    public class ProductoEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<ProductoEntity> entityBuilder)
        {
            entityBuilder.ToTable("Productos");
            entityBuilder.HasKey(x => x.Sku);
            entityBuilder.HasOne(x => x.Tienda).WithMany(x => x.Productos).HasForeignKey(x => x.TiendaId);
            entityBuilder.Property(x => x.Sku).IsRequired();
            entityBuilder.Property(x => x.TiendaId).IsRequired();
            entityBuilder.Property(x => x.Nombre).IsRequired();
            entityBuilder.Property(x => x.Descripcion).IsRequired();
            entityBuilder.Property(x => x.Imagen).IsRequired();
        }       
    }
}
