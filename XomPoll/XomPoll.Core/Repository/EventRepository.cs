using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using XomPoll.Core.Data;

namespace XomPoll.Core.Repository {

    public interface IEventRepository {
        void Create(Event item);
        void Update(Event item);
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
    }

    [Serializable]
    internal class EventNotFoundException : Exception {
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
