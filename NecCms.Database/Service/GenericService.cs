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
        public GenericService(CrmContext dbContext)
        {
            this.DbContext = dbContext;
        }

        private CrmContext DbContext { get; }

        public IQueryable<T> Queryable<T>() where T : BaseEntity
        {
            return DbContext.Set<T>().Where(x => x.Sil == 0);
        }

        public async Task<bool> Remove<T>(T model) where T : BaseEntity
        {
            var dbmodel = await DbContext.Set<T>().FindAsync(model.Id);
            dbmodel.Sil = 1;

            DbContext.Set<T>().Update(dbmodel);

            await DbContext.SaveChangesAsync();

            return true;
        }

        public async Task<int> Save<T>(T model) where T : BaseEntity
        {
            if (model.Id == 0)
                await DbContext.Set<T>().AddAsync(model);
            else
                DbContext.Set<T>().Update(model);

            await DbContext.SaveChangesAsync();

            return model.Id;
        }
        public async Task<bool> Save<T>(List<T> model) where T : BaseEntity
        {
            if (model.Any(w => w.Id == 0))
                await DbContext.Set<T>().AddRangeAsync(model.Where(w => w.Id == 0).ToList());
            if (model.Any(w => w.Id != 0))
                DbContext.Set<T>().UpdateRange(model.Where(w => w.Id != 0).ToList());

            await DbContext.SaveChangesAsync();

            return true;
        }
    }
}