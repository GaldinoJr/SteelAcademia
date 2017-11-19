using SimpleInjector;
using SteelGymDesktop.Applications;
using SteelGymDesktop.Applications.Interfaces;
using SteelGymDesktop.Domain.Interfaces;
using SteelGymDesktop.Domain.Services;
using SteelGymDesktop.Infrastructure.Repository;

namespace SteelGymDesktop
{
    public static class SimpleInjectiorController
    {
        public static Container RegisterServices()
        {
            var container = new Container();

            container.Register<IUserAppService, UserAppService>();
            container.Register<IUserService, UserService>();
            container.Register<IUserRepository, UserRepository>();

            container.Verify();
            return container;
        }
    }
}
