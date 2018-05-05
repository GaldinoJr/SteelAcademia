using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;

namespace SteelGymDesktop.Domain.Entities
{
    [Table(Name = "Student")]
    public class Student
    {
        [Column(Name = "StudentId", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int StudentId { get; set; }

        [Column(Name = "Name", DbType = "VARCHAR")]
        public string Name { get; set; }

        [Column(Name = "CivilStatus", DbType = "VARCHAR")]
        public string CivilStatus { get; set; }

        [Column(Name = "CPF", DbType = "VARCHAR")]
        public string CPF { get; set; }

        [Column(Name = "BirthDate", DbType = "VARCHAR")]
        public string BirthDate { get; set; }

        [Column(Name = "EvaliationDate", DbType = "VARCHAR")]
        public string EvaliationDate { get; set; }

        [Column(Name = "PayDay", DbType = "INTEGER")]
        public int PayDay { get; set; }

        [Column(Name = "EvaluationPeriodicity", DbType = "VARCHAR")]
        public int EvaluationPeriodicity { get; set; }

        [Column(Name = "PaymentAmount", DbType = "NUMERIC")]
        public decimal PaymentAmount { get; set; }

        [Column(Name = "Email", DbType = "VARCHAR")]
        public string Email { get; set; }

        [Column(Name = "Sex", DbType = "VARCHAR")]
        public string Sex { get; set; }

        [Column(Name = "IMC", DbType = "NUMERIC")]
        public decimal IMC { get; set; }

        [Column(Name = "Profession", DbType = "VARCHAR")]
        public string Profession { get; set; }

        [Column(Name = "RG", DbType = "VARCHAR")]
        public string RG { get; set; }

        [Column(Name = "Active", DbType = "INTEGER")]
        public int Active { get; set; }

        [Column(Name = "Address", DbType = "VARCHAR")]
        public string Address { get; set; }

        [Column(Name = "Number", DbType = "INTEGER")]
        public int? Number { get; set; }

        [Column(Name = "Neighborhood", DbType = "VARCHAR")]
        public string Neighborhood { get; set; }

        [Column(Name = "Complement", DbType = "VARCHAR")]
        public string Complement { get; set; }

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

        [Column(Name = "RelativeName1", DbType = "VARCHAR")]
        public string RelativeName1 { get; set; }

        [Column(Name = "RelativeName2", DbType = "VARCHAR")]
        public string RelativeName2 { get; set; }

        [Column(Name = "RelativeName3", DbType = "VARCHAR")]
        public string RelativeName3 { get; set; }

        [Column(Name = "RelativeDegree1", DbType = "VARCHAR")]
        public string RelativeDegree1 { get; set; }

        [Column(Name = "RelativeDegree2", DbType = "VARCHAR")]
        public string RelativeDegree2 { get; set; }

        [Column(Name = "RelativeDegree3", DbType = "VARCHAR")]
        public string RelativeDegree3 { get; set; }

        [Column(Name = "ResponsibleName", DbType = "VARCHAR")]
        public string ResponsibleName { get; set; }

        [Column(Name = "ResponsibleDegree", DbType = "VARCHAR")]
        public string ResponsibleDegree { get; set; }

        [Column(Name = "ResponsibleAddress", DbType = "VARCHAR")]
        public string ResponsibleAddress { get; set; }

        [Column(Name = "ResponsibleNeighborhood", DbType = "VARCHAR")]
        public string ResponsibleNeighborhood { get; set; }

        [Column(Name = "ResponsibleNumber", DbType = "INTEGER")]
        public int? ResponsibleNumber { get; set; }

        [Column(Name = "ResponsibleComplement", DbType = "VARCHAR")]
        public string ResponsibleComplement { get; set; }

        [Column(Name = "ResponsibleCity", DbType = "VARCHAR")]
        public string ResponsibleCity { get; set; }

        [Column(Name = "ResponsibleUF", DbType = "VARCHAR")]
        public string ResponsibleUF { get; set; }

        [Column(Name = "ResponsibleCEP", DbType = "VARCHAR")]
        public string ResponsibleCEP { get; set; }

        [Column(Name = "ResponsiblePhone1", DbType = "VARCHAR")]
        public string ResponsiblePhone1 { get; set; }

        [Column(Name = "ResponsiblePhone2", DbType = "VARCHAR")]
        public string ResponsiblePhone2 { get; set; }

        [Column(Name = "UpdateDate", DbType = "VARCHAR")]
        public string UpdateDate { get; set; }

        [Column(Name = "CreateDate", DbType = "VARCHAR")]
        public string CreateDate { get; set; }

        [Column(Name = "UpdateUserId", DbType = "INTEGER")]
        public int? UpdateUserId { get; set; }

        [Column(Name = "CreateUserId", DbType = "INTEGER")]
        public int CreateUserId { get; set; }
    }
}