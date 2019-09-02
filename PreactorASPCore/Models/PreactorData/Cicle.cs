using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class Cicle
    {
        public int IdCicle { get; set; }
        public int AreaId { get; set; }
        public TimeSpan DurationWork { get; set; }
        public TimeSpan DurationOff { get; set; }
        public int ShiftId { get; set; }

        public Areas Area { get; set; }
        public Shift Shift { get; set; }
    }
}
