

using ClassLibrary.Domain;

namespace ClassLibrary.DataAccess.Interfaces
{
    public interface IGenericDb<T> where T : BaseEntity
    {
        int Add(T entity);
        List<T> GetAll();
    }
}
