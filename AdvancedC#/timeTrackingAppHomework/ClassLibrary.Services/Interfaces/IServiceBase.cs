using ClassLibrary.Domain;

namespace ClassLibrary.Services.Interfaces
{
    public interface IServiceBase<T> where T : BaseEntity
    {
        List<T> GetAll();
        void Insert(T entity);
        void Seed(List<T> entities);
    }
}
