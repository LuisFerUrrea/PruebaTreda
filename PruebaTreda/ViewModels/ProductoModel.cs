using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTreda.ViewModels
{
    public class ProductoModel
    {
        public string Sku { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public decimal Valor { get; set; }

        public int TiendaId { get; set; }

        public string Imagen { get; set; }
    }
}
