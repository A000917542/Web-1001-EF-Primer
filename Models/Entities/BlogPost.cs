using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Web_1001_EF_Primer.Web_1001_EF_Primer.Data.Config;
using Microsoft.EntityFrameworkCore;

namespace Web_1001_EF_Primer.Web_1001_EF_Primer.Models.Entities
{
    [EntityTypeConfiguration(typeof(BlogPostConfig))]
    public class BlogPost
    {
        [DataType(DataType.Url)]
        public string Url { get; set; }
        public string Title { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string AuthorEmail { get; set; }

        public PostAuthor Author { get; set; }

        [Display(Name = "Published")]
        [DisplayFormat(DataFormatString = "{0:MMMM/dd/yyyy}")]
        public DateTime PublicationDate { get; set; }
        public string EditorsNote { get; set; }
        public string Content { get; set; }
        public List<Comment> Comments { get; set; }
    }
}