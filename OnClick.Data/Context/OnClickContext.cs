using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnClick.Data.Models;

namespace OnClick.Data.Context
{
    public class OnClickContext : IdentityDbContext
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

            modelBuilder.Entity<User>()
            .HasOne(t => t.ApplicationUser)
            .WithOne(u => u.User)
            .HasForeignKey<User>(t => t.ApplicationUserId);

        }
    }
}
