using FinWebMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace FinWebMvc.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("DataSource=App.db;Cache=Shared");
    }
}
