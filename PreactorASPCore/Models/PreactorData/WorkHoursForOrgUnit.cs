using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PreactorASPCore.Models.PreactorData
{
    [Table("VI_WorkHoursForOrgUnit", Schema = "InputData")]
    public class WorkHoursForOrgUnit
    {
        public int OrgUnit { get; set; }

        public int AreaId { get; set; }

        public string OrgTitle { get; set; }

        public string code { get; set; }

        public string Title { get; set; }

        public DateTime DateWorkDay { get; set; }

        public int ShiftId { get; set; }

        public string wdCrew { get; set; }

        public DateTime StartWork { get; set; }

        public DateTime EndWork { get; set; }
    }
}