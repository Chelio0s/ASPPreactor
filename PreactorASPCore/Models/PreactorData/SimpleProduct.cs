using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class SimpleProduct
    {
        public SimpleProduct()
        {
            EntrySimpleProductSimpleProduct = new HashSet<EntrySimpleProduct>();
            EntrySimpleProductSimpleProductIdChildNavigation = new HashSet<EntrySimpleProduct>();
            SequenceOperations = new HashSet<SequenceOperations>();
        }

        public int IdSimpleProduct { get; set; }
        public string Title { get; set; }

        public ICollection<EntrySimpleProduct> EntrySimpleProductSimpleProduct { get; set; }
        public ICollection<EntrySimpleProduct> EntrySimpleProductSimpleProductIdChildNavigation { get; set; }
        public ICollection<SequenceOperations> SequenceOperations { get; set; }
    }
}
