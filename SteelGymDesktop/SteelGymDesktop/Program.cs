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

        private static IStudentAppService _studentAppService;
        private static IStudentService _studentService;
        private static IStudentRepository _studentRepository;

        private static IMovimentationAppService _movimentationAppService;
        private static IMovimentationService _movimentationService;
        private static IMovimentationRepository _movimentationRepository;

        [STAThread]
        static void Main()
        {
            //DependencyResolver.SetResolver(SimpleInjectiorController.RegisterServices());
            // 1 - user
            _userRepository = new UserRepository();
            _userService = new UserService(_userRepository);
            _userAppService = new UserAppService(_userService);
            // 2 student
            _studentRepository = new StudentRepository();
            _studentService = new StudentService(_studentRepository);
            _studentAppService = new StudentAppService(_studentService);
            // 3 - movimentation
            _movimentationRepository = new MovimentationRepository();
            _movimentationService = new MovimentationService(_movimentationRepository);
            _movimentationAppService = new MovimentationAppService(_movimentationService);
            //
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            View.Login l = new View.Login();
            if (l.ShowDialog() == DialogResult.OK)
                Application.Run(new View.Principal(_userAppService, _studentAppService, _movimentationAppService));
        }
    }
}
