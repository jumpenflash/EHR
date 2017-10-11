using EHR.DAL.Data;
using EHR.DAL.Entities.Base;
using EHR.DAL.Repositories;
using EHR.DAL.Task.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHR.DAL.Task.Repositories
{
    public class TaskRepository<T> : Repository<T, TaskContext> where T : UniqueEntity
    {
        public TaskRepository(TaskContext context) : base(context)
        {
        }
    }
}
