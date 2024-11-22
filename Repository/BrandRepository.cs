using App;
using Data;
using Entities;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Repository
{
    public class BrandRepository : IRepository<Brand>
    {

        public readonly AppDbContext _dbContext;

        public BrandRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Brand entity)
        {
            var brandModel = new BrandModel()
            {
                Name = entity.Name
            };

            await _dbContext.AddAsync(brandModel);
            await _dbContext.SaveChangesAsync();
        }



        public async Task<IEnumerable<Brand>> GetAllAsync()
            => await _dbContext.Brands!.Select(b => new Brand { Id= b.Id, Name = b.Name }).ToListAsync();

        public async Task<Brand> GetByIdAsync(int id)
        {
            var brandModel = await _dbContext.Brands!.FindAsync(id);


            return new Brand { Id = brandModel!.Id, Name = brandModel.Name};
        }

        public async Task EditAsync(Brand entity)
        {
            var model = await _dbContext.Brands!.FindAsync(entity.Id);

            model!.Name = entity.Name;

            _dbContext.Entry(model).State = EntityState.Modified;

            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsyn(int id)
        {
            var model = await _dbContext.Brands!.FindAsync(id);

            _dbContext.Brands.Remove(model!);

            await _dbContext.SaveChangesAsync();
        }

    }
}
