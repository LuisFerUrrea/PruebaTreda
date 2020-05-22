using Prueba.Trade.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Trade.Application.Contracts.Services
{
    public interface IProductoService
    {
        Task<string> GetNombreProducto(string sku);
        Task<IEnumerable<Producto>> GetAllProductosByTienda(int tiendaId);
        Task<Producto> AddProducto(Producto producto);
        Task<IEnumerable<Producto>> GetAllProductos();
        Task<Producto> GetProducto(string sku);
        Task DeleteProducto(string sku);
        Task<Producto> UpdateProducto(Producto producto);  
    }
}
