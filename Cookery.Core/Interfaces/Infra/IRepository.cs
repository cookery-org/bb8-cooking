using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cookery.Core.Interfaces.Infra
{
    public interface IRepository<T>
    {
        void Insert(T entity);
        void Update(T entity);
        void Remove(T entity);
        void BeginTransaction();
        Task CommitAsync();
        void Rollback();
        IQueryable<T> Get(Expression<Func<T, bool>> where = null);
        Task<IQueryable<T>> GetAll();
        Task SalvarAsync();
        void RemoveRange(Expression<Func<T, bool>> where);
        DbRawSqlQuery<RawEntity> RawSql<RawEntity>(string sql, params object[] parameters);
        T GetById(object id);
        void SetCommandTimeout(int timeoutSeconds);
    }
}
