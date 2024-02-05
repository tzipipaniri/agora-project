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
        [ForeignKey("UserId")]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        [Required]
        public string? Phone { get; set; }
        //public string Password { get; set; } = string.Empty;
        [Required]
        public string City { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public int NumHouse { get; set; }
        // public bool IsGive { get; set; }
         public virtual ICollection<Item> items { get; set; }
    }
}