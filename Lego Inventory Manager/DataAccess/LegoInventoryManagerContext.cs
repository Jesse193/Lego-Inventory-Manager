using Microsoft.EntityFrameworkCore;
using LegoInventoryManager.Models;

namespace LegoInventoryManager.DataAccess
{
    public class LegoInventoryManagerContext : DbContext
    {
        public DbSet<Part> Parts { get; set; }
        public DbSet<Set> Sets { get; set; }

        public LegoInventoryManagerContext(DbContextOptions<LegoInventoryManagerContext> options) : base(options)
        {

        }
    }
}