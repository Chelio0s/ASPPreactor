using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class EntrySimpleProduct
    {
        public int SimpleProductId { get; set; }
        public int SimpleProductIdChild { get; set; }

        public SimpleProduct SimpleProduct { get; set; }
        public SimpleProduct SimpleProductIdChildNavigation { get; set; }
    }
}
