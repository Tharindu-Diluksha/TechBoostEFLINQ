using System;
using System.Collections.Generic;
using System.Text;

namespace TechBoostEFLINQ
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; } // Demo Shadow Property by commenting
        public Blog Blog { get; set; }

        public List<PostTag> PostTags { get; set; }

        //public ICollection<Tag> Tags { get; set; }
    }
}
