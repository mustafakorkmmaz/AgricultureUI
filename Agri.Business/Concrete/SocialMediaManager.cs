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
	public class SocialMediaManager : ISocialMService
	{
		IRepoSm _repoSm;

		public SocialMediaManager(IRepoSm repoSm)
		{
			_repoSm = repoSm;
		}

		public void Delete(SocialMedia entity)
		{
			_repoSm.Delete(entity);
		}

		public SocialMedia GetById(int id)
		{
			return _repoSm.GetById(id);
		}

		public List<SocialMedia> GetListAll()
		{
			return _repoSm.GetListAll();
		}

		public void Insert(SocialMedia entity)
		{
			_repoSm.Insert(entity);
		}

		public void Update(SocialMedia entity)
		{
			_repoSm.Update(entity);
		}
	}
}
