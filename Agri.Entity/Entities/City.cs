using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agri.Entity.Entities
{
    public class City:BaseEntity
    {
        public string Name { get; set; }
        public decimal Percentage { get; set; }
    }
}
