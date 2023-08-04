namespace Web_1001_EF_Primer.Web_1001_EF_Primer.Data.Config
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Web_1001_EF_Primer.Models.Entities;

    public class CommentConfig : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder
                .HasKey(entity => new { entity.Author, entity.CommentDate, entity.BlogUrl })
                .HasName("PK_Comments");
            
            builder
                .HasIndex(e => e.CommentDate)
                .HasName("IX_Comment_CommentDate");
        }
    }
}