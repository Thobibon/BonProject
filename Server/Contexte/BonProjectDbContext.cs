using Microsoft.EntityFrameworkCore;
using BonProject.Server.Contexte.Entities;

namespace BonProject.Server.Contexte;

public class BonProjectDbContext : DbContext
{
    public BonProjectDbContext(DbContextOptions<BonProjectDbContext> options)
        : base(options)
    {
    }

    public DbSet<UserEntity> Users { get; set; } = null!;
}