using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace XomPoll.Core.Data {
    public class Linq2SqlDataContext : DataClassesDataContext, IDataContext {

        [ExcludeFromCodeCoverage]
        public Linq2SqlDataContext(string connectionString)
            : base(connectionString) {
            this.Log = new Logger();
        }

        [DebuggerHidden]
        public void InsertOnSubmit(Object obj) {
            GetTable(obj.GetType()).InsertOnSubmit(obj);
        }

        [DebuggerHidden]
        public void DeleteOnSubmit(Object obj) {
            GetTable(obj.GetType()).DeleteOnSubmit(obj);
        }

        [DebuggerHidden]
        public void DeleteAllOnSubmit<T>(IEnumerable<T> objs) {
            GetTable(typeof(T)).DeleteAllOnSubmit(objs);
        }

        [DebuggerHidden]
        public void Attach(Object obj, Boolean asModified) {
            GetTable(obj.GetType()).Attach(obj, asModified);
        }

        [DebuggerHidden]
        public void Attach(Object entity, Object original) {
            GetTable(entity.GetType()).Attach(entity, original);
        }

        [DebuggerHidden]
        public void SetDeferredLoadingEnabled(bool value) {
            this.DeferredLoadingEnabled = value;
        }

        [ExcludeFromCodeCoverage]
        public new IQueryable<TEntity> GetTable<TEntity>() where TEntity : class {
            return base.GetTable<TEntity>();
        }

        public new IEnumerable<TEntity> ExecuteQuery<TEntity>(String query, params Object[] args) where TEntity : class {
            return base.ExecuteQuery<TEntity>(query, args);
        }

        public new IEnumerable<T> ExecuteQuerySQL<T>(String query, params Object[] args) {
            return base.ExecuteQuery<T>(query, args);
        }

        [ExcludeFromCodeCoverage]
        void IDataContext.SubmitChanges() {
            base.SubmitChanges();
        }

        [ExcludeFromCodeCoverage]
        public class Logger : TextWriter {
            public override void Write(char[] buffer, int index, int count) {
                Debug.Write(new String(buffer, index, count));
            }

            public override void Write(string value) {
                System.Diagnostics.Debug.Write(value);
            }

            public override Encoding Encoding {
                get { return System.Text.Encoding.Default; }
            }
        }
    }
}
