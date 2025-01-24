using Microsoft.EntityFrameworkCore;

namespace rs.Models
{
    public class rsDbContext : DbContext
    {
        public rsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<RegAdmin> AdminReg { get; set; }

        public DbSet<RegUser> UserReg { get; set; }


        
    }

    



}
