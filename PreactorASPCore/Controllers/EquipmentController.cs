using System.Drawing;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PreactorASPCore.Models.OracleData;
using PreactorASPCore.Models.OracleData.Entity;

namespace PreactorASPCore.Controllers
{
    public class EquipmentController : Controller
    {
        string[] Colors =
        {
            Color.AntiqueWhite.Name.ToLower(), Color.Aqua.Name.ToLower(), Color.CadetBlue.Name.ToLower(), Color.DarkKhaki.Name.ToLower(),
            Color.Crimson.Name.ToLower(),
            Color.GreenYellow.Name.ToLower(), Color.LightSteelBlue.Name.ToLower(), Color.Navy.Name.ToLower(), Color.PapayaWhip.Name.ToLower(),
            Color.Gold.Name.ToLower(), Color.OliveDrab.Name.ToLower(),
            Color.Orange.Name.ToLower(), Color.LightGreen.Name.ToLower(), Color.Peru.Name.ToLower(), Color.DeepPink.Name.ToLower(), Color.MistyRose.Name.ToLower(),
            Color.DodgerBlue.Name.ToLower(), Color.MediumSlateBlue.Name.ToLower(), Color.SkyBlue.Name.ToLower(),
            Color.Yellow.Name.ToLower(), Color.Transparent.Name.ToLower()
        };


        public IActionResult Index()
        {
            return null;
        }

    
        public IActionResult Kcex2(int kcex)
        {
            OracleRepository repo = new OracleRepository();
            var queryRes = repo.GetEntities<RI_BIND_OB_V>();
            int[] konvenum = { 5, 4, 1, 2, 3 };
            ViewBag.KonveNum = konvenum;
            ViewBag.Colors = Colors;
            
            return View(queryRes.Where(x => x.KCEH == "OP02" && x.KPLOT.StartsWith("20")).OrderBy(x => x.WP).ToList());
        }
    }

    
}