
using Entities;

namespace App
{
    public class EditBeer
    {
        private readonly IRepository<Beer>? _beerRepository;

        public EditBeer(IRepository<Beer>? beerRepository)
        {
            _beerRepository = beerRepository;
        }

        public async Task ExecuteAsync(Beer beer)
        {
            if (string.IsNullOrEmpty(beer.Name))
            {
                throw new Exception("El nombre de la cerveza es obligatorio.");
            }

            if (await _beerRepository!.GetByIdAsync(beer.Id) == null) 
            {
                throw new Exception("La cerveza no existe");
            
            }

            await _beerRepository.EditAsync(beer);
        }
    }
}
