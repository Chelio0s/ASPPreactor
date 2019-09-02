using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreactorASPCore.Models.PreactorData
{
    public class WorkshopWorker
    {
        /// <summary>
        /// Наименование цеха
        /// </summary>
        public string workshop { get; set; }
        
        /// <summary>
        /// Количество работников в цеху 
        /// </summary>
        public int AmountOfWorkers { get; set; }

    }
}
