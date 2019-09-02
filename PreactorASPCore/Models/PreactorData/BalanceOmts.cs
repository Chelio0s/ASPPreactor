using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class BalanceOmts
    {
        public int IdBalance { get; set; }
        public double OrderNumber { get; set; }
        public int MaterialId { get; set; }
        public double Count { get; set; }

        public Material Material { get; set; }
    }
}
