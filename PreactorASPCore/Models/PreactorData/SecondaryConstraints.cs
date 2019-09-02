using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class SecondaryConstraints
    {
        public SecondaryConstraints()
        {
            Calendar = new HashSet<Calendar>();
            UseConstraintOperations = new HashSet<UseConstraintOperations>();
            UseConstraintResources = new HashSet<UseConstraintResources>();
        }

        public int IdSecondaryConstraint { get; set; }
        public string Title { get; set; }

        public ICollection<Calendar> Calendar { get; set; }
        public ICollection<UseConstraintOperations> UseConstraintOperations { get; set; }
        public ICollection<UseConstraintResources> UseConstraintResources { get; set; }
    }
}
