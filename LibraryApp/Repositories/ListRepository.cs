﻿namespace LibraryApp.Repositories
{
    using LibraryApp.Entities;
    using System.Collections.Generic;

    public class ListRepository<T>: IRepository<T> where T : class, IEntity, new()
    {
        
        private readonly List<T> _items = new();
     
        public void Add(T item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }
        public void Save()
        {
       
        }
        public T GetById(int id)
        {
             return _items.Single(item => item.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _items.ToList();
        }
    }
}


