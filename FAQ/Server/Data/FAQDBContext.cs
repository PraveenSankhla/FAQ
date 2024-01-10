using FAQ_App.Server.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace FAQ_App.Server.Data
{
    public class FAQDBContext : DbContext
    {
        public FAQDBContext(DbContextOptions<FAQDBContext> options) : base(options) { }
        public DbSet<FAQEnitity> FAQs { get; set; }
    }
}
