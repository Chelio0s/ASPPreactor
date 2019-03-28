using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class EmployeesInProfession
    {
        public string EmployeeId { get; set; }
        public int ProfessionId { get; set; }
        public int CategoryProfession { get; set; }
        public bool IsPrimary { get; set; }

        public Employees Employee { get; set; }
        public Professions Profession { get; set; }
    }
}
