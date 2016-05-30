using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace XomPoll.Core.Data {
    public class Linq2SqlDataContextFactory : IDataContextFactory {
        private readonly String connectionString;

        public Linq2SqlDataContextFactory() {
            connectionString = ConfigurationManager.ConnectionStrings["XomPoll"].ConnectionString;
        }

        public IDataContext Create() {
            return new Linq2SqlDataContext(connectionString);
        }
    }
}
