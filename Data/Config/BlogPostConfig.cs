namespace Web_1001_EF_Primer.Web_1001_EF_Primer.Data.Config
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Web_1001_EF_Primer.Models.Entities;

    public class BlogPostConfig : IEntityTypeConfiguration<BlogPost>
    {
        public void Configure(EntityTypeBuilder<BlogPost> builder)
        {
            builder
                .HasKey(entity => entity.Url)
                .HasName("PK_BlogPost");

            builder
                .HasMany(entity => entity.Comments)
                .WithOne(entity => entity.Post)
                .HasForeignKey(entity => entity.BlogUrl)
                .HasPrincipalKey(entity => entity.Url);
        }
    }
}