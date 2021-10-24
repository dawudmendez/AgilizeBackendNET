using Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Context
{
    public class MySQLDBContext : DbContext
    {

        //public MySQLDBContext() { }
        public MySQLDBContext(DbContextOptions<MySQLDBContext> options) : base(options) {}

        public DbSet<Backlog> Backlogs { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Relationship> Relationships { get; set; }
        public DbSet<Sprint> Sprints { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WorkItem> WorkItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Relationship>().HasOne(re => re.MainItem).WithMany(wi => wi.RelationshipsSource).HasForeignKey(re => re.MainItemId);
            modelBuilder.Entity<Relationship>().HasOne(re => re.RelatedItem).WithMany(wi => wi.RelationshipsDestination).HasForeignKey(re => re.RelatedItemId);

        }

    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MySQLDBContext>
    {
        public MySQLDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                          .AddJsonFile(@Directory.GetCurrentDirectory() + "/../AgilizeBackend/appsettings.json").Build();

            var builder = new DbContextOptionsBuilder<MySQLDBContext>();

            var connectionString = configuration.GetConnectionString("MySQLDbConnection");

            builder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            return new MySQLDBContext(builder.Options);
        }
    }
}
