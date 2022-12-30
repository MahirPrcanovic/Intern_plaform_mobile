using InternshipPlatform_API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InternshipPlatform_API.Data
{
    public class DataContext : IdentityDbContext<ExtendUser>
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) { }

        public DbSet<Applicant>? Applicants { get; set; }
        public DbSet<Company>? Companies { get; set; }
        public DbSet<Selection>? Selections { get; set; }

    }
}
