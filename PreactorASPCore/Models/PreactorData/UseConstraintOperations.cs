using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class UseConstraintOperations
    {
        public int IdUseConstraint { get; set; }
        public int ResourceId { get; set; }
        public int ConstraintId { get; set; }
        public int Count { get; set; }
        public bool IsUse { get; set; }

        public SecondaryConstraints Constraint { get; set; }
        public Resources Resource { get; set; }
    }
}
