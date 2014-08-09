using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventTracker.Factories
{
    //CustomViewPageActivator is responsible for managing the creation of a view by using a Unity container.
    public class CustomViewPageActivator : IViewPageActivator
    {
        private IUnityContainer container;

        public CustomViewPageActivator(IUnityContainer container)
        {
            this.container = container;
        }

        public object Create(ControllerContext controllerContext, Type type)
        {
            return this.container.Resolve(type);
        }
    }
}