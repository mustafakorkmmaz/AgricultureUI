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

    public class NewsManager:INewsService
    {
        private readonly IRepoNews _repoNews;

        public NewsManager(IRepoNews repoNews)
        {
            _repoNews = repoNews;
        }

        public void ChangeStatusToFalse(int id)
        {
            _repoNews.ChangeStatusToFalse(id);
        }

        public void ChangeStatusToTrue(int id)
        {
            _repoNews.ChangeStatusToTrue(id);
        }

        public void Delete(News entity)
        {
            _repoNews.Delete(entity);
        }

        public News GetById(int id)
        {
            return _repoNews.GetById(id);
        }

        public List<News> GetListAll()
        {
            return _repoNews.GetListAll();
        }

        public void Insert(News entity)
        {
            _repoNews.Insert(entity);
        }

        public void Update(News entity)
        {
            _repoNews.Update(entity);
        }
    }
}
