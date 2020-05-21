using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prueba.Trade.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.Trade.DataAccess.EntityConfig
{
    public class TiendaEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<TiendaEntity> entityBuilder)
        {
            entityBuilder.ToTable("Tiendas");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();
        }
    }
}
