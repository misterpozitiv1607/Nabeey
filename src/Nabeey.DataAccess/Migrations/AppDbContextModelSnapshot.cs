﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nabeey.DataAccess.Contexts;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Nabeey.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Nabeey.Domain.Entities.Answers.Answer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long?>("AssetId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Articles.Article", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("ContentId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ContentId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Articles.UserArticle", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long>("ArticleId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("UserId", "ArticleId");

                    b.HasIndex("ArticleId");

                    b.ToTable("UserArticles");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Assets.Asset", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FileName")
                        .HasColumnType("text");

                    b.Property<string>("FilePath")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Books.Book", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long?>("AssetId")
                        .HasColumnType("bigint");

                    b.Property<string>("Author")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Contents.ContentBook", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("BookId")
                        .HasColumnType("bigint");

                    b.Property<long>("ContentId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("ContentId");

                    b.ToTable("ContentBooks");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Contexts.Content", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("ContentCategoryId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ContentCategoryId");

                    b.ToTable("Contents");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Contexts.ContentAudio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long?>("AssetId")
                        .HasColumnType("bigint");

                    b.Property<long>("ContentId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("ContentId");

                    b.ToTable("ContentAudios");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Contexts.ContentCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("ContentCategories");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Contexts.ContentImage", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long?>("AssetId")
                        .HasColumnType("bigint");

                    b.Property<long>("ContentId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("ContentId");

                    b.ToTable("ContentImages");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Contexts.ContentVideo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long?>("AssetId")
                        .HasColumnType("bigint");

                    b.Property<long>("ContentId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("ContentId");

                    b.ToTable("ContentVideos");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.QuestionAnswers.QuestionAnswer", b =>
                {
                    b.Property<long>("QuestionId")
                        .HasColumnType("bigint");

                    b.Property<long>("AnswerId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsTrue")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("QuestionId", "AnswerId");

                    b.HasIndex("AnswerId");

                    b.ToTable("QuestionAnswers");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Questions.Question", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long?>("AssetId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.QuizQuestions.QuizQuestion", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<long>("QuestionId")
                        .HasColumnType("bigint");

                    b.Property<long>("QuizId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("QuizId");

                    b.ToTable("QuizQuestions");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Quizzes.Quiz", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("ContentCategoryId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("QuestionCount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ContentCategoryId");

                    b.ToTable("Quizzes");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Quizzes.QuizQuestion", b =>
                {
                    b.Property<long>("QuizId")
                        .HasColumnType("bigint");

                    b.Property<long>("QuestionId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("QuizId", "QuestionId");

                    b.HasIndex("QuestionId");

                    b.ToTable("QuizQuestions");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Users.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long?>("AssetId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserRole")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "imona.kabirova@example.com",
                            FirstName = "Imona",
                            IsDeleted = false,
                            LastName = "Kabirova",
                            PasswordHash = "a",
                            Phone = "9001234567",
                            UserRole = 1
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jamshid.zayniev@example.com",
                            FirstName = "Jamshid",
                            IsDeleted = false,
                            LastName = "Zayniev",
                            PasswordHash = "a",
                            Phone = "9007654321",
                            UserRole = 1
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "anastasiya.tomchuk@example.com",
                            FirstName = "Anastasiya",
                            IsDeleted = false,
                            LastName = "Tomchuk",
                            PasswordHash = "a",
                            Phone = "9009876543",
                            UserRole = 1
                        },
                        new
                        {
                            Id = 4L,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "iskandar.kodirov@example.com",
                            FirstName = "Iskandar",
                            IsDeleted = false,
                            LastName = "Kodirov",
                            PasswordHash = "a",
                            Phone = "9012345678",
                            UserRole = 1
                        },
                        new
                        {
                            Id = 5L,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "nodirshax.allanazarov@example.com",
                            FirstName = "Nodirshax",
                            IsDeleted = false,
                            LastName = "Allanazarov",
                            PasswordHash = "a",
                            Phone = "9012345679",
                            UserRole = 1
                        },
                        new
                        {
                            Id = 7L,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "asilbek.abdurashidov@example.com",
                            FirstName = "Asilbek",
                            IsDeleted = false,
                            LastName = "Abdurashidov",
                            PasswordHash = "a",
                            Phone = "9012345679",
                            UserRole = 1
                        },
                        new
                        {
                            Id = 8L,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jasurbek.ergashev@example.com",
                            FirstName = "Jasurbek",
                            IsDeleted = false,
                            LastName = "Ergashev",
                            PasswordHash = "a",
                            Phone = "9012345680",
                            UserRole = 1
                        },
                        new
                        {
                            Id = 9L,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "takhmina.saidova@example.com",
                            FirstName = "Takhmina",
                            IsDeleted = false,
                            LastName = "Saidova",
                            PasswordHash = "a",
                            Phone = "9012345681",
                            UserRole = 1
                        },
                        new
                        {
                            Id = 10L,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "asadbek.qarshiyev@example.com",
                            FirstName = "Asadbek",
                            IsDeleted = false,
                            LastName = "Qarshiyev",
                            PasswordHash = "a",
                            Phone = "9012345682",
                            UserRole = 1
                        },
                        new
                        {
                            Id = 11L,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "sardor.sohinazarov@example.com",
                            FirstName = "Sardor",
                            IsDeleted = false,
                            LastName = "Sohinazarov",
                            PasswordHash = "a",
                            Phone = "9012345683",
                            UserRole = 1
                        },
                        new
                        {
                            Id = 12L,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "raykhona.isroilova@example.com",
                            FirstName = "Raykhona",
                            IsDeleted = false,
                            LastName = "Isroilova",
                            PasswordHash = "a",
                            Phone = "9012345684",
                            UserRole = 1
                        });
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Answers.Answer", b =>
                {
                    b.HasOne("Nabeey.Domain.Entities.Assets.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId");

                    b.Navigation("Asset");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Articles.Article", b =>
                {
                    b.HasOne("Nabeey.Domain.Entities.Contexts.Content", "Content")
                        .WithMany()
                        .HasForeignKey("ContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Content");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Articles.UserArticle", b =>
                {
                    b.HasOne("Nabeey.Domain.Entities.Articles.Article", "Article")
                        .WithMany("UserArticles")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nabeey.Domain.Entities.Users.User", "User")
                        .WithMany("UserArticles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Books.Book", b =>
                {
                    b.HasOne("Nabeey.Domain.Entities.Assets.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId");

                    b.Navigation("Asset");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Contents.ContentBook", b =>
                {
                    b.HasOne("Nabeey.Domain.Entities.Books.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nabeey.Domain.Entities.Contexts.Content", "Content")
                        .WithMany()
                        .HasForeignKey("ContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Content");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Contexts.Content", b =>
                {
                    b.HasOne("Nabeey.Domain.Entities.Contexts.ContentCategory", "ContentCategory")
                        .WithMany()
                        .HasForeignKey("ContentCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nabeey.Domain.Entities.Contexts.ContentImage", null)
                        .WithOne("Content")
                        .HasForeignKey("Nabeey.Domain.Entities.Contexts.Content", "Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ContentCategory");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Contexts.ContentAudio", b =>
                {
                    b.HasOne("Nabeey.Domain.Entities.Assets.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId");

                    b.HasOne("Nabeey.Domain.Entities.Contexts.Content", "Content")
                        .WithMany()
                        .HasForeignKey("ContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asset");

                    b.Navigation("Content");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Contexts.ContentImage", b =>
                {
                    b.HasOne("Nabeey.Domain.Entities.Assets.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId");

                    b.Navigation("Asset");

                    b.Navigation("Content");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Contexts.ContentVideo", b =>
                {
                    b.HasOne("Nabeey.Domain.Entities.Assets.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId");

                    b.HasOne("Nabeey.Domain.Entities.Contexts.Content", "Content")
                        .WithMany()
                        .HasForeignKey("ContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asset");

                    b.Navigation("Content");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.QuestionAnswers.QuestionAnswer", b =>
                {
                    b.HasOne("Nabeey.Domain.Entities.Answers.Answer", "Answer")
                        .WithMany("QuestionAnswers")
                        .HasForeignKey("AnswerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nabeey.Domain.Entities.Questions.Question", "Question")
                        .WithMany("QuestionAnswers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Answer");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Questions.Question", b =>
                {
                    b.HasOne("Nabeey.Domain.Entities.Assets.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId");

                    b.Navigation("Asset");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.QuizQuestions.QuizQuestion", b =>
                {
                    b.HasOne("Nabeey.Domain.Entities.Questions.Question", "Question")
                        .WithMany("QuizQuestions")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nabeey.Domain.Entities.Quizzes.Quiz", "Quiz")
                        .WithMany("QuizQuestions")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Quizzes.Quiz", b =>
                {
                    b.HasOne("Nabeey.Domain.Entities.Contexts.ContentCategory", "ContentCategory")
                        .WithMany()
                        .HasForeignKey("ContentCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ContentCategory");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Quizzes.QuizQuestion", b =>
                {
                    b.HasOne("Nabeey.Domain.Entities.Questions.Question", "Question")
                        .WithMany("QuizQuestions")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nabeey.Domain.Entities.Quizzes.Quiz", "Quiz")
                        .WithMany()
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Users.User", b =>
                {
                    b.HasOne("Nabeey.Domain.Entities.Assets.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId");

                    b.Navigation("Asset");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Answers.Answer", b =>
                {
                    b.Navigation("QuestionAnswers");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Articles.Article", b =>
                {
                    b.Navigation("UserArticles");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Contexts.ContentImage", b =>
                {
                    b.Navigation("Content")
                        .IsRequired();
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Questions.Question", b =>
                {
                    b.Navigation("QuestionAnswers");

                    b.Navigation("QuizQuestions");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Quizzes.Quiz", b =>
                {
                    b.Navigation("QuizQuestions");
                });

            modelBuilder.Entity("Nabeey.Domain.Entities.Users.User", b =>
                {
                    b.Navigation("UserArticles");
                });
#pragma warning restore 612, 618
        }
    }
}
