using AspNetMvcBlog.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AspNetMvcBlog.Models.ViewModel
{
    public class PostDatail
    {
        public Post Post { get; set; }
        public int TotalComments { get; set; }

        public IEnumerable<string> GetTags()
        {
            if (String.IsNullOrEmpty(Post.Tags))
            {
                return Enumerable.Empty<string>();
            }

            return Post.Tags.Split(',');
        }
    }
}