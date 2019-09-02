using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class Operations
    {
        public Operations()
        {
            OperationInResource = new HashSet<OperationInResource>();
            Specifications = new HashSet<Specifications>();
        }

        public int IdOperation { get; set; }
        public string Title { get; set; }
        public double NumberOp { get; set; }
        public int SemiProductId { get; set; }
        public int ProfessionId { get; set; }
        public bool TypeTime { get; set; }
        public int CategoryOperation { get; set; }

        public Professions Profession { get; set; }
        public SemiProducts SemiProduct { get; set; }
        public ICollection<OperationInResource> OperationInResource { get; set; }
        public ICollection<Specifications> Specifications { get; set; }
    }
}
