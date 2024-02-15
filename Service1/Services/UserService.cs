using AutoMapper;
using Common1.Dtos;
using Repository.Entity;
using Repository.Interface;
using Service1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service1.Services
{
    internal class UserService : IService<UserDto>
    {
        private readonly IRepository<User> _repository;
        private readonly IMapper mapper;
        public UserService(IRepository<User>repository,IMapper mapper)
        {
            this._repository = repository;
            this.mapper = mapper;
        }

        public async Task<UserDto> AddAsync(UserDto service)
        {
              // await _repository.AddAsync(mapper.Map<User>(service));
              return mapper.Map<UserDto>(await _repository.AddAsync(mapper.Map<User>(service)));
        }

        public async Task DeleteAsync(int id)
        {
                await _repository.DeleteAsync(id);
        }

        public async Task<List<UserDto>> GetAllAsync()
        {
               return mapper.Map<List<UserDto>>(await _repository.GetAllAsync());
        }

        public async Task<UserDto> GetAsync(int id)
        {
             return mapper.Map<UserDto>(await _repository.GetAsync(id));
        }

        public async Task UpdateAsync(int id, UserDto service)
        {
               _repository.UpdateAsync(id,mapper.Map<User>(service));
        }

    }
}
