using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agri.Entity.Entities
{
    public class Stuff:BaseEntity
    {
       
        public string Name { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string FacebookUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string WebsiteUrl { get; set; }
        public string TwitterUrl { get; set; }
    }
}
