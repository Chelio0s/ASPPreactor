using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class GroupsOperations
    {
        public GroupsOperations()
        {
            GroupKtop = new HashSet<GroupKtop>();
        }

        public int IdGroupOperations { get; set; }
        public string Title { get; set; }

        public ICollection<GroupKtop> GroupKtop { get; set; }
    }
}
