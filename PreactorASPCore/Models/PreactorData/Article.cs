using System;
using System.Collections.Generic;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class Article
    {
        public Article()
        {
            Nomenclature = new HashSet<Nomenclature>();
            Plan = new HashSet<Plan>();
        }

        public int IdArticle { get; set; }
        public string Title { get; set; }
        public int MaxCountUse { get; set; }

        public ICollection<Nomenclature> Nomenclature { get; set; }
        public ICollection<Plan> Plan { get; set; }
    }
}
