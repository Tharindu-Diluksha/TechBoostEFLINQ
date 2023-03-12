using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace TechBoostEFLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tech Boost - 2023");

            using (var context = new DataContext())
            {
                var allBlogs = context.Blogs.ToList();


                var blog = context.Blogs
                    .First(b => b.BlogId == 1);

                var test = context.PostTags.Single(pt => pt.PostId == -1);


                var blogs = context.Blogs
                    .Where(b => b.Link.Contains("dotnet"))
                    .ToList();



                var blogsQuery = from b in context.Blogs
                             where b.Link.Contains("dotnet")
                             select b;

                var result = blogsQuery.ToList();

                var quer = (from b in context.Blogs
                           join p in context.Posts
                           on b.BlogId equals p.BlogId
                           where b.Link.Contains("dotnet")
                           select p).ToList();


                var blogTest1 = context.Blogs.Include(b => b.Posts)
                    .Single(b => b.BlobName == "Tutorial");
                var postTest = blogTest1.Posts;
            }
        }
    }
}
