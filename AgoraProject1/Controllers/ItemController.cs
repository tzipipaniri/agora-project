using Common1.Dtos;
using Microsoft.AspNetCore.Mvc;
using Service1.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AgoraProject1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IService<ItemDto> service;
        public ItemController(IService<ItemDto>service)
        {
            this.service = service;
        }
        // GET: api/<ItemController>
        [HttpGet]
        public async Task<List<ItemDto>> Get()
        {
            return await service.GetAllAsync();
        }

        // GET api/<ItemController>/5
        [HttpGet("{id}")]
        public async Task<ItemDto> Get(int id)
        {
            return await this.service.GetAsync(id);
        }

        // POST api/<ItemController>
        [HttpPost]
        public async Task Post([FromBody] ItemDto value)
        {
            await this.service.AddAsync(value);
        }

        // PUT api/<ItemController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] ItemDto value)
        {
            await service.UpdateAsync(id, value);
        }

        // DELETE api/<ItemController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await service.DeleteAsync(id);
        }
    }
}
