using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class SequenceOperations
    {
        public int IdSeqOperation { get; set; }
        public int OperOrder { get; set; }
        public int Ktop { get; set; }
        public string Title { get; set; }
        public int SimpleProductId { get; set; }

        public SimpleProduct SimpleProduct { get; set; }
    }
}
