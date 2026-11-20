using Microsoft.EntityFrameworkCore;
using TryToLearnNetCore.LearnOn30Days.Day8_ORM.Entity;

namespace TryToLearnNetCore.LearnOn30Days.Day8_ORM
{
    public class AppDBContextDay8 : DbContext
    {
        public AppDBContextDay8(DbContextOptions<AppDBContextDay8> options) : base(options) { }
        public DbSet<BrandDay8> Brand { get; set; }
        public DbSet<CarDay8> carinfo { get; set; }
    }
}
