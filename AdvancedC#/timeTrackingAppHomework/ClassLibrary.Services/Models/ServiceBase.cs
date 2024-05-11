using ClassLibrary.DataAccess.Interfaces;
using ClassLibrary.DataAccess.Models;
using ClassLibrary.Domain.DomainModels;
using ClassLibrary.Services.Interfaces;

namespace ClassLibrary.Services.Models
{
    public class ServiceBase<T> : IServiceBase<T> where T : BaseEntity
    {
        private IGenericDb<T> _db;
        public ServiceBase()
        {
            _db = new FileSystemDB<T>();
        }
        public List<T> GetAll()
        {
            return _db.GetAll();
        }

        public void Insert(T entity)
        {
            _db.Add(entity);
        }
        public void Seed(List<T> entities)
        {
            entities.ForEach(entity => _db.Add(entity));
        }
        public bool Update(T entity)
        {
            _db.Update(entity);
            return true;
        }

    }
}
