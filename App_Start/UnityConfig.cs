using BoutiqueManagement.IRepositories;
using BoutiqueManagement.IServices;
using BoutiqueManagement.Repositories;
using BoutiqueManagement.Services;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace BoutiqueManagement
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IItemRepository, ItemRepository>();
            container.RegisterType<IItemService, ItemService>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}