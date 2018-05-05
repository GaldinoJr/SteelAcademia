using SteelGymDesktop.Infrastructure.DataAccess;

namespace SteelGymDesktop
{
    public class SessionUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }
        public bool CanAccessFinancial { get; set; }
    }
}
