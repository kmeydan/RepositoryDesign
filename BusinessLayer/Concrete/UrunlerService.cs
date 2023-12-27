using BusinessLayer.Abstract;
using DataAccess.Abstract;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class UrunlerService : IUrunlerService
	{
		private readonly IUrunlerDal _urunlerDal;

		public UrunlerService(IUrunlerDal urunlerDal)
		{
			_urunlerDal = urunlerDal;
		}

		public void Add(Urun entity)
		{
			_urunlerDal.Add(entity);
		}

		public void Delete(Urun entity)
		{
			_urunlerDal.Delete(entity);
		}

		public Urun Get(int id)
		{
			return _urunlerDal.GetId(id);
		}

		public  List<Urun> GetAll()
		{
			return _urunlerDal.GetAll();
		}

		public IQueryable<Urun> GetEx(Expression<Func<Urun, bool>> query)
		{
			return _urunlerDal.GetEx(query);
		}

		public void Update(Urun entity)
		{
			_urunlerDal.Update(entity);
		}
	}
}
