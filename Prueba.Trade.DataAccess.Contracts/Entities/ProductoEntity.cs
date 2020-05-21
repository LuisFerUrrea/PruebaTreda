using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.Trade.DataAccess.Contracts.Entities
{
    public class ProductoEntity
    {
        public string Sku { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public decimal Valor { get; set; }

        public int TiendaId { get; set; }

        public string Imagen { get; set; }

        public virtual TiendaEntity Tienda { get; set; }

    }
}
