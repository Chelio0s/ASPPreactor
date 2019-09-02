using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class GroupKtop
    {
        public int IdGroupKtop { get; set; }
        public int Ktop { get; set; }
        public int GroupOperationId { get; set; }

        public GroupsOperations GroupOperation { get; set; }
    }
}
