﻿using AutoMapper;
using Common1.Dtos;
using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service1
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Category,CategoryDto>().ReverseMap();
            CreateMap<User,UserDto>().ReverseMap();
            CreateMap<Item,ItemDto>().ReverseMap();
        }
    }
}
