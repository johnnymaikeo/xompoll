using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XomPoll.Core.Data;
using XomPoll.Core.Repository;

namespace XomPoll.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionController(IQuestionRepository questionRepository) {
            _questionRepository = questionRepository;
        }

        [HttpGet]
        public ActionResult GetAnswerOptionsByQuestionId(int questionid) {
            return Json(_questionRepository.GetAnswerOptionsByQuestionId(questionid),
                            JsonRequestBehavior.AllowGet);
        }

        public ActionResult CreateQuestion(int eventid, int questiontypeid, string description, params string[] answeroptions) {
            var question = new Question {
                EventId = eventid,
                QuestionTypeId = questiontypeid,
                Description = description
            };
            try {
                _questionRepository.CreateQuestion(question);
                foreach(var answeroption in answeroptions) {
                    _questionRepository.CreateAnswerOption(new AnswerOption {
                        QuestionId = question.Id,
                        Description = answeroption,
                    });
                }
                return Json(new { sucess = true, questionid = question.Id});
            }catch(Exception ex) {
                return Json(new { sucess = false, message = ex.Message });
            }
        }

        //[HttpPost]
        //public ActionResult AnswerQuestion(int questionid, int answerid) {

        //}
    }
}