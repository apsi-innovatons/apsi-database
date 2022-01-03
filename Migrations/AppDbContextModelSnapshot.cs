﻿// <auto-generated />
using System;
using Apsi.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Apsi.Database.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Apsi.Database.Entities.Attachment", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("FlieBytes")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("IdeaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdeaId");

                    b.ToTable("Attachments");
                });

            modelBuilder.Entity("Apsi.Database.Entities.Benefit", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdeaId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdeaId");

                    b.ToTable("Benefits");
                });

            modelBuilder.Entity("Apsi.Database.Entities.Cost", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdeaId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("IdeaId");

                    b.ToTable("Costs");
                });

            modelBuilder.Entity("Apsi.Database.Entities.Idea", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Anonymous")
                        .HasColumnType("bit");

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<bool>("Blocked")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Keywords")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("StatusDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Ideas");
                });

            modelBuilder.Entity("Apsi.Database.Entities.Post", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SocialGroupId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("SocialGroupId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Apsi.Database.Entities.PostAnswer", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PostId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PostId");

                    b.ToTable("PostAnswers");
                });

            modelBuilder.Entity("Apsi.Database.Entities.Rating", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int?>("IdeaId")
                        .HasColumnType("int");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("IdeaId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("Apsi.Database.Entities.RatingSetting", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdeaId")
                        .HasColumnType("int");

                    b.Property<int>("UserRole")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("IdeaId");

                    b.ToTable("RatingSettings");
                });

            modelBuilder.Entity("Apsi.Database.Entities.Review", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdeaId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("IdeaId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Apsi.Database.Entities.SocialGroup", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SocialGroups");
                });

            modelBuilder.Entity("Apsi.Database.Entities.Subject", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Audience")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Apsi.Database.Entities.User", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserRole")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SocialGroupUser", b =>
                {
                    b.Property<int>("SocialGroupsId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("SocialGroupsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("SocialGroupUser");
                });

            modelBuilder.Entity("Apsi.Database.Entities.Attachment", b =>
                {
                    b.HasOne("Apsi.Database.Entities.Idea", null)
                        .WithMany("Attachments")
                        .HasForeignKey("IdeaId");
                });

            modelBuilder.Entity("Apsi.Database.Entities.Benefit", b =>
                {
                    b.HasOne("Apsi.Database.Entities.Idea", null)
                        .WithMany("Benefits")
                        .HasForeignKey("IdeaId");
                });

            modelBuilder.Entity("Apsi.Database.Entities.Cost", b =>
                {
                    b.HasOne("Apsi.Database.Entities.Idea", null)
                        .WithMany("Costs")
                        .HasForeignKey("IdeaId");
                });

            modelBuilder.Entity("Apsi.Database.Entities.Idea", b =>
                {
                    b.HasOne("Apsi.Database.Entities.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("Apsi.Database.Entities.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId");

                    b.Navigation("Author");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Apsi.Database.Entities.Post", b =>
                {
                    b.HasOne("Apsi.Database.Entities.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("Apsi.Database.Entities.SocialGroup", "SocialGroup")
                        .WithMany()
                        .HasForeignKey("SocialGroupId");

                    b.Navigation("Author");

                    b.Navigation("SocialGroup");
                });

            modelBuilder.Entity("Apsi.Database.Entities.PostAnswer", b =>
                {
                    b.HasOne("Apsi.Database.Entities.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("Apsi.Database.Entities.Post", null)
                        .WithMany("PostAnswers")
                        .HasForeignKey("PostId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Apsi.Database.Entities.Rating", b =>
                {
                    b.HasOne("Apsi.Database.Entities.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("Apsi.Database.Entities.Idea", null)
                        .WithMany("Ratings")
                        .HasForeignKey("IdeaId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Apsi.Database.Entities.RatingSetting", b =>
                {
                    b.HasOne("Apsi.Database.Entities.Idea", null)
                        .WithMany("RatingSettings")
                        .HasForeignKey("IdeaId");
                });

            modelBuilder.Entity("Apsi.Database.Entities.Review", b =>
                {
                    b.HasOne("Apsi.Database.Entities.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("Apsi.Database.Entities.Idea", "Idea")
                        .WithMany()
                        .HasForeignKey("IdeaId");

                    b.Navigation("Author");

                    b.Navigation("Idea");
                });

            modelBuilder.Entity("SocialGroupUser", b =>
                {
                    b.HasOne("Apsi.Database.Entities.SocialGroup", null)
                        .WithMany()
                        .HasForeignKey("SocialGroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Apsi.Database.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Apsi.Database.Entities.Idea", b =>
                {
                    b.Navigation("Attachments");

                    b.Navigation("Benefits");

                    b.Navigation("Costs");

                    b.Navigation("Ratings");

                    b.Navigation("RatingSettings");
                });

            modelBuilder.Entity("Apsi.Database.Entities.Post", b =>
                {
                    b.Navigation("PostAnswers");
                });
#pragma warning restore 612, 618
        }
    }
}
