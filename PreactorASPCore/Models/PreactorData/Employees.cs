using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class Employees
    {
        public Employees()
        {
            EmployeesInProfession = new HashSet<EmployeesInProfession>();
        }

        public string Name { get; set; }
        public string TabNum { get; set; }
        public int Orgunit { get; set; }

        public Orgunit OrgunitNavigation { get; set; }
        public ICollection<EmployeesInProfession> EmployeesInProfession { get; set; }
    }
}
