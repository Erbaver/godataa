using GoData.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoData.Data.Contexts
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions<DefaultContext> _options) : base(_options)
        {

        }

        public DbSet<DataForm> DataForms { get; set; }

        public DbSet<FormTemplate> FormTemplates { get; set; }

        public DbSet<Organization> Organizations { get; set; }

        public DbSet<User> OrganizationMembers { get; set; }
    }
}
