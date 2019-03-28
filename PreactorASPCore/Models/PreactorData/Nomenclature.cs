using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class Nomenclature
    {
        public Nomenclature()
        {
            SemiProducts = new HashSet<SemiProducts>();
        }

        public int IdNomenclature { get; set; }
        public int ArticleId { get; set; }
        public string Number { get; set; }
        public double Size { get; set; }
        public double CountPersent { get; set; }

        public Article Article { get; set; }
        public ICollection<SemiProducts> SemiProducts { get; set; }
    }
}
