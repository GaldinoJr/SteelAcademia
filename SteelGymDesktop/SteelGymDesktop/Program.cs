using SteelGymDesktop.Applications;
using SteelGymDesktop.Applications.Interfaces;
using SteelGymDesktop.Domain.Interfaces;
using SteelGymDesktop.Domain.Services;
using SteelGymDesktop.Infrastructure.DataAccess;
using SteelGymDesktop.Infrastructure.Repository;
using System;
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

        public static SessionUser SessionUser { get; set; }
        public static DbConnection Context { get; set; }

        private static IMovimentationAppService _movimentationAppService;
        private static IMovimentationService _movimentationService;
        private static IMovimentationRepository _movimentationRepository;


        private static IPaymentAppService _paymentAppService;
        private static IPaymentService _paymentService;
        private static IPaymentRepository _paymentRepository;

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
            // 4 - payment
            _paymentRepository = new PaymentRepository();
            _paymentService = new PaymentService(_paymentRepository);
            _paymentAppService = new PaymentAppService(_paymentService);

            //
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SessionUser = new SessionUser();
            Context = new DbConnection();

            View.Login l = new View.Login(_userAppService);
            if (l.ShowDialog() == DialogResult.OK)
                Application.Run(new View.Principal(_userAppService, _studentAppService, _movimentationAppService, _paymentAppService));
        }
    }
}
