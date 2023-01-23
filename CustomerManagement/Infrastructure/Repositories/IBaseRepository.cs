namespace CustomerManagement.Infrastructure.Repositories
{
    public interface IBaseRepository<T>
    {
        T Read();
        void Write(T data);
    }
}
