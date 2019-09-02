using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class WorkDays
    {
        public int IdWorkDay { get; set; }
        public DateTime DateWorkDay { get; set; }
        public int ShiftId { get; set; }
        public string Crew { get; set; }

        public Shift Shift { get; set; }
    }
}
