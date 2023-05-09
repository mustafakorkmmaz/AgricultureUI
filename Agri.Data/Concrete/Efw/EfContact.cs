using Agri.Data.Abstract;
using Agri.Data.DatabaseContexts;
using Agri.DataAccess.Concrete.Repository;
using Agri.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agri.DataAccess.Concrete.Efw
{
    public class EfContact : MyRepository<Contact>, IRepoContact
    {
        public EfContact(AgricultureContext _agricultureContext) : base(_agricultureContext)
        {
        }
    }
}
