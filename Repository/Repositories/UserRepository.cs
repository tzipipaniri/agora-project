using Microsoft.EntityFrameworkCore;
using Repository.Entity;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly IContext _context;
        public UserRepository(IContext context)
        {
            this._context = context;
        }

        public async Task AddAsync(User item)
        {
            await _context.Users.AddAsync(item);
            await _context.save();
        }

        public async Task DeleteAsync(int id)
        {
            _context.Users.Remove(await GetAsync(id));
            await _context.save();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetAsync(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(int id, User item)
        {
        var user=await _context.Users.FirstOrDefaultAsync(x=>x.Id == id);
            user.FirstName=item.FirstName;
            user.LastName=item.LastName;
            user.Email=item.Email;
            user.Phone=item.Phone;
            user.City=item.City;
            user.Street=item.Street;
            user.NumHouse=item.NumHouse;
            _context.save();
    }
    }
}
