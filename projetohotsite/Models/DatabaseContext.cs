using Microsoft.EntityFrameworkCore;

namespace Hotsite.Models
{
    public class DatabaseContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;DataBase=interesse;Uid=root;Pwd=admin;");
        }

        public DbSet<Interesse> Interesses { get; set; }

    }
}