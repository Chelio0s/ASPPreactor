using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class EmployeesCalendar
    {
        public int IdEmpCalendar { get; set; }
        public int OrgUnit { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Orgunit OrgUnitNavigation { get; set; }
    }
}
