using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class OperationInResource
    {
        public int IdOpInResource { get; set; }
        public int OperationId { get; set; }
        public int ResourceId { get; set; }
        public double OperateTime { get; set; }

        public Operations Operation { get; set; }
        public Resources Resource { get; set; }
    }
}
