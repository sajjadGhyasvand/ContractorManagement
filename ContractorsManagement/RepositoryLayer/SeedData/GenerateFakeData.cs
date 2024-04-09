using DomainLayer.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.SeedData
{
    public class GenerateFakeData
    {
        public static async Task SeedDataAsync(ApplicationDBContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if (!await context.Users.AnyAsync())
                {
                    var users = ApplicationUser();
                    await context.Users.AddRangeAsync(users);
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<GenerateFakeData>();
                logger.LogError(ex, "Error in SeedData");
            }
        }
        private static List<ApplicationUsers> ApplicationUser()
        {
            var users = new List<ApplicationUsers>()
            {
                new()
                {
                    FirstName = "sajjad",
                    LastName = "Ghias",
                    PersonalCode = "0123456789",
                    NationalCode = "4310922465",
                    Address = "Qazvin, Qaazvin",
                    BirthDate = DateTime.ParseExact("02/02/1373","dd/MM/yyyy",null),
                    Gender = DomainLayer.Enum.Gender.Male,
                    ImagePath = "",
                    SignaturePath = "",
                    Email = "Saj@saj.com",
                    PhoneNumber = "09938011131",
                    UserName = "sajjad"
                },
            };
            return users;

        }
    }
}
