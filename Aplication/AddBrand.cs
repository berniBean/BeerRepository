﻿
using Entities;

namespace App
{
    public class AddBrand
    {
        private readonly IRepository<Brand>? _repository;

        public AddBrand(IRepository<Brand>? repository)
        {
            _repository = repository;
        }


        public async Task ExecuteAsync(Brand brand)
        {
            if (string.IsNullOrWhiteSpace(brand.Name)) 
            {
                throw new Exception("El nombre de la marca es obligatorio");
            }

            await _repository!.AddAsync(brand);
        }
    }
}
