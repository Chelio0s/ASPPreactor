using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class Departments
    {
        public Departments()
        {
            DepartComposition = new HashSet<DepartComposition>();
            Resources = new HashSet<Resources>();
        }

        public int IdDepartment { get; set; }
        public string Title { get; set; }
        public int AreaId { get; set; }

        public Areas Area { get; set; }
        public ICollection<DepartComposition> DepartComposition { get; set; }
        public ICollection<Resources> Resources { get; set; }
    }
}
