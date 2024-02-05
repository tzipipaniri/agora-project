using Common1.Dtos;
using Microsoft.AspNetCore.Mvc;
using Service1.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AgoraProject1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IService<UserDto> service;
        public UserController(IService<UserDto> service)
        {
            this.service = service;
        }
        // GET: api/<UserController>
        [HttpGet]
        public async Task<List<UserDto>> Get()
        {
            return await service.GetAllAsync();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<UserDto> Get(int id)
        {
            return await service.GetAsync(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task Post([FromBody] UserDto user)
        {
            await service.AddAsync(user);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] UserDto user)
        {
            await service.UpdateAsync(id, user);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            service.DeleteAsync(id);
        }
    }
}
