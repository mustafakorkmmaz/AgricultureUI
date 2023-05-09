using Agri.Data.DatabaseContexts;
using Agri.DataAccess.Abstract;
using Agri.DataAccess.Concrete.Repository;
using Agri.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agri.DataAccess.Concrete.Efw
{
    public class EfAdmin : MyRepository<Admin>, IRepoAdmin
    {
        public EfAdmin(AgricultureContext _agricultureContext) : base(_agricultureContext)
        {

        }
    }
}
