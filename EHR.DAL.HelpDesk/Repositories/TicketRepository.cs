using EHR.DAL.HelpDesk.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EHR.DAL.Data;
using EHR.DAL.HelpDesk.Data;

namespace EHR.DAL.HelpDesk.Repositories
{
    public class TicketRepository : HelpDeskRepository<Ticket>
    {
        public TicketRepository(HelpDeskContext context) : base(context)
        {
        }

        public IEnumerable<Ticket> GetAllByAssignedToUserId(int assignedToUserId)
        {
            var results = from ti in Context.Tickets
                          where ti.AssignedToUser.Id == assignedToUserId
                          select ti;

            return results;
        }
        public IEnumerable<Ticket> GetAllByTicketGroupId(int TicketGroupId)
        {
            var results = from ti in Context.Tickets
                          where ti.TicketGroup.Id == TicketGroupId
                          select ti;

            return results;
        }
    }
}
