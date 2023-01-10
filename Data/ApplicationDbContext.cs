using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Agrifood.Models;

namespace Agrifood.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Agrifood.Models.Employee>? Employees { get; set; }
    public DbSet<Agrifood.Models.Service>? Services { get; set; }
}

