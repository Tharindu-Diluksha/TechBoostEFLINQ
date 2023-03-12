﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechBoostEFLINQ;

namespace TechBoostEFLINQ.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220426122548_RenameBlobUrl")]
    partial class RenameBlobUrl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TechBoostEFLINQ.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlobName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BlogId");

                    b.HasIndex("BlobName")
                        .IsUnique()
                        .HasFilter("[BlobName] IS NOT NULL");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("TechBoostEFLINQ.BlogImage", b =>
                {
                    b.Property<int>("BlogImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<string>("Caption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("BlogImageId");

                    b.HasIndex("BlogId")
                        .IsUnique();

                    b.ToTable("BlogImages");
                });

            modelBuilder.Entity("TechBoostEFLINQ.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PostId");

                    b.HasIndex("BlogId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("TechBoostEFLINQ.PostTag", b =>
                {
                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.Property<string>("TagId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PostId", "TagId");

                    b.HasIndex("TagId1");

                    b.ToTable("PostTags");
                });

            modelBuilder.Entity("TechBoostEFLINQ.Tag", b =>
                {
                    b.Property<string>("TagId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TagName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("TechBoostEFLINQ.BlogImage", b =>
                {
                    b.HasOne("TechBoostEFLINQ.Blog", "Blog")
                        .WithOne("BlogImage")
                        .HasForeignKey("TechBoostEFLINQ.BlogImage", "BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("TechBoostEFLINQ.Post", b =>
                {
                    b.HasOne("TechBoostEFLINQ.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("TechBoostEFLINQ.PostTag", b =>
                {
                    b.HasOne("TechBoostEFLINQ.Post", "Post")
                        .WithMany("PostTags")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechBoostEFLINQ.Tag", "Tag")
                        .WithMany("PostTags")
                        .HasForeignKey("TagId1");

                    b.Navigation("Post");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("TechBoostEFLINQ.Blog", b =>
                {
                    b.Navigation("BlogImage");

                    b.Navigation("Posts");
                });

            modelBuilder.Entity("TechBoostEFLINQ.Post", b =>
                {
                    b.Navigation("PostTags");
                });

            modelBuilder.Entity("TechBoostEFLINQ.Tag", b =>
                {
                    b.Navigation("PostTags");
                });
#pragma warning restore 612, 618
        }
    }
}