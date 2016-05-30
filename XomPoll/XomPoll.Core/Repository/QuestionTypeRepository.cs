using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XomPoll.Core.Data;

namespace XomPoll.Core.Repository {
    public interface IQuestionTypeRepository {
        object[] GetAllQuestionTypes();
    }

    public class QuestionTypeRepository : IQuestionTypeRepository {

        private readonly IDataContextFactory _dataContextFactory;

        public QuestionTypeRepository(IDataContextFactory dataContextFactory) {
            _dataContextFactory = dataContextFactory;
        }

        public object[] GetAllQuestionTypes() {
            using(var ctx = _dataContextFactory.Create()) {
                ctx.SetDeferredLoadingEnabled(false);
                return ctx.GetTable<QuestionType>().ToArray();
            }
        }
    }
}
