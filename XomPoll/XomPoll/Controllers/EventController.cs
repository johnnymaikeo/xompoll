﻿using System;
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
                };
                _eventRepository.Create(newEvent);
                return Json(new { success = true });
            }catch(Exception ex) {
                return Json(new { success = false, message = ex.Message });
            }
        }
    }
}