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
    public class ImageManager : IImageService
    {
        private readonly IRepoImage _repoImage;
        public ImageManager(IRepoImage repoImage)
        {
            _repoImage = repoImage;
        }

        public void Delete(Image entity)
        {
            _repoImage.Delete(entity);
        }

        public Image GetById(int id)
        {
            return _repoImage.GetById(id);
        }

        public List<Image> GetListAll()
        {
            return _repoImage.GetListAll();
        }

        public void Insert(Image entity)
        {
            _repoImage.Insert(entity);
        }

        public void Update(Image entity)
        {
            _repoImage.Update(entity);
        }
    }
}
