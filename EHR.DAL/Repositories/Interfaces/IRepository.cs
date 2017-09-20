using EHR.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EHR.DAL.Repositories.Interfaces
{
    public interface IRepository<T> where T : UniqueEntity
    {
        void Add(T obj);
        void AddRange(IEnumerable<T> entities);

        void Update(T obj);
        void UpdateRange(IEnumerable<T> entities);

        void Remove(T obj);
        void RemoveRange(IEnumerable<T> entities);

        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
    }
}