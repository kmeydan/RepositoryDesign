using DataAccess.Abstract;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
	public class UrunlerDal : BaseRepository<Urun>, IUrunlerDal
	{
		public UrunlerDal(EfNorthwindContext context) : base(context)
		{
		}
	}
}
