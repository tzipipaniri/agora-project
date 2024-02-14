using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; } 
        public string? LastName { get; set; } 
        public string? Email { get; set; } 
        public string? Phone { get; set; }
        public string? City { get; set; } 
        public string? Street { get; set; } 
        public int NumHouse { get; set; }
         public virtual ICollection<Item> items { get; set; }
    }
}