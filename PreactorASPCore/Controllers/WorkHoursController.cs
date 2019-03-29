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
        DateTime date = new DateTime();
        MSSqlRepository msSqlRepo = new MSSqlRepository();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string date)
        {
            if (date == null)
                return View();
            if(date != null)
            {
                this.date = DateTime.ParseExact(date, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None);
                var data = msSqlRepo.GetEntities<WorkHoursForOrgUnit>(x => x.DateWorkDay == this.date);
                ViewBag.koll = data.Count();
                return View(data.ToList());
            }                

            return View();
        }

        //public IActionResult WorkHours()
        //{            
        //    var dat = msSqlRepo.GetEntities<WorkHoursForOrgUnit>();
        //    ViewBag.koll = dat.Count();
        //    return View(dat.ToList().Take(10));
        //}
    }
}