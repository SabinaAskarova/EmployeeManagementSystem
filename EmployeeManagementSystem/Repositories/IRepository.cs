using EmployeeManagementSystem.Entitiy;

namespace EmployeeManagementSystem.IRepositories
{
    public interface IRepository<T> where T : EntityBase
    {
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
        IEnumerable<T> GetAll { get; }
    }
}
