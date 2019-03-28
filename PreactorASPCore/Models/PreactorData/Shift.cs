using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class Shift
    {
        public Shift()
        {
            Cicle = new HashSet<Cicle>();
            SettingShift = new HashSet<SettingShift>();
            WorkDays = new HashSet<WorkDays>();
        }

        public int IdShift { get; set; }
        public string Title { get; set; }

        public ICollection<Cicle> Cicle { get; set; }
        public ICollection<SettingShift> SettingShift { get; set; }
        public ICollection<WorkDays> WorkDays { get; set; }
    }
}
