using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTracker.Models
{
    public interface IEventModel
    {
        double GetLatitude();
        double GetLongitude();
    }
}
