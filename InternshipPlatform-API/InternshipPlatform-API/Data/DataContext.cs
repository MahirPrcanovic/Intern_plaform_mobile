using InternshipPlatform_API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InternshipPlatform_API.Data
{
    public class DataContext : IdentityDbContext<ExtendUser>
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            string EDITOR_ROLE_ID = "413743e0-asd2–42fe-afbf-59kmccmk72cd6";
            builder.Entity<IdentityRole>().HasData(
             new IdentityRole
             {
                 Name = "Editor",
                 NormalizedName = "EDITOR",
                 Id = EDITOR_ROLE_ID,
                 ConcurrencyStamp = EDITOR_ROLE_ID
             });
            base.OnModelCreating(builder);
        }
        public DbSet<Applicant>? Applicants { get; set; }
        public DbSet<Company>? Companies { get; set; }
        public DbSet<Selection>? Selections { get; set; }

    }
}
