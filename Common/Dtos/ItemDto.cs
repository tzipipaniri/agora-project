﻿using Repository.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class ItemDto
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        //public DateTime DateDelivery { get; set; }
        public situation Situation { get; set; }
        public DateTime DateDelivery { get; set; }
    }
}
