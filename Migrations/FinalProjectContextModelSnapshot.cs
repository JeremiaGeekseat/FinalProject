using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using DomainData;

namespace FinalProject.Migrations
{
    [DbContext(typeof(FinalProjectContext))]
    partial class FinalProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DomainData.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("date");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("date");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("DomainData.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("date");

                    b.Property<string>("Email");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Message");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("date");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("DomainData.Favorite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("date");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("date");

                    b.Property<int>("MovieId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId");

                    b.ToTable("Favorite");
                });

            modelBuilder.Entity("DomainData.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BackgroundUrl");

                    b.Property<int?>("CategoryId");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("date");

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("Released")
                        .HasColumnType("date");

                    b.Property<string>("ThumbnailUrl");

                    b.Property<string>("Title");

                    b.Property<int>("Viewed");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("DomainData.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("date");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("date");

                    b.Property<int>("MovieId");

                    b.Property<int>("Rate");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("DomainData.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("date");

                    b.Property<string>("Email");

                    b.Property<bool>("IsActivated");

                    b.Property<bool>("IsAdmin");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("date");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("DomainData.Contact", b =>
                {
                    b.HasOne("DomainData.User", "User")
                        .WithMany("Contacts")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("DomainData.Favorite", b =>
                {
                    b.HasOne("DomainData.Movie", "Movie")
                        .WithMany("Favorites")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DomainData.User", "User")
                        .WithMany("Favorites")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomainData.Movie", b =>
                {
                    b.HasOne("DomainData.Category", "Category")
                        .WithMany("Movies")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("DomainData.Review", b =>
                {
                    b.HasOne("DomainData.Movie", "Movie")
                        .WithMany("Reviews")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DomainData.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
