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
            if (date != null)
            {
                this.date = DateTime.ParseExact(date, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None);
                var data = msSqlRepo.GetEntities<WorkHoursForOrgUnit>(x => x.DateWorkDay == this.date);
                int k = data.Count();
                ViewBag.koll = data.Count();

                //лучший цикл этой планеты
                var info = new List<InfoWH>();
                for (int i = 0; i < k; i++)
                {
                    if (info.Count() != 0)
                    {
                        for (int j = 0; j < info.Count(); j++)
                        {
                            if(info[j].Code == data[i].code && info[j].Shift != data[i].ShiftId)
                            {
                                if(info[j].S1FT != null)
                                {
                                    info[j].S2FT = data[i].StartWork.ToString("HH:mm") + "-" + data[i].EndWork.ToString("HH:mm");
                                }
                                else
                                {
                                    info[j].S1FT = data[i].StartWork.ToString("HH:mm") + "-" + data[i].EndWork.ToString("HH:mm");
                                }
                            }
                        }
                    }
                    else
                    {
                        string S1 = null;
                        string S2 = null;
                        if (data[i].ShiftId == 1)
                        {
                            S1 = data[i].StartWork.ToString("HH:mm") + "-" + data[i].EndWork.ToString("HH:mm");
                        }
                        else
                        {
                            S2 = data[i].StartWork.ToString("HH:mm") + "-" + data[i].EndWork.ToString("HH:mm");
                        }
                        info.Add(new InfoWH {
                            Code = data[i].code,
                            Title = data[i].Title,
                            Shift = data[i].ShiftId,
                            S1FT = S1,
                            S2FT = S2
                        });                       
                    }
                }
                return View(info.ToList());
            }                

            return View();
        }
    }
}