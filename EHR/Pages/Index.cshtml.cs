using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EHR.DAL.Entities;
using EHR.BLL.UnitOfWork;
using EHR.DAL.Repositories;
using EHR.DAL.Repositories.Interfaces;

namespace EHR.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}
