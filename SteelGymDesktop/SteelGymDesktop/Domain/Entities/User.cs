
using System;

namespace SteelGymDesktop.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; } 
        public string Name { get; set; }
        public string LastName { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int? Number { get; set; }
        public string Complement { get; set; }
        public string Neighborhood { get; set; }
        public bool Active { get; set; }
        public string City { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUserId { get; set; }
        public int CreateUserId { get; set; }
    }
}
