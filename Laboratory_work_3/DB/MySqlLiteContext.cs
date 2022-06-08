using Microsoft.EntityFrameworkCore;


namespace Laboratory_work_3.DB
{
    public class MySqlLiteContext : DbContext
    {
        public MySqlLiteContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=MySqlLite.db");
        }
        public DbSet<Model.Gamer> Gamers { get; set; }
        public DbSet<Model.Computer> Computers { get; set; }
        public DbSet<Model.Work> Works { get; set; }
    }
}
