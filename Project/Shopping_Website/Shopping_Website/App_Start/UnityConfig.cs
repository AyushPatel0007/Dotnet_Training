using Shopping_Website.IRepository;
using Shopping_Website.Repository;
using System.Web.Http;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Shopping_Website
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container herex`

            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<ICartRepository, CartRepository>();

            
            //install webapi.owin
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}