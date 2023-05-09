using Agri.Data.Abstract;
using Agri.Data.DatabaseContexts;
using Agri.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agri.DataAccess.Concrete.Repository
{
    public class MyRepository<T> : IRepository<T> where T : BaseEntity,new()
    {
        AgricultureContext agricultureContext;
        public MyRepository(AgricultureContext _agricultureContext)
        {
            agricultureContext = _agricultureContext;
        }

        public void Delete(T entity)
        {
            agricultureContext.Remove(entity);
            agricultureContext.SaveChanges();
        }

        public T GetById(int id)
        {
           return agricultureContext.Set<T>().Find(id); 
           
        }

        public List<T> GetListAll()
        {
            return agricultureContext.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            agricultureContext.Add(entity);
            agricultureContext.SaveChanges();
        }

        public void Update(T entity)
        {
            agricultureContext.Update(entity);
            agricultureContext.SaveChanges();
        }
    }
}
