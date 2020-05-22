using Prueba.Trade.Application.Contracts.Services;
using Prueba.Trade.Business.Models;
using Prueba.Trade.DataAccess.Contracts.Repositories;
using Prueba.Trade.DataAccess.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Trade.Application.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoService(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public async Task<string> GetNombreProducto(string sku)
        {
            var entidad = await _productoRepository.Get(sku);
            return entidad.Nombre;
        }

        public async Task<IEnumerable<Producto>> GetAllProductosByTienda(int tiendaId)
        {
            var productos = await _productoRepository.GetAllProductosByTienda(tiendaId);
            return productos.Select(ProductoMapper.Map);
        }

        public async Task<Producto> AddProducto(Producto producto)
        {
            var addedEntity = await _productoRepository.Add(ProductoMapper.Map(producto));
            return ProductoMapper.Map(addedEntity);
        }

        public async Task<IEnumerable<Producto>> GetAllProductos()
        {
            var productos = await _productoRepository.GetAll();
            return productos.Select(ProductoMapper.Map);
        }

        public async Task<Producto> GetProducto(string sku)
        {
            var entidad = await _productoRepository.Get(sku);

            return ProductoMapper.Map(entidad);
        }

        public async Task DeleteProducto(string sku)
        {
            await _productoRepository.DeleteAsync(sku);
        }

        public async Task<Producto> UpdateProducto(Producto producto)
        {
            var updated = await _productoRepository.Update(ProductoMapper.Map(producto));
            return ProductoMapper.Map(updated);
        }
    }
}
