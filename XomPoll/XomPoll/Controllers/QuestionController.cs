using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XomPoll.Core.Repository;

namespace XomPoll.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionController(IQuestionRepository questionRepository) {
            _questionRepository = questionRepository;
        }
        // GET: Question
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetAnswerOptionsByQuestionId(int questionid) {
            return Json(_questionRepository.GetAnswerOptionsByQuestionId(questionid),
                            JsonRequestBehavior.AllowGet);
        }
    }
}