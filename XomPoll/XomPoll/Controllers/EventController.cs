using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XomPoll.Core.Data;
using XomPoll.Core.Repository;

namespace XomPoll.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventRepository _eventRepository;

        public EventController(IEventRepository eventRepository) {
            _eventRepository = eventRepository;
        }
        
        [HttpPost]
        public ActionResult Create(string title, string description, string urlname, 
                                        string initdate, string enddate)
        {
            try {
                var newEvent = new Event {
                    Title = title,
                    Description = description,
                    UrlName = urlname,
                    InitDate = DateTime.Parse(initdate),
                    EndDate = DateTime.Parse(enddate),
                    AdminId = 1,
                };
                _eventRepository.Create(newEvent);
                return Json(new { success = true, newid = newEvent.Id});
            }catch(Exception ex) {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult Update(int id, string title, string description, string urlname,
                                        string initdate, string enddate) {
            try {
                var eventToUpdate = new Event {
                    Id = id,
                    Title = title,
                    Description = description,
                    UrlName = urlname,
                    InitDate = DateTime.Parse(initdate),
                    EndDate = DateTime.Parse(enddate),
                    AdminId = 1,
                };
                _eventRepository.Update(eventToUpdate);
                return Json(new { success = true });
            } catch(Exception ex) {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetEventByUrl(string url) {
            try{
                var item = _eventRepository.LoadEventByUrlName(url);
                return Json(new { success = true, item = item }, JsonRequestBehavior.AllowGet);
            }catch(Exception ex) {
                return Json(new { success = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult GetQuestionsByEventId(int eventid) {
            return Json(_eventRepository.GetQuestionsByEventId(eventid), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetEventsByUser(int userid) {
            return Json(_eventRepository.GetEventsByUser(userid), JsonRequestBehavior.AllowGet);
        }

    }
}