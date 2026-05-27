using Microsoft.EntityFrameworkCore;
using Task_10_Microservices.Models;

namespace Task_10_Microservices.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
}