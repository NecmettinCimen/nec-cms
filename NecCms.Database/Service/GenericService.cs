using System.Linq;

namespace NecCms.Database.Service
{
    public interface IGenericService
    {
        IQueryable<T> Queryable<T>() where T : BaseEntity;
        int Save<T>(T model) where T : BaseEntity;
        bool Remove<T>(T model) where T : BaseEntity;
    }

    public class GenericService : IGenericService
    {
        CrmContext dbContext = new CrmContext();
        public IQueryable<T> Queryable<T>() where T : BaseEntity
        {
            return dbContext.Set<T>().Where(x => x.Sil == 0);
        }

        public bool Remove<T>(T model) where T : BaseEntity
        {
            var dbmodel = dbContext.Set<T>().Find(model.Id);
            dbmodel.Sil = 1;

            dbContext.Set<T>().Update(dbmodel);

            dbContext.SaveChanges();

            return true;
        }

        public int Save<T>(T model) where T : BaseEntity
        {
            if (model.Id == 0)
                dbContext.Set<T>().Add(model);
            else
                dbContext.Set<T>().Update(model);

            dbContext.SaveChanges();

            return model.Id;
        }
    }
}