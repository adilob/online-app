using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using web1.Models;

namespace web1.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<UserLogin> UserLogin { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}
