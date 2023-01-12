using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using web2.Models;

namespace web2.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<UserLogin> UserLogin { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}
