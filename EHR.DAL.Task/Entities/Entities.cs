using EHR.DAL.Entities;
using EHR.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHR.DAL.Task.Entities
{
    public class TaskItem : ManagedEntity
    {
        public string Task { get; set; }
        public DateTime? CompletedDate { get; set; }

        public User AssignedToUser { get; set; }
        public TaskItem ParentTaskItem { get; set; }
        public TaskItemGroup TaskItemGroup { get; set; }

        public ICollection<TaskItemNote> Notes { get; set; }
    }

    public class TaskItemNote : ManagedEntity
    {
        public string Note { get; set; }

        public TaskItem TaskItem { get; set; }
    }

    public class TaskItemGroup : ManagedEntity
    {
        public string Name { get; set; }

        public ICollection<TaskItem> TaskItem { get; set; }
    }
}
