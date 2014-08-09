using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc4;
using EventTracker.Services;
using EventTracker.Controllers;
using EventTracker.Factories;
using EventTracker.Filters;

namespace EventTracker
{
    public static class Bootstrapper
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();
            DependencyResolver.SetResolver(new Unity.Mvc4.UnityDependencyResolver(container));
            
            IDependencyResolver resolver = DependencyResolver.Current;
            IDependencyResolver newResolver = new Factories.UnityDependencyResolver(container, resolver);
            DependencyResolver.SetResolver(newResolver);

            return container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();    

            //Controller injection 
            container.RegisterType<IEventService, EventService>();
            container.RegisterType<IController, EventsController>();

            //View injection 
            container.RegisterInstance<IMessageService>(new MessageService
            {
                Message = "You are welcome to our Web Camps Training Kit!",
                ImageUrl = ""
            });
            container.RegisterType<IViewPageActivator, CustomViewPageActivator>(new InjectionConstructor(container));
            
            //Filter Injection 
            container.RegisterInstance<IFilterProvider>("FilterProvider", new FilterProvider(container));
            container.RegisterInstance<IActionFilter>("LogActionFilter", new TraceActionFilter());

            RegisterTypes(container);

            return container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {

        }
    }
}