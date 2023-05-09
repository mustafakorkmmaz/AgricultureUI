using Agri.Business.Abstract;
using Agri.DataAccess.Abstract;
using Agri.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agri.Business.Concrete
{
    
    public class AdminManager : IAdminService
    {
        IRepoAdmin _repoAdmin;

        public AdminManager(IRepoAdmin repoAdmin)
        {
            _repoAdmin = repoAdmin;
        }

        public void Delete(Admin entity)
        {
            _repoAdmin.Delete(entity);
        }

        public Admin GetById(int id)
        {
           return _repoAdmin.GetById(id);
        }

        public List<Admin> GetListAll()
        {
            return _repoAdmin.GetListAll();
        }

        public void Insert(Admin entity)
        {
            _repoAdmin.Insert(entity);
        }

        public void Update(Admin entity)
        {
           _repoAdmin.Update(entity);
        }
    }
}
