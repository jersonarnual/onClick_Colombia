using Microsoft.EntityFrameworkCore;
using OnClick.Data.Models;

namespace OnClick.Data.Context
{
    public class OnClickContext : DbContext
    {
        public OnClickContext()
        {

        }
        public OnClickContext(DbContextOptions<OnClickContext> options) : base(options)
        {
        }

        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
