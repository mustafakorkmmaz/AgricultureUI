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
    public class AddressManager : IAddressService
    {
        private readonly IRepoAddress _repoAddress;

        public AddressManager(IRepoAddress repoAddress) 
        {
            _repoAddress = repoAddress;
        }
        public void Delete(Address entity)
        {
            throw new NotImplementedException();
        }

        public Address GetById(int id)
        {
            return _repoAddress.GetById(id);
        }

        public List<Address> GetListAll()
        {
            return _repoAddress.GetListAll();
        }

        public void Insert(Address entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Address entity)
        {
            _repoAddress.Update(entity);
        }
    }
}
