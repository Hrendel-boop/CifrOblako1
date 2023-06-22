using CifrOblako1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CifrOblako1.AppDb
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

        public DbSet<Product> Product { get; set; }

        public DbSet<AppUser> AppUser { get; set; }

        public DbSet<Orders> Orders { get; set; }
    }
}
