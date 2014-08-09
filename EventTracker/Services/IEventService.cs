using EventTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTracker.Services
{
    public interface IEventService
    {
        IList<EventModel> GetEventss(int max = 0);
        EventModel GetEvent(int id);
    }
}
