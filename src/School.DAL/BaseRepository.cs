using School.Abstractions.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DAL
{
    public class BaseRepository<T> : IRepositoryBase<T> where T : class
    {

        public async Task<T> AddItemAsync(T item)
        {
            using (var context = new StudentContext())
            {
                context.Set<T>().Add(item);

                await context.SaveChangesAsync();

                return await Task.FromResult(item);

            };
        }

        public Task<T> GetItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetItemsAsync()
        {
            using (var context = new StudentContext())
            {
                var result = context.Set<T>().ToList();
                return await Task.FromResult(result);
            }
        }

        public Task<T> UpdateItemAsync(T item)
        {
            throw new NotImplementedException();
        }
    }
}
