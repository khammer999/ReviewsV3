﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewSite;

namespace ReviewSite.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20181102044145_20181102-0041hrs")]
    partial class _201811020041hrs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReviewSite.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = 1, CategoryId = 1, Name = "Concert" },
                        new { Id = 2, CategoryId = 2, Name = "Book" },
                        new { Id = 3, CategoryId = 4, Name = "Food" },
                        new { Id = 4, CategoryId = 3, Name = "Album" }
                    );
                });

            modelBuilder.Entity("ReviewSite.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Content");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new { Id = 1, CategoryId = 1, Content = "Hard Rain rocked the house to a sold out crowd Friday August 10th, 2018 ", ImageUrl = "/images/band.jpg", Title = "Hard Rain at MusicBox Supper Club" },
                        new { Id = 2, CategoryId = 2, Content = "The classic by Tom Clancy that inpired the movie of the same name!", ImageUrl = "/images/bookcover.jpg", Title = "Hunt for Red Oktober" },
                        new { Id = 3, CategoryId = 2, Content = "the timeless John Steinbeck classic", ImageUrl = "/images/bookcover.jpg", Title = "Of Mice and Men" },
                        new { Id = 4, CategoryId = 4, Content = "Blue Eyed Soul, Rhythym and Blues from \"The PGH Rockers\" ", ImageUrl = "/images/deepInTheShadows.jpg", Title = "Deep In The Shadows" },
                        new { Id = 5, CategoryId = 3, Content = "If grease brings you gastronomic peace, then this dish should be your wish!", ImageUrl = "/images/piggyLunch.jpg", Title = "Triple ByPass Cheese Steak Deluxe from Mr. Burger" }
                    );
                });

            modelBuilder.Entity("ReviewSite.Models.Review", b =>
                {
                    b.HasOne("ReviewSite.Models.Category", "Category")
                        .WithMany("Reviews")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
