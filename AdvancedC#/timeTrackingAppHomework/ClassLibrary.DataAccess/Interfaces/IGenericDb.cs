using ClassLibrary.Domain.DomainModels;

namespace ClassLibrary.DataAccess.Interfaces
{
    public interface IGenericDb<T> where T : BaseEntity
    {
        int Add(T entity);
        List<T> GetAll();
        bool Update(T entity);
        T GetById(int id);

    }
}
