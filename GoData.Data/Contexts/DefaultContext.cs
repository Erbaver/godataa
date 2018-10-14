using GoData.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoData.Data.Contexts
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions<DefaultContext> _options) : base(_options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<DataForm> DataForms { get; set; }

        public DbSet<FormTemplate> FormTemplates { get; set; }

        public DbSet<Organization> Organizations { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Unit> Units { get; set; }
    }
}
