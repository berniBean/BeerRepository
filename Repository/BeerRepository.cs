using App;
using Data;
using Entities;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BeerRepository : IRepository<Beer>
    {

        private readonly AppDbContext _appDbContext;

        public BeerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task AddAsync(Beer entity)
        {
            var beerModel = new BeerModel()
            {
                Alcohol = entity.Alcohol,
                Name = entity.Name,
                BrandId = entity.BrandId,

            };

            await _appDbContext.AddAsync(beerModel);
            await _appDbContext.SaveChangesAsync();
        }



        public async Task EditAsync(Beer entity)
        {
            var Model = await _appDbContext.Beers!.FindAsync(entity.Id);

            Model!.Name = entity.Name;
            Model.BrandId = entity.BrandId;
            Model.Alcohol = entity.Alcohol;

            _appDbContext.Entry(Model).State = EntityState.Modified;

            await _appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Beer>> GetAllAsync()
            => await _appDbContext.Beers!.Select(b=> new Beer
            {
                Id = b.Id,
                Name = b.Name,
                Alcohol = b.Alcohol,
                BrandId= b.BrandId,
            }).ToListAsync();

        public async Task<Beer> GetByIdAsync(int id)
        {
            var beerModel = await _appDbContext.Beers!.FindAsync(id);

            return new Beer
            {
                Id = beerModel!.Id,
                Name = beerModel.Name,
                Alcohol = beerModel.Alcohol,
                BrandId = beerModel.BrandId,
            };
        }

        public async Task DeleteAsyn(int id)
        {
            var beerModel = await _appDbContext.Beers!.FindAsync(id);

            _appDbContext.Beers.Remove(beerModel!);
            await _appDbContext.SaveChangesAsync();

        }
    }
}
