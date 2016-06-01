using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XomPoll.Core.Repository;

namespace XomPoll.Controllers
{
    public class QuestionTypeController : Controller
    {
        private readonly IQuestionTypeRepository _questionTypeRepository;

        public QuestionTypeController(IQuestionTypeRepository questionTypeRepository) {
            _questionTypeRepository = questionTypeRepository;
        } 

        [HttpGet]
        public ActionResult GetAll() {
            return Json(_questionTypeRepository.GetAllQuestionTypes(), JsonRequestBehavior.AllowGet);
        }
    }
}