using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prueba.Trade.Application.Contracts.Services;
using PruebaTreda.Mappers;
using PruebaTreda.ViewModels;

namespace PruebaTreda.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService _productoService;
        public ProductoController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet("[action]")]
        [Produces("application/json", Type = typeof(ProductoModel))]
        public async Task<IActionResult> Get(string sku)
        {
            try
            {
                var producto = await _productoService.GetProducto(sku);
                return Ok(producto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("[action]")]
        [Produces("application/json", Type = typeof(List<ProductoModel>))]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var productos = await _productoService.GetAllProductos();
                return Ok(productos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("[action]")]
        [Produces("application/json", Type = typeof(List<ProductoModel>))]
        public async Task<IActionResult> GetAllProductosByTienda(int tiendaId)
        {
            try
            {
                var productos = await _productoService.GetAllProductosByTienda(tiendaId);
                return Ok(productos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Produces("application/json", Type = typeof(ProductoModel))]
        [HttpPost("[action]")]
        public async Task<IActionResult> AddProducto([FromBody]ProductoModel productoModel)
        {
            try
            {
                var producto = await _productoService.AddProducto(ProductoMapper.Map(productoModel));
                return Ok(producto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("[action]")]
        [Produces("application/json", Type = typeof(bool))]
        public async Task<IActionResult> DeleteProducto(string sku)
        {
            try
            {
                await _productoService.DeleteProducto(sku);
                return Ok("Registro eliminado correctamente");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("[action]")]
        [Produces("application/json", Type = typeof(ProductoModel))]
        public async Task<IActionResult> UpdateCliente([FromBody]ProductoModel clienteModel)
        {
            try
            {
                var cliente = await _productoService.UpdateProducto(ProductoMapper.Map(clienteModel));
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}