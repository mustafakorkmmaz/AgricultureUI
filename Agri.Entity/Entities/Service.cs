using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agri.Entity.Entities
{
    public class Service:BaseEntity
    {
       
        public string ServiceTitle { get; set; }
        public string ServiceDescription { get; set; }
        public string ServiceImage { get; set; }
        public string ServiceClassFirst { get; set; }
        public string ServiceClassSec { get; set;}
    }
}
