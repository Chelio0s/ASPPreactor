using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class Plan
    {
        public int IdPlan { get; set; }
        public int ArticleId { get; set; }
        public double Count { get; set; }
        public DateTime? DateTime { get; set; }
        public double Priority { get; set; }

        public Article Article { get; set; }
    }
}
