using System.Web.Http;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using WebApi_demo.Repository;

namespace WebApi_demo
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IUserRepository, UserRepository>();//same type to add more one 
            //unity ke liy
            //install webapi.owin
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);

        }
    }
}