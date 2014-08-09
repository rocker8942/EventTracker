using EventTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventTracker.Services
{
    public class EventService : IEventService
    {
        private EventTrackerContext db = new EventTrackerContext();

        public IList<Models.EventModel> GetEventss(int max = 0)
        {
            return max > 0 ? this.db.EventModels.Take(max).ToList() : this.db.EventModels.ToList();
        }

        public Models.EventModel GetEvent(int id)
        {
            var eventModel = this.db.EventModels.Single(e => e.Id== id);
            return eventModel;
        }
    }
}