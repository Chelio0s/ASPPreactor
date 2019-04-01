using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'.'MM'.'yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateWorkDay { get; set; }

        public int ShiftId { get; set; }

        public string wdCrew { get; set; }
        [DataType(DataType.Time)]
        public DateTime StartWork { get; set; }
        [DataType(DataType.Time)]
        public DateTime EndWork { get; set; }
    }

    public class InfoWH
    {
        /// <summary>
        /// Код
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Расшифровка кода
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Смена
        /// </summary>
        public int Shift { get; set; }

        /// <summary>
        /// время перерыва с-по на первой смене
        /// </summary>
        public string S1FT { get; set; }

        /// <summary>
        /// основной пирив на первой смене
        /// </summary>
        public string S1break { get; set; }

        /// <summary>
        /// время перерыва с-по на второй смене
        /// </summary>
        public string S2FT { get; set; }

        /// <summary>
        /// основной пирив на второй смене
        /// </summary>
        public string S2break { get; set; }
    }
}