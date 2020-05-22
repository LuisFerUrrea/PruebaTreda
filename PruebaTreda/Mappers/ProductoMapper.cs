using Prueba.Trade.Business.Models;
using PruebaTreda.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTreda.Mappers
{
    public class ProductoMapper
    {
        public static Producto Map(ProductoModel model)
        {
            return new Producto()
            {
                Sku = model.Sku,
                Nombre = model.Nombre,
                Descripcion = model.Descripcion,
                Valor=model.Valor,
                TiendaId=model.TiendaId,
                Imagen=model.Imagen
            };

        }
    }
}
