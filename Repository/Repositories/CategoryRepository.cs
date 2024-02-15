using Microsoft.EntityFrameworkCore;
using Repository.Entity;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private readonly IContext _context;
        public CategoryRepository(IContext context)
        {
            this._context = context;
        }

        public async Task<Category> AddAsync(Category item)
        {
            //await this._context.Categories.AddAsync(item);
            //await _context.save();
            Category c = item;
            this._context.Categories.Add(c);
            await this._context.save();
            return c;
        }

        public async Task DeleteAsync(int id)
        {
            this._context.Categories.Remove(await GetAsync(id));
            await _context.save();
        }

        public async Task<List<Category>> GetAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetAsync(int id)
        {
            return await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(int id, Category item)
        {
           var category= await this._context.Categories.FirstOrDefaultAsync(x=>x.Id == id);
            category.Name=item.Name;
            this._context.save();
        }
    }
}
