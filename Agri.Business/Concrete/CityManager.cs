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
    public class CityManager : ICityService
    {
        IRepoCity _repoCity;
        public CityManager(IRepoCity repoCity)
        {
            _repoCity = repoCity;
        }

        public void Delete(City entity)
        {
           _repoCity.Delete(entity);
        }

        public City GetById(int id)
        {
            return _repoCity.GetById(id);
        }

        public List<City> GetListAll()
        {
            return _repoCity.GetListAll();
        }

        public void Insert(City entity)
        {
            _repoCity.Insert(entity);
        }

        public void Update(City entity)
        {
            _repoCity.Update(entity);
        }
    }
}
