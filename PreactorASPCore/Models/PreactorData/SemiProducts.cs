using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class SemiProducts
    {
        public SemiProducts()
        {
            EntrySemiProductIdSemiProductChildNavigation = new HashSet<EntrySemiProduct>();
            EntrySemiProductIdSemiProductNavigation = new HashSet<EntrySemiProduct>();
            Operations = new HashSet<Operations>();
        }

        public int IdSemiProduct { get; set; }
        public string Title { get; set; }
        public int NomenclatureId { get; set; }

        public Nomenclature Nomenclature { get; set; }
        public ICollection<EntrySemiProduct> EntrySemiProductIdSemiProductChildNavigation { get; set; }
        public ICollection<EntrySemiProduct> EntrySemiProductIdSemiProductNavigation { get; set; }
        public ICollection<Operations> Operations { get; set; }
    }
}
