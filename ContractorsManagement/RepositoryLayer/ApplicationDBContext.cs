using DomainLayer.Entites;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class ApplicationDBContext : IdentityDbContext<ApplicationUsers,ApplicationRoles,string>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUsers>(entity =>
            {
                entity.ToTable(name: "Users_Tbl");
                entity.Property(e => e.Id).HasColumnName("UserId");
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });
            builder.Entity<ApplicationRoles>(entity =>
            {
                entity.ToTable(name: "Roles_Tbl");
            });
        }
    }
}
