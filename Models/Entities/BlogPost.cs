using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_1001_EF_Primer.Web_1001_EF_Primer.Models.Entities
{
    public class BlogPost
    {
        [Key]
        [DataType(DataType.Url)]
        public string Url { get; set; }
        public string Title { get; set; }
        
        [ForeignKey("Author")]
        [DataType(DataType.Email)]
        public string AuthorEmail { get; set; }

        public PostAuthor Author { get; set; }

        [Display(Name = "Published")]
        [DisplayFormat(DataFormatString = "{0:MMMM/dd/yyyy}")]
        public DateTime PublicationDate { get; set; }
        public string EditorsNote { get; set; }
        public string Content { get; set; }
        List<Comment> Comments { get; set; }
    }
}