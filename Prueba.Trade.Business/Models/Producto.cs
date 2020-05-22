using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.Trade.Business.Models
{
    public class Producto
    {
        public string Sku { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public decimal Valor { get; set; }

        public int TiendaId { get; set; }

        public string Imagen { get; set; }
    }
}
