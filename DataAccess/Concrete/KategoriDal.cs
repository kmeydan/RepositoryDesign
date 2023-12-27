using DataAccess.Abstract;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
	public class KategoriDal : BaseRepository<Kategori>, IKategoriDal
	{
		public KategoriDal(EfNorthwindContext context) : base(context)
		{
		}
	}
}
