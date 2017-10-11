using EHR.DAL.Task.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EHR.DAL.Data;
using EHR.DAL.Task.Data;

namespace EHR.DAL.Task.Repositories
{
    public class TaskItemRepository : TaskRepository<TaskItem>
    {
        public TaskItemRepository(TaskContext context) : base(context)
        {
        }

        public IEnumerable<TaskItem> GetAllByAssignedToUserId(int assignedToUserId)
        {
            var results = from ti in Context.TaskItems
                          where ti.AssignedToUser.Id == assignedToUserId
                          select ti;

            return results;
        }
        public IEnumerable<TaskItem> GetAllByTaskItemGroupId(int taskItemGroupId)
        {
            var results = from ti in Context.TaskItems
                          where ti.TaskItemGroup.Id == taskItemGroupId
                          select ti;

            return results;
        }
    }
}
