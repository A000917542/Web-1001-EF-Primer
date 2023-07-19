using System.ComponentModel.DataAnnotations;

namespace Web_1001_EF_Primer.Web_1001_EF_Primer.Models.Entities
{
    public class BlogPost
    {
        [Key]
        public string Url { get; set; }
        public string Title { get; set; }
        public DateTime PublicationDate { get; set; }
        public string EditorsNote { get; set; }
        public string Content { get; set; }
        List<Comment> Comments { get; set; }
    }
}