using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class ResourcesGroup
    {
        public ResourcesGroup()
        {
            DepartComposition = new HashSet<DepartComposition>();
            GroupKob = new HashSet<GroupKob>();
            ResourcesInGroups = new HashSet<ResourcesInGroups>();
        }

        public int IdResourceGroup { get; set; }
        public string Title { get; set; }

        public ICollection<DepartComposition> DepartComposition { get; set; }
        public ICollection<GroupKob> GroupKob { get; set; }
        public ICollection<ResourcesInGroups> ResourcesInGroups { get; set; }
    }
}
