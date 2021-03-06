﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XomPoll.Core.Data;

namespace XomPoll.Core.Repository {

    public interface IQuestionRepository {
        object[] GetAnswerOptionsByQuestionId(int questionid);
        void CreateQuestion(Question question);
        void CreateAnswerOption(AnswerOption answer);
        void AnswerQuestion(Answer answer);
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

        public void AnswerQuestion(Answer answer) {
            using(var ctx = _dataContextFactory.Create()) {
                ctx.InsertOnSubmit(answer);
                ctx.SubmitChanges();
            }
        }

        public void CreateQuestion(Question question) {
            using(var ctx = _dataContextFactory.Create()) {
                ctx.InsertOnSubmit(question);
                ctx.SubmitChanges();
            }
        }

        public void CreateAnswerOption(AnswerOption answer) {
            using(var ctx = _dataContextFactory.Create()) {
                ctx.InsertOnSubmit(answer);
                ctx.SubmitChanges();
            }
        }
    }
}
