using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class Professions
    {
        public Professions()
        {
            EmployeesInProfession = new HashSet<EmployeesInProfession>();
            Operations = new HashSet<Operations>();
        }

        public int IdProfession { get; set; }
        public string Title { get; set; }
        public string CodeRkv { get; set; }

        public ICollection<EmployeesInProfession> EmployeesInProfession { get; set; }
        public ICollection<Operations> Operations { get; set; }
    }
}
