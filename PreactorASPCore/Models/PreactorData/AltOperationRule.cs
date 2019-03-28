using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class AltOperationRule
    {
        public int IdRule { get; set; }
        public int AltOperationId { get; set; }
        public int Ktop { get; set; }

        public AltOperations AltOperation { get; set; }
    }
}
