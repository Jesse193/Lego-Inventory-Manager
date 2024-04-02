using Microsoft.EntityFrameworkCore;
using LegoInventoryManager.Models;

namespace LegoInventoryManager.DataAccess
{
    public class LegoInventoryManagerContext : DbContext
    {
        public LegoInventoryManagerContext(DbContextOptions<LegoInventoryManagerContext> options) : base(options)
        {

        }
    }
}