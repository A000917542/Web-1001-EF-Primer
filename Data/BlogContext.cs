using Microsoft.EntityFrameworkCore;
using Web_1001_EF_Primer.Web_1001_EF_Primer.Models.Entities;

namespace Web_1001_EF_Primer.Web_1001_EF_Primer.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options)
            : base(options)
        { }

        // public DbSet<BlogPost> Posts { get; set; } = null!;
        public DbSet<BlogPost> Posts { get; set; } = null!;
        public DbSet<Comment> Comments { get; set; } = null!;
    }
}