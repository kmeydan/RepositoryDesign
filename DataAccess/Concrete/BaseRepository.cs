using Microsoft.EntityFrameworkCore;
using DataAccess.Abstract;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
	public class BaseRepository<T> : IRepository<T> where T : class, IEntity, new()
	{
		private readonly EfNorthwindContext dbContext;

		public BaseRepository(EfNorthwindContext context)
		{
			this.dbContext= context;
		}

		public void Add(T entity)
		{
			dbContext.Set<T>().Add(entity);
		}

		public void Delete(T entity)
		{
			dbContext.Set<T>().Remove(entity);
		}

		public List<T> GetAll()
		{
			return dbContext.Set<T>().ToList();
		}

		public IQueryable<T> GetEx(Expression<Func<T, bool>> expression)
		{
			return dbContext.Set<T>().Where(expression).AsNoTracking();
		}

		public T GetId(int id)
		{
			return dbContext.Set<T>().Find(id);
		}

		public void SaveChanges()
		{
			dbContext.SaveChanges();
		}

		public void Update(T entity)
		{
			dbContext.Set<T>().Update(entity);
		}
	}
}
