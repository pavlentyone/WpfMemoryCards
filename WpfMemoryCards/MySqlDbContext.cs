using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel;

namespace WpfMemoryCards
{
    // public is important to this class!
    public class MySqlDbContext : DbContext
    {
        /// <summary>
        /// Tables
        /// </summary>
        // Cards table
        public DbSet<Card> Cards { get; set; }
        // Pictures table
        public DbSet<Picture> Pictures { get; set; }
        // Tags table
        public DbSet<Tag> Tags { get; set; }

        //public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Constructors, methods
        /// </summary>

        // Create database if it's not created
        public MySqlDbContext()
        {
            Database.EnsureCreated();
        }

        // Does not work
        public MySqlDbContext(DbContextOptions<MySqlDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        // Connection to the database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            // установка пути к текущему каталогу
            builder.SetBasePath(Directory.GetCurrentDirectory());
            // получаем конфигурацию из файла appsettings.json
            builder.AddJsonFile("appsettings.json");
            // создаем конфигурацию
            var config = builder.Build();
            // получаем строку подключения
            string connectionString = config.GetConnectionString("DefaultConnection");

            optionsBuilder.UseMySql(connectionString);
        }

        // Fluent API. It defines the mapping between classes, their properties/tables and columns
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public void RejectChange(EntityEntry entry)
        {
            switch (entry.State)
            {
                case EntityState.Modified:
                    entry.State = EntityState.Unchanged;
                    break;
                case EntityState.Added:
                    entry.State = EntityState.Detached;
                    break;
                case EntityState.Deleted:
                    entry.Reload();
                    break;
                default: break;
            }
        }

        public void RejectChanges()
        {
            foreach (EntityEntry entry in this.ChangeTracker.Entries())
            {
                RejectChange(entry);
            }
        }
    }
}
