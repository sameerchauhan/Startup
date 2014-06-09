using System.Data.Entity;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Repository;
using Repository.EF;
using Unity.WebApi;

namespace Web.Services
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<DbContext, AdventureWorks2008R2Entities>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }

   
}