using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class Resources
    {
        public Resources()
        {
            OperationInResource = new HashSet<OperationInResource>();
            ResourcesInGroups = new HashSet<ResourcesInGroups>();
            UseConstraintOperations = new HashSet<UseConstraintOperations>();
            UseConstraintResources = new HashSet<UseConstraintResources>();
        }

        public int IdResource { get; set; }
        public string Title { get; set; }
        public string TitleWorkPlace { get; set; }
        public int DepartmentId { get; set; }
        public int Kob { get; set; }

        public Departments Department { get; set; }
        public ICollection<OperationInResource> OperationInResource { get; set; }
        public ICollection<ResourcesInGroups> ResourcesInGroups { get; set; }
        public ICollection<UseConstraintOperations> UseConstraintOperations { get; set; }
        public ICollection<UseConstraintResources> UseConstraintResources { get; set; }
    }
}
