using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using SocialBridge.Main.Models;

namespace SocialBridge.Main.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Ngo> Ngos => Set<Ngo>();
        public DbSet<Company> Companies => Set<Company>();
        public DbSet<Application> Applications => Set<Application>();
        public DbSet<Project> Projects => Set<Project>();
        public DbSet<Grant> Grants => Set<Grant>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Model.SetSnakeCaseNamingConvention();
        }
    }

    public static class SnakeCaseNamingExtensions
    {
        public static IMutableModel SetSnakeCaseNamingConvention(this IMutableModel model)
        {
            foreach (var entityType in model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (!string.IsNullOrWhiteSpace(tableName))
                    // Apply the naming convention to tables
                {
                    entityType.SetTableName(SnakeCase(tableName));
                }

                // Apply the naming convention to columns
                foreach (var property in entityType.GetProperties())
                {
                    property.SetColumnName(SnakeCase(property.GetColumnName()));
                }
            }

            return model;
        }

        private static string SnakeCase(string input)
        {
            // Convert PascalCase to snake_case
            var regex = new Regex(@"(?<=[a-z0-9])[A-Z]");
            return regex.Replace(input, m => "_" + m.Value).ToLower();
        }
    }
}
