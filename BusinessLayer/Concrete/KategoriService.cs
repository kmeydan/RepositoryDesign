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
	public class KategoriService : IKategorilerService
	{
		private readonly IKategoriDal _kategoriDal;

		public KategoriService(IKategoriDal kategoriDal)
		{
			this._kategoriDal = kategoriDal;
		}

		public void Add(Kategori entity)
		{
			_kategoriDal.Add(entity);	
		}

		public void Delete(Kategori entity)
		{
			_kategoriDal.Delete(entity);
		}

		public Kategori Get(int id)
		{
			return _kategoriDal.GetId(id);
		}

		public List<Kategori> GetAll()
		{
			return _kategoriDal.GetAll();
		}

		public IQueryable<Kategori> GetEx(Expression<Func<Kategori, bool>> query)
		{
			return _kategoriDal.GetEx(query);
		}

		public void Update(Kategori entity)
		{
			_kategoriDal.Update(entity);
		}
	}
}
