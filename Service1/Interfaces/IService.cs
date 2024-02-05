using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service1.Interfaces
{
    public interface IService<T> where T : class
    {
        public Task AddAsync(T service);
        public Task RemoveAsync(int id);
        public Task<T> GetAsync(int id);
        public Task<List<T>> GetAllAsync();
        public Task UpdateAsync(int id,T service);
        Task DeleteAsync(int id);
    }
}
