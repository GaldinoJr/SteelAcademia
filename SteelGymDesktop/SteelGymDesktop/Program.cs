using SteelGymDesktop.Applications;
using SteelGymDesktop.Applications.Interfaces;
using SteelGymDesktop.Domain.Interfaces;
using SteelGymDesktop.Domain.Services;
using SteelGymDesktop.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Windows.Forms;

namespace SteelGymDesktop
{
    static class Program
    {
        private static IUserAppService _userAppService;
        private static IUserService _userService;
        private static IUserRepository _userRepository;

        [STAThread]
        static void Main()
        {
            //DependencyResolver.SetResolver(SimpleInjectiorController.RegisterServices());

            _userRepository = new UserRepository();
            _userService = new UserService(_userRepository);
            _userAppService = new UserAppService(_userService);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            View.Login l = new View.Login();
            if (l.ShowDialog() == DialogResult.OK)
                Application.Run(new View.Principal(_userAppService));
        }
    }
}
