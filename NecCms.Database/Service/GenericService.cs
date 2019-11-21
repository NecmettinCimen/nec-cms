using System.Linq;

namespace NecCms.Database.Service
{
    public interface IGenericService
    {
        IQueryable<T> IQueryable<T>() where T : BaseEntity;
        int Save<T>(T model) where T : BaseEntity;
        bool Remove<T>(T model) where T : BaseEntity;
    }

    public class GenericService : IGenericService
    {
        private readonly CrmContext db = new CrmContext();

        public IQueryable<T> IQueryable<T>() where T : BaseEntity
        {
            return db.Set<T>().Where(x => !x.Sil);
        }

        public bool Remove<T>(T model) where T : BaseEntity
        {
            var dbmodel = db.Set<T>().Find(model.Id);
            dbmodel.Sil = true;

            db.Set<T>().Update(dbmodel);

            db.SaveChanges();

            return true;
        }

        public int Save<T>(T model) where T : BaseEntity
        {
            if (model.Id == 0)
                db.Set<T>().Add(model);
            else
                db.Set<T>().Update(model);

            db.SaveChanges();

            return model.Id;
        }
    }
}