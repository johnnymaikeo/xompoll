using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XomPoll.Core.Data {
    public interface IDataContextFactory {
        IDataContext Create();
    }
}
