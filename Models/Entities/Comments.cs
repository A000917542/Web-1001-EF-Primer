using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_1001_EF_Primer.Web_1001_EF_Primer.Models.Entities
{
    public class Comment
    {
        [Key]
        public string Author { get; set; }
        public DateTime CommentDate { get; set; }
        public string Text { get; set; }
        public BlogPost Post { get; set; }
    }
}
