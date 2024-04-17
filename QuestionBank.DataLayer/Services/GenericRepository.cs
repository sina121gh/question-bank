using QuestionBank.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace QuestionBank.DataLayer.Services
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        private MyContext _db;
        private DbSet<TEntity> _dbSet;
        public GenericRepository(MyContext context)
        {
            _db = context;
            _dbSet = _db.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includes = "")
        {
            IQueryable<TEntity> query = _dbSet;

            if (where != null)
            {
                query = query.Where(where);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            if (includes != "")
            {
                foreach (string include in includes.Split(','))
                {
                    query = query.Include(include);
                }
            }

            return query.ToList();
        }

        public virtual TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public virtual bool Insert(TEntity entity)
        {
            try
            {
                _dbSet.Add(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public virtual bool Update(TEntity entity)
        {
            try
            {
                _db.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public virtual bool Delete(TEntity entity)
        {
            try
            {
                _db.Entry(entity).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public virtual bool Delete(object id)
        {
            try
            {
                Delete(GetById(id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
