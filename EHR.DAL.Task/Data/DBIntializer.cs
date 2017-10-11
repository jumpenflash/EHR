using EHR.DAL.Data;
using EHR.DAL.Task.Entities;
using System;
using System.Linq;

namespace EHR.DAL.Task.Data
{
    public class TaskInitializer : DbInitializer<TaskContext>
    {
        public override void Initialize(TaskContext context)
        {
            base.Initialize(context);
        }
    }
}