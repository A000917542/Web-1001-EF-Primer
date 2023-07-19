using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_1001_EF_Primer.Web_1001_EF_Primer.Models.Entities
{
    public class Comment
    {
        public string Author { get; set; }
        public DateTime CommentDate { get; set; }
        public string Text { get; set; }
        
        [ForeignKey("Post")]
        public string BlogUrl { get; set; }
        public BlogPost Post { get; set; }
    }
}
