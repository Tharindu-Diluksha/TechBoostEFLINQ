using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TechBoostEFLINQ
{
    //[Table("blog")]
    public class Blog
    {
        public int BlogId { get; set; }
        public string Link { get; set; }
        public string BlobName { get; set; }

        public BlogImage BlogImage { get; set; }
        public List<Post> Posts { get; set; }

        [NotMapped]
        public DateTime LoadedFromDatabase { get; set; }
    }
}
