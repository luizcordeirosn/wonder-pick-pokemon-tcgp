using Microsoft.EntityFrameworkCore;
using wonder_pick_pokemon_tcgp.src.entities;

namespace wonder_pick_pokemon_tcgp.src.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<WonderPick> wonderPicks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (!string.IsNullOrEmpty(tableName))
                {
                    entityType.SetTableName(ToSnakeCase(tableName));
                }

                foreach (var property in entityType.GetProperties())
                {
                    if (!string.IsNullOrEmpty(property.Name))
                    {
                        property.SetColumnName(ToSnakeCase(property.Name));
                    }
                }
            }

            base.OnModelCreating(modelBuilder);
        }

        private static string ToSnakeCase(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return string.Concat(input
                .Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString().ToLower() : x.ToString().ToLower()));
        }
    }
}
