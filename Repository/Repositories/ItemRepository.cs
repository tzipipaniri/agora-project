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
    public class ItemRepository : IRepository<Item>
    {
        private readonly IContext context;
        public ItemRepository(IContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(Item item)
        {
           await context.Items.AddAsync(item);
            await context.save();
        }

        public async Task DeleteAsync(int id)
        {
            context.Items.Remove(await GetAsync(id));
            await context.save();
        }

        public async Task<List<Item>> GetAllAsync()
        {
            return await context.Items.ToListAsync();
        }

        public async Task<Item> GetAsync(int id)
        {
            return await context.Items.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(int id, Item item)
        {

        var item1= await context.Items.FirstOrDefaultAsync(x=>x.Id == id);
            item1.Name=item.Name;
            if(item1.Image!=null)
            item1.Image=item.Image;
            if(item.UserId!=null) 
            item1.UserId=item.UserId;
            if(item1.CategoryId!=0)
            item1.CategoryId=item.CategoryId;
            item1.state=item.state;
            item1.DateDelivery = item.DateDelivery;
            context.save();
        }
    }
}
