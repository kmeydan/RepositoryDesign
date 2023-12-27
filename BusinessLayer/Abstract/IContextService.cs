using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IContextService<T> where T : class,new()
	{
		List<T> GetAll();
		T Get(int id);
		IQueryable<T> GetEx(Expression<Func<T,bool>> query);
		void Delete(T entity);
		void Update (T entity);
		void Add (T entity);
		
	}
}
