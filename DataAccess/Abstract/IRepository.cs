using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
	public interface IRepository<T> where T : class,IEntity,new()
	{
		T GetId(int id);
		IQueryable<T> GetEx(Expression<Func<T,bool>> expression);
		List<T> GetAll();
		void Delete(T entity);
		void Update(T entity);
		void Add(T entity);
		void SaveChanges();
		
	}
}
