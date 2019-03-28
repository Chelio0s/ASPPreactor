using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class Specifications
    {
        public int IdSpecification { get; set; }
        public int MaterialId { get; set; }
        public double Norma { get; set; }
        public int OperationId { get; set; }

        public Material Material { get; set; }
        public Operations Operation { get; set; }
    }
}
