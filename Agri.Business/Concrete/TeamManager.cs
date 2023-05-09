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
    public class TeamManager:IStuffService
    {
        private readonly IRepoStuff _repoStuff;

        public TeamManager(IRepoStuff repoStuff)
        {
            _repoStuff = repoStuff;
        }

        public void Delete(Stuff entity)
        {
            _repoStuff.Delete(entity);
        }

        public Stuff GetById(int id)
        {
            return _repoStuff.GetById(id);
        }

        public List<Stuff> GetListAll()
        {
           return _repoStuff.GetListAll();
        }

        public void Insert(Stuff entity)
        {
            _repoStuff.Insert(entity);
        }

        public void Update(Stuff entity)
        {
            _repoStuff.Update(entity);
        }
    }
}
