using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class Calendar
    {
        public int IdCalendar { get; set; }
        public int SecondaryConstraintId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Count { get; set; }

        public SecondaryConstraints SecondaryConstraint { get; set; }
    }
}
