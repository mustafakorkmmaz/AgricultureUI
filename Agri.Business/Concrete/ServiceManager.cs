using Agri.Business.Abstract;
using Agri.Data.Abstract;
using Agri.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agri.Business.Concrete
{
    public class ServiceManager:IServService
    {
        private readonly IReposService _reposService;

        public ServiceManager(IReposService reposService)
        {
            _reposService = reposService;
        }

        public void Delete(Service entity)
        {
            _reposService.Delete(entity);
        }

        public Service GetById(int id)
        {
           return _reposService.GetById(id);
        }

        public List<Service> GetListAll()
        {
           return _reposService.GetListAll();
        }

        public void Insert(Service entity)
        {
            _reposService.Insert(entity);
        }

        public void Update(Service entity)
        {
            _reposService.Update(entity);
        }
    }
}
