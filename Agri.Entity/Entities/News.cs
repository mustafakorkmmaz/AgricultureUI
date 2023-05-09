using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agri.Entity.Entities
{
    public class News : BaseEntity
    {
        
        public string Title { get; set; }
        public string NewsTopic { get; set; }
        public string NewsSummary { get; set; }
        public string Description { get; set; }
        public string NewsImage { get; set; }
        public string NewsClass { get; set; }
        public string NewsModalTarget { get; set; }

        public DateTime NewsDate { get; set; }
        public bool Status { get; set; }

    }
}
