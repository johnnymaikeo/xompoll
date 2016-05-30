using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using XomPoll.Core.Data;

namespace XomPoll.Core.Repository {

    public interface IEventRepository {
        void Create(Event item);
        void Update(Event item);
        object LoadEventByUrlName(string url);
        object[] GetQuestionsByEventId(int id);
        object[] GetEventsByUser(int userId);
    }
    public class EventRepository : IEventRepository  {
        private readonly IDataContextFactory _dataContextFactory;

        public EventRepository(IDataContextFactory dataContextFactory) {
            _dataContextFactory = dataContextFactory;
        }

        public void Create(Event item) {
            using(var ctx = _dataContextFactory.Create()) {
                ctx.InsertOnSubmit(item);
                ctx.SubmitChanges();
            }
        }

        public object LoadEventByUrlName(string url) {
            using(var ctx = _dataContextFactory.Create()) {
                var item = ctx.GetTable<Event>().SingleOrDefault(x => x.UrlName == url);
                if(item != null) {
                    var objectEvent = new {
                        Id = item.Id,
                        Description = item.Description,
                        InitDate = item.InitDate.ToString(@"MM\/dd\/yyyy HH:mm"),
                        EndDate = item.EndDate.ToString(@"MM\/dd\/yyyy HH:mm"),
                        Title = item.Title,
                        UrlName = item.UrlName
                    };
                    return objectEvent;
                } else {
                    throw new EventNotFoundException("Event not found on the database!");
                }
            }
        }

        public void Update(Event item) {
            using(var ctx = _dataContextFactory.Create()) {
                var toBeUpdated = ctx.GetTable<Event>().SingleOrDefault(x => x.Id == item.Id);
                if(toBeUpdated != null) {
                    toBeUpdated.Description = item.Description;
                    toBeUpdated.InitDate = item.InitDate;
                    toBeUpdated.EndDate = item.EndDate;
                    toBeUpdated.Title = item.Title;
                    toBeUpdated.UrlName = item.UrlName;
                } else {
                    throw new EventNotFoundException("Event does not exist on the database!");
                }
            }
        }

        public object[] GetQuestionsByEventId(int id) {
            using(var ctx = _dataContextFactory.Create()) {
                ctx.SetDeferredLoadingEnabled(false);
                DataLoadOptions options = new DataLoadOptions();
                options.LoadWith<Question>(o => o.QuestionType);
                ctx.LoadOptions = options;
                return ctx.GetTable<Question>().Where(x => x.EventId == id).ToArray();
            }
        }

        public object[] GetEventsByUser(int userId) {
            using(var ctx = _dataContextFactory.Create()) {
                return ctx.GetTable<Event>().Where(x => x.AdminId == userId).Select(x=>new {
                    Id = x.Id,
                    Description = x.Description,
                    InitDate = x.InitDate,
                    EndDate = x.EndDate,
                    Title = x.Title,
                    UrlName = x.UrlName
                }).ToList()
                .Select(x => new {
                    Id = x.Id,
                    Description = x.Description,
                    InitDate = x.InitDate.ToString(@"MM\/dd\/yyyy HH:mm"),
                    EndDate = x.EndDate.ToString(@"MM\/dd\/yyyy HH:mm"),
                    Title = x.Title,
                    UrlName = x.UrlName
                }).ToArray();
            }
        }
    }

    [Serializable]
    public class EventNotFoundException : Exception {
        public EventNotFoundException() {
        }

        public EventNotFoundException(string message) : base(message) {
        }

        public EventNotFoundException(string message, Exception innerException) : base(message, innerException) {
        }

        protected EventNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}
