

namespace LibraryApp.Repositories
{
    using LibraryApp.Entities;
    public interface IWriteRepository<in T> where T: class, IEntity
    {
        void Add(T item);
        void Remove(T item);
        void Save();
    }
}
