

using ClassLibrary.DataAccess.Interfaces;
using ClassLibrary.Domain.DomainModels;

namespace ClassLibrary.DataAccess.Models
{
    public class GenericDb<T> : IGenericDb<T> where T : BaseEntity
    {
        public int IdCounter { get; set; }
        private List<T> _db;

        public GenericDb()
        {
            _db = new List<T>();
            IdCounter = 1;
        }
        

        public int Add(T entity)
        {
            entity.Id = IdCounter++;
            _db.Add(entity);

            return entity.Id;
        }

        public List<T> GetAll()
        {
            return _db;
        }
        public T GetById(int id)
        {
            //_db.SingleOrDefault(x => x.Id == id);
            return _db.FirstOrDefault(x => x.Id == id);
        }
        public bool Update(T entity)
        {
            try
            {
                T dbEntity = GetById(entity.Id);
                dbEntity = entity;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
