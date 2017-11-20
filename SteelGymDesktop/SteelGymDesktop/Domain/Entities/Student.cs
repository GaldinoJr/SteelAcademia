using System;

namespace SteelGymDesktop.Domain.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string CivilStatus { get; set; }
        public string CPF { get; set; }
        public DateTime? BirthDate { get; set; } 
        public DateTime? PayDay { get; set; }
        public string Email { get; set; }
        public string Sex { get; set; }
        public decimal IMC { get; set; }
        public string Profession { get; set; }
        public string RG { get; set; }
        public bool Active { get; set; }
        public string Address { get; set; }
        public int? Number { get; set; }
        public string Neighborhood { get; set; }
        public string Complement { get; set; }
        public string City { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string RelativeName1 { get; set; }
        public string RelativeName2 { get; set; }
        public string RelativeName3 { get; set; }
        public string RelativeDegree1 { get; set; }
        public string RelativeDegree2 { get; set; }
        public string RelativeDegree3 { get; set; }
        public string ResponsibleName { get; set; }
        public string ResponsibleDegree { get; set; }
        public string ResponsibleAddress { get; set; }
        public string ResponsibleNeighborhood { get; set; }
        public int? ResponsibleNumber { get; set; }
        public string ResponsibleComplement { get; set; }
        public string ResponsibleCity { get; set; }
        public string ResponsibleUF { get; set; }
        public string ResponsibleCEP { get; set; }
        public string ResponsiblePhone1 { get; set; }
        public string ResponsiblePhone2 { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUserId { get; set; }
        public int CreateUserId { get; set; }
    }
}
