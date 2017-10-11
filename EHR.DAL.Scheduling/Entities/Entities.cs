using EHR.DAL.Entities;
using EHR.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHR.DAL.Scheduling.Entities
{
    public class Event : ManagedEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool AllDay { get; set; }

        public User OwnerUser { get; set; }
        public EventType EventType { get; set; }

        public ICollection<Attendee> Attendees { get; set; }
    }

    public class EventType : TypeEntity
    {
        public ICollection<Event> Events { get; set; }
    }

    public class Attendee : ManagedEntity
    {
        public User User { get; set; }
        public Event Event { get; set; }

        public ICollection<AttendeeStatusHistory> AttendeeStatusHistory { get; set; }
    }

    public class AttendeeStatusHistory : HistoricalEntity
    {
        public Attendee Attendee { get; set; }
        public AttendeeStatusType AttendeeStatusType { get; set; }
    }

    public class AttendeeStatusType : TypeEntity
    {
    }
}
