using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class DepartComposition
    {
        public int IdDepComposition { get; set; }
        public int DepartmentId { get; set; }
        public int ResourcesGroupId { get; set; }

        public Departments Department { get; set; }
        public ResourcesGroup ResourcesGroup { get; set; }
    }
}
