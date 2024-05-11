namespace ClassLibrary.Domain.DomainModels
{
    public abstract class BaseEntity
    {

        public int Id { get; set; }
        public abstract string GetInfo();
    }
}
