using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cookery.Core.Interfaces.Infra
{
    public interface IUnitOfWork
    {
        void Insert<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Remove<T>(T entity) where T : class;
        void BeginTransaction();
        Task CommitAsync();
        void Rollback();
        Task SaveAsync();
        T GetById<T>(object id) where T : class;
        IQueryable<T> Get<T>(Expression<Func<T, bool>> where = null) where T : class;
        Task<IQueryable<T>> GetAll<T>() where T : class;
        void RemoveRange<T>(Expression<Func<T, bool>> where) where T : class;        
        DbRawSqlQuery<RawEntity> RawSql<RawEntity>(string sql, params object[] parameters);
        void SetCommandTimeout(int timeoutSeconds);
    }
    public interface IUnitOfWork<T> : IUnitOfWork { }
}