using EventTracker.Models;
using EventTracker.Services;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventTracker.Pages
{
    public class MyBasePage : WebViewPage<EventModel>
    {
        [Dependency]
        public IMessageService MessageService { get; set; }

        public override void Execute()
        {
        }
    }
}