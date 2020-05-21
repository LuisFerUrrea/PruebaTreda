using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.Trade.DataAccess.Contracts.Entities
{
    public class TiendaEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaApertura { get; set; }

        public virtual IEnumerable<ProductoEntity> Productos { get; set; }
    }
}
