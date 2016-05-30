using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XomPoll.Core.Data;

namespace XomPoll.Core.Repository {

    public interface IQuestionRepository {
        object[] GetAnswerOptionsByQuestionId(int questionid);
    }
    public class QuestionRepository : IQuestionRepository {
        private readonly IDataContextFactory _dataContextFactory;
        public QuestionRepository (IDataContextFactory dataContextFactory) {
            _dataContextFactory = dataContextFactory;
        }

        public object[] GetAnswerOptionsByQuestionId(int questionid) {
            using(var ctx = _dataContextFactory.Create()) {
                return ctx.GetTable<AnswerOption>().Where(x => x.QuestionId == questionid).
                    Select(x => new {
                        Id = x.Id,
                        Description = x.Description,
                        QuestionId = x.QuestionId
                    }).ToArray();
            }
        }
    }
}
