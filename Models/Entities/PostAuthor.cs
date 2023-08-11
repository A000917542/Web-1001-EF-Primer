using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Web_1001_EF_Primer.Web_1001_EF_Primer.Data.Config;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Web_1001_EF_Primer.Web_1001_EF_Primer.Models.Entities
{
    [EntityTypeConfiguration(typeof(PostAuthorConfig))]
    public class PostAuthor
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Uri{ get; set; }

        public ICollection<BlogPost> BlogPosts { get; set; }
    }
}