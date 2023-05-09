using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agri.Entity.Entities
{
    public class Contact : BaseEntity
    {
        
        public string Name { get; set; }
        public string Email { get; set; }
        public string? Message { get; set; }
        public DateTime ContactDate { get; set; }
    }
}
