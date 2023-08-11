using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Web_1001_EF_Primer.Web_1001_EF_Primer.Data.Config;
using Microsoft.EntityFrameworkCore;

namespace Web_1001_EF_Primer.Web_1001_EF_Primer.Models.Entities
{
    [EntityTypeConfiguration(typeof(CommentConfig))]
    public class Comment
    {
        [DataType(DataType.EmailAddress)]
        public string Author { get; set; }
        public DateTime CommentDate { get; set; }
        public string BlogUrl { get; set; }

        [Required]
        public string Text { get; set; }
        
        public BlogPost Post { get; set; }
    }
}
