
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Entity;
using Microsoft.AspNetCore.Http;

namespace Common1.Dtos
{
    public class ItemDto
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public int? UserId { get; set; }
        public int? CategoryId { get; set; }
        public State state { get; set; }
        public DateTime DateDelivery { get; set; }
        // public List<IFormFile> MyProperty { get; set; }
        public IFormFile FileImage { get; set; }
        public string? Image { get; set; }

    }
}
