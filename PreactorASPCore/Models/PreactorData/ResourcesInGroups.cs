using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class ResourcesInGroups
    {
        public int GroupResourcesId { get; set; }
        public int ResourceId { get; set; }

        public ResourcesGroup GroupResources { get; set; }
        public Resources Resource { get; set; }
    }
}
