using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc4;
using Web.Service;

namespace Web.UI
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
      var container = new UnityContainer();

      container.RegisterType<IDashBoardService, DashBoardService>();
      container.RegisterType<IEmployeeService, EmployeeService>();

      RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
    
    }
  }
}