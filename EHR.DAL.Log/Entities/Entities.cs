using EHR.DAL.Entities;
using EHR.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHR.DAL.Log.Entities
{
    public class Event : ManagedEntity
    {
        public string Source { get; set; }
        public string Message { get; set; }

        public EventType EventType { get; set; }

        public ICollection<EventAttribute> EventAttributes { get; set; }
    }

    public class EventType : TypeEntity
    {
        public ICollection<Event> Events { get; set; }
    }

    public class EventAttribute : ManagedEntity
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public Event Event { get; set; }
    }
}
