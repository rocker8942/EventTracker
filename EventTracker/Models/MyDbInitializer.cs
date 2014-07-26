using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EventTracker.Models
{
    //public class MyDbInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    public class MyDbInitializer : DropCreateDatabaseAlways<EventTrackerContext>
    {
        protected override void Seed(EventTrackerContext context)
        {
            InitializeModelForEF(context);
            base.Seed(context);
        }

        private void InitializeModelForEF(EventTrackerContext context)
        {


            new List<EventModel>
            {
                new EventModel { Title="Title1", Detail="Contents1", StartDate=DateTime.Now.AddDays(-1), EndDate= DateTime.Now.AddDays(-1), Address="", Url=""}, 
                new EventModel { Title="Title2", Detail="Contents2", StartDate=DateTime.Now.AddDays(-2), EndDate= DateTime.Now.AddDays(0), Address="", Url=""},
                new EventModel { Title="Title3", Detail="Contents3", StartDate=DateTime.Now.AddDays(-3), EndDate= DateTime.Now.AddDays(-3), Address="", Url=""},
                new EventModel { Title="Title4", Detail="Contents4", StartDate=DateTime.Now.AddDays(-4), EndDate= DateTime.Now.AddDays(-4), Address="", Url=""},
                new EventModel { Title="Title5", Detail="Contents5", StartDate=DateTime.Now.AddDays(-4), EndDate= DateTime.Now.AddDays(-4), Address="", Url=""},
                new EventModel { Title="Title6", Detail="Contents6", StartDate=DateTime.Now.AddDays(-5), EndDate= DateTime.Now.AddDays(+1), Address="", Url=""}

            }.ForEach(e => context.EventModels.Add(e));

        }

    }
}