using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XomPoll.Core.Data {
    public interface IDataContext : IDisposable {
        IQueryable<TEntity> GetTable<TEntity>() where TEntity : class;

        void InsertOnSubmit(Object obj);

        void DeleteOnSubmit(Object obj);
        void DeleteAllOnSubmit<T>(IEnumerable<T> objs);

        void Attach(Object obj, Boolean asModified);

        void Attach(Object entity, Object original);

        void SetDeferredLoadingEnabled(bool value);

        DataLoadOptions LoadOptions { get; set; }

        void SubmitChanges();

        int ExecuteCommand(String command, params Object[] arguments);
        IEnumerable<TEntity> ExecuteQuery<TEntity>(String query, params Object[] args) where TEntity : class;

        IEnumerable<T> ExecuteQuerySQL<T>(String query, params Object[] args);

        bool ObjectTrackingEnabled { get; set; }
    }
}
