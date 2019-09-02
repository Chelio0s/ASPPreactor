using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class SupplyOmts
    {
        public int IdSupply { get; set; }
        public double SupplyOrder { get; set; }
        public int MaterialId { get; set; }
        public double Count { get; set; }
        public DateTime DateSupply { get; set; }

        public Material Material { get; set; }
    }
}
