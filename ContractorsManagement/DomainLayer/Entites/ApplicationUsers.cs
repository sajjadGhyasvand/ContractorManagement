using DomainLayer.Enum;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entites
{
    public class ApplicationUsers : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalCode { get; set; }
        public string NationalCode  { get; set; }
        public string? Address { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? EmployeeDate { get; set; }
        public Gender Gender { get; set; }
        public string ImagePath { get; set; }
        public string SignaturePath { get; set; }
        public bool IsActive { get; set; }  
    }
}
