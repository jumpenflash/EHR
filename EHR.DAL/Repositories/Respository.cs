﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using EHR.DAL.Repositories.Interfaces;
using EHR.DAL.Entities;

namespace EHR.DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : UniqueEntity
    {
        protected DbContext Context { get; set; }

        public Repository(DbContext context)
        {
            Context = context;
        }

        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
        }
        public void AddRange(IEnumerable<T> entities)
        {
            Context.Set<T>().AddRange(entities);
        }

        public void Update(T entity)
        {
            Context.Set<T>().Update(entity);
        }
        public void UpdateRange(IEnumerable<T> entities)
        {
            Context.Set<T>().UpdateRange(entities);
        }

        public void Remove(T entity)
        {
            Context.Set<T>().Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            Context.Set<T>().RemoveRange(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().Where(predicate);
        }

        public T Get(int id)
        {
            return Context.Set<T>().Find(id);
        }
        public IEnumerable<T> GetAll()
        {
            return Context.Set<T>().ToList();
        }
    }
}
