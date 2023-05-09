using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agri.Entity.Entities
{
    public class Admin:BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
