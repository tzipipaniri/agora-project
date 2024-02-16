using Microsoft.EntityFrameworkCore;
using Repository.Entity;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        public async Task<Item> AddAsync(Item item)
        {
            //await context.Items.AddAsync(item);
            // await context.save();
            Item i = item;
            await this.context.Items.AddAsync(i);
            await this.context.save();
            return i;
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
        //    private string image;
        //public int Id { get; set; }
        //public string? Name { get; set; }
        //// public string? Image { get; set; }
        //public string Image { get => image; set => image = value; }

        //public int? UserId { get; set; }
        //[ForeignKey("UserId")]
        //public virtual User user { get; set; }
        //public int? CategoryId { get; set; }
        //[ForeignKey("CategoryId")]
        //public virtual Category category { get; set; }
        //public State state { get; set; }
        //public DateTime DateDelivery { get; set; }



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
