using EHR.DAL.Data;
using EHR.DAL.Entities.Base;
using EHR.DAL.Repositories;
using EHR.DAL.Appointment.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHR.DAL.Appointment.Repositories
{
    public class AppointmentRepository<T> : Repository<T, AppointmentContext> where T : UniqueEntity
    {
        public AppointmentRepository(AppointmentContext context) : base(context)
        {
        }
    }
}
