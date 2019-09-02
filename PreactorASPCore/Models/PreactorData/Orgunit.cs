using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class Orgunit
    {
        public Orgunit()
        {
            Employees = new HashSet<Employees>();
            EmployeesCalendar = new HashSet<EmployeesCalendar>();
        }

        public int OrgUnit1 { get; set; }
        public int? AreaId { get; set; }
        public string Title { get; set; }
        public string Crew { get; set; }

        public Areas Area { get; set; }
        public ICollection<Employees> Employees { get; set; }
        public ICollection<EmployeesCalendar> EmployeesCalendar { get; set; }
    }
}
