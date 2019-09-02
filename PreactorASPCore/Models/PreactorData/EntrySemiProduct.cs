using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class EntrySemiProduct
    {
        public int IdSemiProduct { get; set; }
        public int IdSemiProductChild { get; set; }

        public SemiProducts IdSemiProductChildNavigation { get; set; }
        public SemiProducts IdSemiProductNavigation { get; set; }
    }
}
