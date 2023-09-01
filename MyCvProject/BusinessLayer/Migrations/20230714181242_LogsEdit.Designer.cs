﻿// <auto-generated />
using System;
using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BusinessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230714181242_LogsEdit")]
    partial class LogsEdit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrate.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedUserId")
                        .HasColumnType("int");

                    b.Property<string>("Details1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Details2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LastModifiedUserId")
                        .HasColumnType("int");

                    b.Property<string>("MapLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("DeletedUserId");

                    b.HasIndex("LastModifiedUserId");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LastModifiedUserId")
                        .HasColumnType("int");

                    b.Property<int>("MyProjectId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("DeletedUserId");

                    b.HasIndex("LastModifiedUserId");

                    b.HasIndex("MyProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ContactDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedUserId")
                        .HasColumnType("int");

                    b.Property<string>("EMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LastModifiedUserId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("DeletedUserId");

                    b.HasIndex("LastModifiedUserId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EntityLayer.Concrate.MyProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abilities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedUserId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LastModifiedUserId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("DeletedUserId");

                    b.HasIndex("LastModifiedUserId");

                    b.ToTable("MyProjects");
                });

            modelBuilder.Entity("MyCvProjectEntityLayer.Concrate.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LastModifiedUserId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("DeletedUserId");

                    b.HasIndex("LastModifiedUserId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MyCvProjectEntityLayer.Concrate.Like", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LastModifiedUserId")
                        .HasColumnType("int");

                    b.Property<bool>("LikeorDislike")
                        .HasColumnType("bit");

                    b.Property<int>("MyProjectId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("DeletedUserId");

                    b.HasIndex("LastModifiedUserId");

                    b.HasIndex("MyProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("MyCvProjectEntityLayer.Concrate.NewsletterPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("NewsletterPersons");
                });

            modelBuilder.Entity("MyCvProjectEntityLayer.Concrate.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EntityLayer.Concrate.About", b =>
                {
                    b.HasOne("MyCvProjectEntityLayer.Concrate.User", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("MyCvProjectEntityLayer.Concrate.User", "DeletedUser")
                        .WithMany()
                        .HasForeignKey("DeletedUserId");

                    b.HasOne("MyCvProjectEntityLayer.Concrate.User", "LastModifiedUser")
                        .WithMany()
                        .HasForeignKey("LastModifiedUserId");

                    b.Navigation("CreatedUser");

                    b.Navigation("DeletedUser");

                    b.Navigation("LastModifiedUser");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Comment", b =>
                {
                    b.HasOne("MyCvProjectEntityLayer.Concrate.User", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("MyCvProjectEntityLayer.Concrate.User", "DeletedUser")
                        .WithMany()
                        .HasForeignKey("DeletedUserId");

                    b.HasOne("MyCvProjectEntityLayer.Concrate.User", "LastModifiedUser")
                        .WithMany()
                        .HasForeignKey("LastModifiedUserId");

                    b.HasOne("EntityLayer.Concrate.MyProject", "MyProject")
                        .WithMany()
                        .HasForeignKey("MyProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyCvProjectEntityLayer.Concrate.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedUser");

                    b.Navigation("DeletedUser");

                    b.Navigation("LastModifiedUser");

                    b.Navigation("MyProject");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Contact", b =>
                {
                    b.HasOne("MyCvProjectEntityLayer.Concrate.User", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("MyCvProjectEntityLayer.Concrate.User", "DeletedUser")
                        .WithMany()
                        .HasForeignKey("DeletedUserId");

                    b.HasOne("MyCvProjectEntityLayer.Concrate.User", "LastModifiedUser")
                        .WithMany()
                        .HasForeignKey("LastModifiedUserId");

                    b.Navigation("CreatedUser");

                    b.Navigation("DeletedUser");

                    b.Navigation("LastModifiedUser");
                });

            modelBuilder.Entity("EntityLayer.Concrate.MyProject", b =>
                {
                    b.HasOne("MyCvProjectEntityLayer.Concrate.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyCvProjectEntityLayer.Concrate.User", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("MyCvProjectEntityLayer.Concrate.User", "DeletedUser")
                        .WithMany()
                        .HasForeignKey("DeletedUserId");

                    b.HasOne("MyCvProjectEntityLayer.Concrate.User", "LastModifiedUser")
                        .WithMany()
                        .HasForeignKey("LastModifiedUserId");

                    b.Navigation("Category");

                    b.Navigation("CreatedUser");

                    b.Navigation("DeletedUser");

                    b.Navigation("LastModifiedUser");
                });

            modelBuilder.Entity("MyCvProjectEntityLayer.Concrate.Category", b =>
                {
                    b.HasOne("MyCvProjectEntityLayer.Concrate.User", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("MyCvProjectEntityLayer.Concrate.User", "DeletedUser")
                        .WithMany()
                        .HasForeignKey("DeletedUserId");

                    b.HasOne("MyCvProjectEntityLayer.Concrate.User", "LastModifiedUser")
                        .WithMany()
                        .HasForeignKey("LastModifiedUserId");

                    b.Navigation("CreatedUser");

                    b.Navigation("DeletedUser");

                    b.Navigation("LastModifiedUser");
                });

            modelBuilder.Entity("MyCvProjectEntityLayer.Concrate.Like", b =>
                {
                    b.HasOne("MyCvProjectEntityLayer.Concrate.User", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("MyCvProjectEntityLayer.Concrate.User", "DeletedUser")
                        .WithMany()
                        .HasForeignKey("DeletedUserId");

                    b.HasOne("MyCvProjectEntityLayer.Concrate.User", "LastModifiedUser")
                        .WithMany()
                        .HasForeignKey("LastModifiedUserId");

                    b.HasOne("EntityLayer.Concrate.MyProject", "MyProject")
                        .WithMany()
                        .HasForeignKey("MyProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyCvProjectEntityLayer.Concrate.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedUser");

                    b.Navigation("DeletedUser");

                    b.Navigation("LastModifiedUser");

                    b.Navigation("MyProject");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
