using Prueba.Trade.DataAccess.Contracts;
using Prueba.Trade.DataAccess.Contracts.Entities;
using Prueba.Trade.DataAccess.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Trade.DataAccess.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly IPruebaTredaDBContext _pruebaTredaDBContext;

        public ProductoRepository(IPruebaTredaDBContext pruebaTredaDBContext)
        {
            _pruebaTredaDBContext = pruebaTredaDBContext;
        }

        public async Task<ProductoEntity> Update(string sku, ProductoEntity updateEnt)
        {
            var entity = await Get(sku);
            entity.Nombre = updateEnt.Nombre;
            entity.Descripcion = updateEnt.Descripcion;
            entity.Valor = updateEnt.Valor;
            entity.TiendaId = updateEnt.TiendaId;
            entity.Imagen = updateEnt.Imagen;
            _pruebaTredaDBContext.Productos.Update(entity);
            await _pruebaTredaDBContext.SaveChangesAsync();
            return entity;
        }

        public async Task<ProductoEntity> Update(ProductoEntity entity)
        {
            var updateEntity = _pruebaTredaDBContext.Productos.Update(entity);
            await _pruebaTredaDBContext.SaveChangesAsync();
            return updateEntity.Entity;
        }

        public async Task<ProductoEntity> Add(ProductoEntity entity)
        {          
            await _pruebaTredaDBContext.Productos.AddAsync(entity);
            await _pruebaTredaDBContext.SaveChangesAsync();
            return entity;
        }

        public async Task<ProductoEntity> Get(string sku)
        {
            var result = await _pruebaTredaDBContext.Productos.FindAsync(sku);
            return result;
        }

        public async Task<IEnumerable<ProductoEntity>> GetAllProductosByTienda(int tiendaId)
        {
            var result = _pruebaTredaDBContext.Productos.Where(x => x.TiendaId==tiendaId).ToList();
            return result;

        }



        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductoEntity>> GetAll()
        {
            return _pruebaTredaDBContext.Productos.Select(x => x);
        }

        public async Task DeleteAsync(string sku)
        {
            var entity = await _pruebaTredaDBContext.Productos.FindAsync(sku);
            _pruebaTredaDBContext.Productos.Remove(entity);
            await _pruebaTredaDBContext.SaveChangesAsync();
        }

    }
}
