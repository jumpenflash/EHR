using EHR.DAL.Data;
using EHR.DAL.HelpDesk.Entities;
using System;
using System.Linq;

namespace EHR.DAL.HelpDesk.Data
{
    public class HelpDeskInitializer : DbInitializer<HelpDeskContext>
    {
        public override void Initialize(HelpDeskContext context)
        {
            base.Initialize(context);
        }
    }
}