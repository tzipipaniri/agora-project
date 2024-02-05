﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class Category
    {
        [ForeignKey("CategoryId")]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}