using Microsoft.EntityFrameworkCore;
using Web_1001_EF_Primer.Web_1001_EF_Primer.Models.Entities;

namespace Web_1001_EF_Primer.Web_1001_EF_Primer.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>()
                .HasKey(entity => new { entity.Author, entity.CommentDate, entity.BlogUrl })
                .HasName("PK_Comments");
        }

        // public DbSet<BlogPost> Posts { get; set; } = null!;
        public DbSet<BlogPost> Posts { get; set; } = null!;
        public DbSet<Comment> Comments { get; set; } = null!;
    }
}