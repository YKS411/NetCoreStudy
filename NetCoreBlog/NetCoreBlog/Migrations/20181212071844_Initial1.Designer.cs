﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetCoreBlog.Models;

namespace NetCoreBlog.Migrations
{
    [DbContext(typeof(NetCoreBlogContext))]
    [Migration("20181212071844_Initial1")]
    partial class Initial1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NetCoreBlog.Models.Article", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryID");

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Excerpt")
                        .HasMaxLength(200);

                    b.Property<string>("Img");

                    b.Property<DateTime>("ModifiedTime");

                    b.Property<int?>("RecommendID");

                    b.Property<string>("Title")
                        .HasMaxLength(70);

                    b.Property<Guid>("UserInfoID");

                    b.Property<long>("Views");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID")
                        .IsUnique()
                        .HasFilter("[CategoryID] IS NOT NULL");

                    b.HasIndex("RecommendID")
                        .IsUnique()
                        .HasFilter("[RecommendID] IS NOT NULL");

                    b.HasIndex("UserInfoID");

                    b.ToTable("Article");
                });

            modelBuilder.Entity("NetCoreBlog.Models.Banner", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Img");

                    b.Property<bool>("Is_active");

                    b.Property<string>("Link_url")
                        .HasMaxLength(100);

                    b.Property<string>("Text_info")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("Banner");
                });

            modelBuilder.Entity("NetCoreBlog.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Index")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("NetCoreBlog.Models.Comment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArticleID");

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<Guid>("UserInfoID");

                    b.HasKey("ID");

                    b.HasIndex("ArticleID");

                    b.HasIndex("UserInfoID");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("NetCoreBlog.Models.Link", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(20);

                    b.HasKey("ID");

                    b.ToTable("Link");
                });

            modelBuilder.Entity("NetCoreBlog.Models.Recommend", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.ToTable("Recommend");
                });

            modelBuilder.Entity("NetCoreBlog.Models.Tag", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("NetCoreBlog.Models.TagRelateArticle", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArticleID");

                    b.Property<int>("TagID");

                    b.HasKey("ID");

                    b.HasIndex("ArticleID");

                    b.HasIndex("TagID");

                    b.ToTable("TagRelateArticle");
                });

            modelBuilder.Entity("NetCoreBlog.Models.UserInfo", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("UserImage");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("UserType");

                    b.HasKey("ID");

                    b.ToTable("UserInfo");
                });

            modelBuilder.Entity("NetCoreBlog.Models.Article", b =>
                {
                    b.HasOne("NetCoreBlog.Models.Category", "Category")
                        .WithOne("Article")
                        .HasForeignKey("NetCoreBlog.Models.Article", "CategoryID");

                    b.HasOne("NetCoreBlog.Models.Recommend", "Recommend")
                        .WithOne("Article")
                        .HasForeignKey("NetCoreBlog.Models.Article", "RecommendID");

                    b.HasOne("NetCoreBlog.Models.UserInfo", "UserInfo")
                        .WithMany("Articles")
                        .HasForeignKey("UserInfoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NetCoreBlog.Models.Comment", b =>
                {
                    b.HasOne("NetCoreBlog.Models.Article", "Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("NetCoreBlog.Models.UserInfo", "UserInfo")
                        .WithMany("Comments")
                        .HasForeignKey("UserInfoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NetCoreBlog.Models.TagRelateArticle", b =>
                {
                    b.HasOne("NetCoreBlog.Models.Article", "Article")
                        .WithMany("TagRelateArticles")
                        .HasForeignKey("ArticleID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NetCoreBlog.Models.Tag", "Tag")
                        .WithMany("TagRelateArticles")
                        .HasForeignKey("TagID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
