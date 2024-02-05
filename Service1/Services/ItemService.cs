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
    public class ItemService : IService<ItemDto>
    {
        private readonly IRepository<Item> _repository;
        private readonly IMapper _mapper;
        public ItemService(IRepository<Item>repository,IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
        }

        public async Task AddAsync(ItemDto service)
        {
            await _repository.AddAsync(_mapper.Map<Item>(service));
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ItemDto>> GetAllAsync()
        {
            return _mapper.Map<List<ItemDto>>(await _repository.GetAllAsync());
        }

        public async Task<ItemDto> GetAsync(int id)
        {
            return _mapper.Map<ItemDto>(await _repository.GetAsync(id));
        }

        public async Task RemoveAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task UpdateAsync(int id, ItemDto service)
        {
            await _repository.UpdateAsync(id,_mapper.Map<Item>(service));
        }
    }
}
