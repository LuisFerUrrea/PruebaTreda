using Prueba.Trade.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Trade.DataAccess.Contracts.Repositories
{
    public interface IProductoRepository : IRepository<ProductoEntity>
    {
        Task<ProductoEntity> Update(ProductoEntity entity);
        Task<IEnumerable<ProductoEntity>> GetAllProductosByTienda(int tiendaId);
    }
}
