using System;
using System.Drawing;

namespace PreactorASPCore.Models.OracleData.Entity
{


    public class RI_BIND_OB_V
    {
        public string KPLOT { get; set; }
        public int WP { get; set; }
        public int KOB { get; set; }
        public DateTime TIME_S { get; set; }
        public string TEXT { get; set; }
        public DateTime DATE_S { get; set; }
        public string PC_S { get; set; }
        public string KCEH { get; set; }
        public string NCEH { get; set; }
        public string NPLOT { get; set; }
        public int KGROB { get; set; }
        public string NGROB { get; set; }
        public string MOB { get; set; }
        public string NOB { get; set; }

     

        public override bool Equals(object obj)
        {
            var v = obj as RI_BIND_OB_V;
            return v != null &&
                   KPLOT == v.KPLOT &&
                   WP == v.WP &&
                   KOB == v.KOB &&
                   TIME_S == v.TIME_S &&
                   TEXT == v.TEXT &&
                   DATE_S == v.DATE_S &&
                   PC_S == v.PC_S &&
                   KCEH == v.KCEH &&
                   NCEH == v.NCEH &&
                   NPLOT == v.NPLOT &&
                   KGROB == v.KGROB &&
                   NGROB == v.NGROB &&
                   MOB == v.MOB &&
                   NOB == v.NOB;
        }

        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(KPLOT);
            hash.Add(WP);
            hash.Add(KOB);
            hash.Add(TIME_S);
            hash.Add(TEXT);
            hash.Add(DATE_S);
            hash.Add(PC_S);
            hash.Add(KCEH);
            hash.Add(NCEH);
            hash.Add(NPLOT);
            hash.Add(KGROB);
            hash.Add(NGROB);
            hash.Add(MOB);
            hash.Add(NOB);
            return hash.ToHashCode();
        }
    }
}
