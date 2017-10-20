using EHR.DAL.Entities;
using EHR.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHR.DAL.HelpDesk.Entities
{
    public class Ticket : ManagedEntity
    {
        //What / Problem
        public string Title { get; set; }
        public string Body { get; set; }
        //Attachments  

        public TicketGroup TicketGroup { get; set; }
        public User AssignedToUser { get; set; }

        //Who
        public User ContactUser { get; set; }
        
        //Why / Cause
        //How / Resolution
        //Where / Enviroments
        //When

        public ICollection<TicketNote> Notes { get; set; }
        public ICollection<TicketStatusHistory> TicketStatusHistory { get; set; }
    }

    public class TicketStatusType : TypeEntity
    {
    }

    public class TicketStatusHistory : HistoricalEntity
    {
        public Ticket Ticket { get; set; }
        public TicketStatusType TicketStatusType { get; set; }
    }

    public class TicketNote : ManagedEntity
    {
        public string Note { get; set; }

        public Ticket Ticket { get; set; }
    }

    public class TicketGroup : ManagedEntity
    {
        public Ticket PrimaryTicket { get; set; }

        public ICollection<Ticket> Ticket { get; set; }
    }

    public class Environment : ManagedEntity
    {

    }
}
