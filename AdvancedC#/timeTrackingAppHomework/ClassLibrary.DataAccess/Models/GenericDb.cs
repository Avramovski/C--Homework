

using ClassLibrary.DataAccess.Interfaces;
using ClassLibrary.Domain;

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
        private int GenerateUniqueId()
        {

            IdCounter++;

            return IdCounter;
        }

        public int Add(T entity)
        {

            entity.Id = GenerateUniqueId();

            _db.Add(entity);

            return entity.Id;
        }

        public List<T> GetAll()
        {
            return _db;
        }
    }
}
