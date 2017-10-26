using EHR.DAL.Data;
using EHR.DAL.Appointment.Entities;
using System;
using System.Linq;

namespace EHR.DAL.Appointment.Data
{
    public class AppointmentInitializer : DbInitializer<AppointmentContext>
    {
        public override void Initialize(AppointmentContext context)
        {
            base.Initialize(context);
        }
    }
}