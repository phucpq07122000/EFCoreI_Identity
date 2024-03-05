using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp1.Models;

namespace WebApp1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Student>? Students { get; set; }    
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("dbo");
            builder.Entity<IdentityUser>(
                entity =>
                {
                    entity.ToTable(name: "User");
                });
            builder.Entity<IdentityRole>(
                entity => { entity.ToTable(name: "Role"); });

            builder.Entity<IdentityUserRole<string>>(
                entity =>
                {
                    entity.ToTable(name: "UserRoles");
                });
            builder.Entity<IdentityUserClaim<string>>(
                 entity =>
                   {
                 entity.ToTable(name: "UserClaims");
                  });

            builder.Entity<IdentityUserLogin<string>>(
               entity =>
               {
                   entity.ToTable(name: "UserLogins");
               });
            builder.Entity<IdentityRoleClaim<string>>(
                entity =>
                {
                    entity.ToTable(name: "RoelClaims");
                });
            builder.Entity<IdentityUserToken<string>>(
               entity =>
               {
                   entity.ToTable(name: "UserTokens");
               });
        }
    }
}