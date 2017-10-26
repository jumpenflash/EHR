using EHR.DAL.Appointment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EHR.DAL.Data;
using EHR.DAL.Appointment.Data;

namespace EHR.DAL.Appointment.Repositories
{
    public class PostRepository : AppointmentRepository<VisitGroup>
    {
        public PostRepository(AppointmentContext context) : base(context)
        {
        }

        public IEnumerable<VisitGroup> GetAllByAssignedToUserId(int assignedToUserId)
        {
            var results = from ti in Context.Posts
                          where ti.AssignedToUser.Id == assignedToUserId
                          select ti;

            return results;
        }
        public IEnumerable<VisitGroup> GetAllByPostGroupId(int PostGroupId)
        {
            var results = from ti in Context.Posts
                          where ti.PostGroup.Id == PostGroupId
                          select ti;

            return results;
        }
    }
}
