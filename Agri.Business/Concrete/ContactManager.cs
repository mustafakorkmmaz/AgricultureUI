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
    public class ContactManager : IContactService
    {
        private readonly IRepoContact _repoContact;
        public ContactManager(IRepoContact repoContact)
        {
            _repoContact = repoContact;
        }
        public void Delete(Contact entity)
        {
            _repoContact.Delete(entity);
        }

        public Contact GetById(int id)
        {
           return _repoContact.GetById(id);
        }

        public List<Contact> GetListAll()
        {
            return _repoContact.GetListAll();
        }

        public void Insert(Contact entity)
        {
            _repoContact.Insert(entity);
        }

        public void Update(Contact entity)
        {
            _repoContact.Update(entity);
        }
    }
}
