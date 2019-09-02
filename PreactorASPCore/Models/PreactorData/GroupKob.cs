using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class GroupKob
    {
        public int IdGroupKob { get; set; }
        public int GroupId { get; set; }
        public int Kob { get; set; }
        public int Ktopn { get; set; }
        public int? AreaId { get; set; }

        public Areas Area { get; set; }
        public ResourcesGroup Group { get; set; }
    }
}
