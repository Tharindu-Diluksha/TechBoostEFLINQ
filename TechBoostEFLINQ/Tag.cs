using System;
using System.Collections.Generic;
using System.Text;

namespace TechBoostEFLINQ
{
    public class Tag
    {
        public string TagId { get; set; }

        public string  TagName { get; set; }

        public List<PostTag> PostTags { get; set; }
    }
}
