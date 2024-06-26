﻿namespace LibraryApp.Repositories
{
    using LibraryApp.Entities;
    public interface IRepository<T> : IReadRepository<T> , IWriteRepository<T> where T : class, IEntity
    {
    }
}
