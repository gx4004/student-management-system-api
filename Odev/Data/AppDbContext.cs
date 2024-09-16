using Microsoft.EntityFrameworkCore;
using Odev.Data.Entity;

namespace Odev.Data;


public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options  ) : base(options)
    {
        
    }
    
    public DbSet<StudentEntity> StudentEntities { get; set; }
}