using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class Log
    {
        public string LoginName { get; set; }
        public string HostName { get; set; }
        public string ObjectName { get; set; }
        public string ObjectType { get; set; }
        public string EventType { get; set; }
        public string EventSqlcommand { get; set; }
        public DateTime EventTime { get; set; }
        public string Xmlchange { get; set; }
        public int Id { get; set; }
        public string IpAddress { get; set; }
    }
}
