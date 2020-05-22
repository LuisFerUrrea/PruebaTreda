using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Trade.DataAccess.Contracts.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<bool> Exist(int id);

        Task<IEnumerable<T>> GetAll();

        Task<T> Get(string sku);

        Task DeleteAsync(string sku);

        Task<T> Update(string sku, T element);

        Task<T> Add(T element);

    }
}
