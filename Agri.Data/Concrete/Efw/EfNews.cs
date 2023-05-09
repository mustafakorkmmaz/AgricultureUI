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
    public class EfNews : MyRepository<News>, IRepoNews
    {
        public EfNews(AgricultureContext _agricultureContext) : base(_agricultureContext)
        {

        }

        public void ChangeStatusToFalse(int id)
        {
            var context = new AgricultureContext();
            try
            {
                var durum = context.Haberler.Find(id);
                durum.Status = false;
                context.SaveChanges();
            }
            catch 
            {
                return;
                
            }
               
        }

        public void ChangeStatusToTrue(int id)
        {
            var context = new AgricultureContext();
            try
            {
                var durum = context.Haberler.Find(id);
                durum.Status = true;
                context.SaveChanges();
            }
            catch
            {
                return;

            }
        }
    }
}
