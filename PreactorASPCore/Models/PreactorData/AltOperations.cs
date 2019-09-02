using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class AltOperations
    {
        public AltOperations()
        {
            AltOperationRule = new HashSet<AltOperationRule>();
        }

        public int IdKtop { get; set; }
        public int Ktop { get; set; }

        public ICollection<AltOperationRule> AltOperationRule { get; set; }
    }
}
