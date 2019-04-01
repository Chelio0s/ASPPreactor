using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
                var data = msSqlRepo.GetEntities<WorkHoursForOrgUnit>(x => x.DateWorkDay == this.date)
                    .GroupBy(x => x.code);
                int k = data.Count();
                ViewBag.koll = data.Count();

                //Цикл мальчика 
                //                  |
                //                  |
                //                  |
                //                  |
                //                  V

                //for (int i = 0; i < k; i++)
                //{
                //    if (info.Count() != 0)
                //    {
                //        for (int j = 0; j < info.Count(); j++)
                //        {
                //            if (info[j].Code == data[i].code && info[j].Shift != data[i].ShiftId)
                //            {
                //                if (info[j].S1FT != null)
                //                {
                //                    info[j].S2FT = data[i].StartWork.ToString("HH:mm") + "-" + data[i].EndWork.ToString("HH:mm");
                //                }
                //                else
                //                {
                //                    info[j].S1FT = data[i].StartWork.ToString("HH:mm") + "-" + data[i].EndWork.ToString("HH:mm");
                //                }
                //            }
                //        }
                //    }
                //    else
                //    {
                //        string S1 = null;
                //        string S2 = null;
                //        if (data[i].ShiftId == 1)
                //        {
                //            S1 = data[i].StartWork.ToString("HH:mm") + "-" + data[i].EndWork.ToString("HH:mm");
                //        }
                //        else
                //        {
                //            S2 = data[i].StartWork.ToString("HH:mm") + "-" + data[i].EndWork.ToString("HH:mm");
                //        }
                //        info.Add(new InfoWH
                //        {
                //            Code = data[i].code,
                //            Title = data[i].Title,
                //            Shift = data[i].ShiftId,
                //            S1FT = S1,
                //            S2FT = S2
                //        });
                //    }
                //}



                var info = new List<InfoWH>();

                //Цикл мужчины 
                //                  |
                //                  |
                //                  |
                //                  |
                //                  V

                foreach (var groups in data)
                {
                    var shift1 = groups.Where(x => x.ShiftId == 1).ToList();
                    var shift2 = groups.Where(x => x.ShiftId == 2).ToList();

                    var data1 = Formatdata(shift1, shift2);
                    if (data1!=null)
                    {
                        info.Add(data1);
                    }
                }

                return View(info.ToList());
            }

            return View();
        }

        private InfoWH Formatdata(List<WorkHoursForOrgUnit> shiftData1, List<WorkHoursForOrgUnit> shiftData2)
        {
            if (shiftData1.Count > 0)
            {
                var _infoWH = new InfoWH()
                {
                    Title = shiftData1.FirstOrDefault()?.Title,
                    Shift = shiftData1.FirstOrDefault().ShiftId,
                    Code = shiftData1.FirstOrDefault()?.code,
                    S1FT =
                        shiftData1.OrderBy(x => x.StartWork).FirstOrDefault()?.StartWork.ToShortTimeString() +
                        "-" +
                        shiftData1.OrderBy(x => x.StartWork).Last()?.EndWork.ToShortTimeString(),
                    S1break = shiftData1.OrderBy(x => x.StartWork).FirstOrDefault()?.EndWork.ToShortTimeString() +
                              "-" +
                              shiftData1.OrderBy(x => x.StartWork).Last()?.StartWork.ToShortTimeString()


                };
                if (shiftData2.Count > 0)
                {
                    _infoWH.S2FT =
                        shiftData2.OrderBy(x => x.StartWork).FirstOrDefault()?.StartWork.ToShortTimeString() +
                        "-" +
                        shiftData2.OrderBy(x => x.StartWork).Last()?.EndWork.ToShortTimeString();
                    _infoWH.S2break =
                        shiftData2.OrderBy(x => x.StartWork).FirstOrDefault()?.EndWork.ToShortTimeString() +
                        "-" +
                        shiftData2.OrderBy(x => x.StartWork).Last()?.StartWork.ToShortTimeString();
                }

                return _infoWH;
            }
            return null;
        }
    }
}
