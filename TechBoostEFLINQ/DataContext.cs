using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TechBoostEFLINQ
{
    public class DataContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<BlogImage> BlogImages { get; set; }

        public DbSet<PostTag> PostTags { get; set; }

        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Blog>()
            .HasIndex(b => b.BlobName)
            .IsUnique();

            modelBuilder.Entity<PostTag>()
            .HasKey(t => new { t.PostId, t.TagId });

            //modelBuilder
            //.Entity<Post>()
            //.HasMany(p => p.Tags)
            //.WithMany(p => p.Posts)
            //.UsingEntity(j => j.ToTable("PostTags"));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=techboost;User ID=sa;Password=Tharindu@123;Trusted_Connection=True;");
    }
}
