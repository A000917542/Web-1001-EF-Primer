namespace Web_1001_EF_Primer.Web_1001_EF_Primer.Data.Config
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Web_1001_EF_Primer.Models.Entities;

    public class PostAuthorConfig : IEntityTypeConfiguration<PostAuthor>
    {
        public void Configure(EntityTypeBuilder<PostAuthor> builder)
        {
            builder
                .HasKey(entity => entity.Email)
                .HasName("PK_PostAuthor");

            builder
                .HasMany(entity => entity.BlogPosts)
                .WithOne(entity => entity.Author)
                .HasForeignKey(entity => entity.AuthorEmail)
                .HasPrincipalKey(entity => entity.Email);
        }
    }
}