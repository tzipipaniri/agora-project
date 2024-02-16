//using Common1.Dtos;
using Microsoft.AspNetCore.Mvc;
using Service1.Interfaces;
using Microsoft.AspNetCore.Http;
using Common1.Dtos;

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

        [HttpGet("getImage/{ImageUrl}")]
        public string GetImage(string ImageUrl)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "images/", ImageUrl);
            byte[] bytes = System.IO.File.ReadAllBytes(path);
            string imageBase64 = Convert.ToBase64String(bytes);
            string image = string.Format("data:image/jpeg;base64,{0}", imageBase64);
            return image;
        }

        // POST api/<ItemController>
        [HttpPost]
        public async Task Post([FromForm] ItemDto value)
        {
            //  await this.service.AddAsync(value);
            // return Ok(await service.AddAsync(value));
            var myPath = Path.Combine(Environment.CurrentDirectory + "/images/" + value.FileImage.FileName);
            using (FileStream fs = new FileStream(myPath, FileMode.Create))
            {
                value.FileImage.CopyTo(fs);
                fs.Close();
            }

            value.Image = value.FileImage.FileName;
            await service.AddAsync(value);
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
