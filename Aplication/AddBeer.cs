using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class AddBeer
    {
        public readonly IRepository<Beer> _beeeRepository;

        public AddBeer(IRepository<Beer> beeeRepository)
        {
            _beeeRepository = beeeRepository;
        }

        public async Task ExecuteAsync(Beer beer)
        {
            if (string.IsNullOrEmpty(beer.Name))
            {
                throw new Exception("E nombre de la cerveza es obligatorio.");

            }

            await _beeeRepository.AddAsync(beer);
        }
    }
}
