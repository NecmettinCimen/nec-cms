using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NecCms.Database.Service
{
    public interface IGenericService
    {
        IQueryable<T> Queryable<T>() where T : BaseEntity;
        Task<int> Save<T>(T model) where T : BaseEntity;
        Task<bool> Save<T>(List<T> model) where T : BaseEntity;
        Task<bool> Remove<T>(T model) where T : BaseEntity;
    }

    public class GenericService : IGenericService
    {
        CrmContext dbContext = new CrmContext();
        public IQueryable<T> Queryable<T>() where T : BaseEntity
        {
            return dbContext.Set<T>().Where(x => x.Sil == 0);
        }

        public async Task<bool> Remove<T>(T model) where T : BaseEntity
        {
            var dbmodel = await dbContext.Set<T>().FindAsync(model.Id);
            dbmodel.Sil = 1;

            dbContext.Set<T>().Update(dbmodel);

            await dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<int> Save<T>(T model) where T : BaseEntity
        {
            if (model.Id == 0)
                await dbContext.Set<T>().AddAsync(model);
            else
                dbContext.Set<T>().Update(model);

            await dbContext.SaveChangesAsync();

            return model.Id;
        }
        public async Task<bool> Save<T>(List<T> model) where T : BaseEntity
        {
            if (model.Any(w => w.Id == 0))
                await dbContext.Set<T>().AddRangeAsync(model.Where(w => w.Id == 0).ToList());
            if (model.Any(w => w.Id != 0))
                dbContext.Set<T>().UpdateRange(model.Where(w => w.Id != 0).ToList());

            await dbContext.SaveChangesAsync();

            return true;
        }
    }
}