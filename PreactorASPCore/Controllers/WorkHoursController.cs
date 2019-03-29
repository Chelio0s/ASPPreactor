using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PreactorASPCore.Models;
using PreactorASPCore.Models.PreactorData;

namespace PreactorASPCore.Controllers
{
    public class WorkHoursController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WorkHours()
        {
            MSSqlRepository msSqlRepo = new MSSqlRepository();
            var dat = msSqlRepo.GetEntities<WorkHoursForOrgUnit>();
            ViewBag.koll = dat.Count();
            return View(dat.ToList());
        }
    }
}