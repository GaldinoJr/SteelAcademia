using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;

namespace SteelGymDesktop.Domain.Entities
{
    [Table(Name = "User")]
    public class User
    {
        [Column(Name = "UserId", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int UserId { get; set; }

        [Column(Name = "Name", DbType = "VARCHAR")]
        public string Name { get; set; }

        [Column(Name = "LastName", DbType = "VARCHAR")]
        public string LastName { get; set; }

        [Column(Name = "RG", DbType = "VARCHAR")]
        public string RG { get; set; }

        [Column(Name = "CPF", DbType = "VARCHAR")]
        public string CPF { get; set; }

        [Column(Name = "Email", DbType = "VARCHAR")]
        public string Email { get; set; }

        [Column(Name = "Address", DbType = "VARCHAR")]
        public string Address { get; set; }

        [Column(Name = "Number", DbType = "INTEGER")]
        public int? Number { get; set; }

        [Column(Name = "Complement", DbType = "VARCHAR")]
        public string Complement { get; set; }

        [Column(Name = "Neighborhood", DbType = "VARCHAR")]
        public string Neighborhood { get; set; }

        [Column(Name = "Active", DbType = "INTEGER")]
        public int Active { get; set; }

        [Column(Name = "City", DbType = "VARCHAR")]
        public string City { get; set; }

        [Column(Name = "UF", DbType = "VARCHAR")]
        public string UF { get; set; }

        [Column(Name = "CEP", DbType = "VARCHAR")]
        public string CEP { get; set; }

        [Column(Name = "Phone1", DbType = "VARCHAR")]
        public string Phone1 { get; set; }

        [Column(Name = "Phone2", DbType = "VARCHAR")]
        public string Phone2 { get; set; }

        [Column(Name = "UserName", DbType = "VARCHAR")]
        public string UserName { get; set; }

        [Column(Name = "Password", DbType = "VARCHAR")]
        public string Password { get; set; }

        [Column(Name = "UpdateDate", DbType = "VARCHAR")]
        public string UpdateDate { get; set; }

        [Column(Name = "CreateDate", DbType = "VARCHAR")]
        public string CreateDate { get; set; }

        [Column(Name = "UpdateUserId", DbType = "INTEGER")]
        public int? UpdateUserId { get; set; }

        [Column(Name = "CreateUserId", DbType = "INTEGER")]
        public int CreateUserId { get; set; }

        [Column(Name = "IsAdmin", DbType = "INTEGER")]
        public int IsAdmin { get; set; }

        [Column(Name = "CanAccessFinancial", DbType = "INTEGER")]
        public int CanAccessFinancial { get; set; }

        [Column(Name = "FirstLogin", DbType = "INTEGER")]
        public int FirstLogin { get; set; }
    }
}
