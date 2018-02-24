using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Abstractions.Repositories
{
   public interface IRepositoryBase<T> where T : class
    {
        Task<T> AddItemAsync(T item);
        Task<T> UpdateItemAsync(T item);
        Task<T> GetItemAsync(int id);
        Task<IEnumerable<T>> GetItemsAsync();
    }
}
