using Prueba.Trade.Business.Models;
using Prueba.Trade.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.Trade.DataAccess.Mappers
{
    public static class ProductoMapper
    {
        public static ProductoEntity Map(Producto dto)
        {
            return new ProductoEntity()
            {
                Sku = dto.Sku,    
                Nombre = dto.Nombre,
                Descripcion = dto.Descripcion,
                Valor=dto.Valor,
                Imagen=dto.Imagen,
                TiendaId=dto.TiendaId

            };
        }

        public static Producto Map(ProductoEntity entity)
        {
            return new Producto()
            {
                Sku = entity.Sku,
                Nombre = entity.Nombre,
                Descripcion = entity.Descripcion,
                Valor = entity.Valor,
                Imagen = entity.Imagen,
                TiendaId = entity.TiendaId
            };
        }

    }
}
