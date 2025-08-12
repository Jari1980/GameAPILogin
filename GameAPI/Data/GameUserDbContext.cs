using GameAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameAPI.Data
{
    public class GameUserDbContext(DbContextOptions<GameUserDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
    }
}
