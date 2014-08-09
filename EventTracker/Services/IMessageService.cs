using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTracker.Services
{
    public interface IMessageService
    {
        string Message { get; set; }

        string ImageUrl { get; set; }
    }
}
