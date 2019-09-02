using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class SettingShift
    {
        public int IdSettingShift { get; set; }
        public int AreaId { get; set; }
        public int ShiftId { get; set; }
        public TimeSpan TimeStart { get; set; }

        public Areas Area { get; set; }
        public Shift Shift { get; set; }
    }
}
