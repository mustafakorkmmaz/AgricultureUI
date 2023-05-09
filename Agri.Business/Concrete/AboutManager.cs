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
	public class AboutManager : IAboutService
	{
		IRepoAbout _repoAbout;

		public AboutManager(IRepoAbout repoAbout)
		{
			_repoAbout = repoAbout;
		}

		public void Delete(About entity)
		{
			throw new NotImplementedException();
		}

		public About GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<About> GetListAll()
		{
			return _repoAbout.GetListAll();
		}

		public void Insert(About entity)
		{
			throw new NotImplementedException();
		}

		public void Update(About entity)
		{
			throw new NotImplementedException();
		}
	}
}
