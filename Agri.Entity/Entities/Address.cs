using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agri.Entity.Entities
{
    public class Address:BaseEntity
    {
        
        public string FDesc { get; set; }
        public string? SDesc { get; set; }
        public string? TDesc { get; set; }
        public string? FoDesc { get; set; }
        public string MapInfo { get; set; }
    }
}
