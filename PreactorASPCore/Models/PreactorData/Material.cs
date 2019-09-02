using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class Material
    {
        public Material()
        {
            BalanceOmts = new HashSet<BalanceOmts>();
            Specifications = new HashSet<Specifications>();
            SupplyOmts = new HashSet<SupplyOmts>();
        }

        public int IdMaterial { get; set; }
        public string Title { get; set; }
        public string Attribute { get; set; }

        public ICollection<BalanceOmts> BalanceOmts { get; set; }
        public ICollection<Specifications> Specifications { get; set; }
        public ICollection<SupplyOmts> SupplyOmts { get; set; }
    }
}
