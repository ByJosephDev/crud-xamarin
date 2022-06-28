using Microsoft.EntityFrameworkCore;
using CRUDSCHOOL.Models;

namespace CRUDSCHOOL.DataContext
{
    public class AppDbContext: DbContext
    {

        string DbPath = string.Empty;


        public DbSet<School> Schools { get; set; }


        public AppDbContext(string dbPath)
        {
            this.DbPath = dbPath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DbPath}");
        }

    }
}

