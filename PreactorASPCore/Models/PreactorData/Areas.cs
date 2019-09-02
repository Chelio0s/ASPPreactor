using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class Areas
    {
        public Areas()
        {
            Cicle = new HashSet<Cicle>();
            Departments = new HashSet<Departments>();
            GroupKob = new HashSet<GroupKob>();
            Orgunit = new HashSet<Orgunit>();
            SettingShift = new HashSet<SettingShift>();
        }

        public int IdArea { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }

        public ICollection<Cicle> Cicle { get; set; }
        public ICollection<Departments> Departments { get; set; }
        public ICollection<GroupKob> GroupKob { get; set; }
        public ICollection<Orgunit> Orgunit { get; set; }
        public ICollection<SettingShift> SettingShift { get; set; }
    }
}
