using Homework_26_05.Models;
using Microsoft.EntityFrameworkCore;

namespace Homework_26_05.DAL;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Aim> AimComponents { get; set; }
}