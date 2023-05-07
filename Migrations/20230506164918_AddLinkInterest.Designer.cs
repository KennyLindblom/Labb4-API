﻿// <auto-generated />
using Labb4__API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Labb4__API.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230506164918_AddLinkInterest")]
    partial class AddLinkInterest
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Labb4__API.Models.Intrest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Interests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A sport played on ice",
                            Title = "Hockey"
                        },
                        new
                        {
                            Id = 2,
                            Description = "A sport played with a ball",
                            Title = "Football"
                        },
                        new
                        {
                            Id = 3,
                            Description = "A sport played with a ball and hoops",
                            Title = "Basketball"
                        },
                        new
                        {
                            Id = 4,
                            Description = "A sport played with a ball and hands",
                            Title = "Handball"
                        },
                        new
                        {
                            Id = 5,
                            Description = "A sport played with a ball and bat",
                            Title = "Baseball"
                        });
                });

            modelBuilder.Entity("Labb4__API.Models.Link", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("InterestId")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InterestId");

                    b.ToTable("Links");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            InterestId = 1,
                            PersonId = 1,
                            Url = "https://www.nhl.com"
                        },
                        new
                        {
                            Id = 2,
                            InterestId = 2,
                            PersonId = 2,
                            Url = "https://www.fifa.com"
                        },
                        new
                        {
                            Id = 3,
                            InterestId = 3,
                            PersonId = 1,
                            Url = "https://www.nba.com"
                        },
                        new
                        {
                            Id = 4,
                            InterestId = 4,
                            PersonId = 1,
                            Url = "https://www.ihf.info/"
                        },
                        new
                        {
                            Id = 5,
                            InterestId = 5,
                            PersonId = 1,
                            Url = "https://www.mlb.com/"
                        });
                });

            modelBuilder.Entity("Labb4__API.Models.Person", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            id = 1,
                            FirstName = "Adam",
                            LastName = "Carlen",
                            Phone = "1234567890"
                        },
                        new
                        {
                            id = 2,
                            FirstName = "Olof",
                            LastName = "Mellberg",
                            Phone = "0987654321"
                        },
                        new
                        {
                            id = 3,
                            FirstName = "Johan",
                            LastName = "Krall",
                            Phone = "0702656565"
                        },
                        new
                        {
                            id = 4,
                            FirstName = "Johanna",
                            LastName = "Melker",
                            Phone = "0702696969"
                        },
                        new
                        {
                            id = 5,
                            FirstName = "Axel",
                            LastName = "Lexander",
                            Phone = "0340265432"
                        });
                });

            modelBuilder.Entity("Labb4__API.Models.PersonInterest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("InterestId")
                        .HasColumnType("int");

                    b.Property<int>("LinkId")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InterestId");

                    b.HasIndex("LinkId");

                    b.HasIndex("PersonId");

                    b.ToTable("PersonInterests");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            InterestId = 1,
                            LinkId = 0,
                            PersonId = 1
                        },
                        new
                        {
                            Id = -2,
                            InterestId = 3,
                            LinkId = 0,
                            PersonId = 1
                        },
                        new
                        {
                            Id = -3,
                            InterestId = 2,
                            LinkId = 0,
                            PersonId = 2
                        },
                        new
                        {
                            Id = -4,
                            InterestId = 4,
                            LinkId = 0,
                            PersonId = 2
                        },
                        new
                        {
                            Id = -5,
                            InterestId = 5,
                            LinkId = 0,
                            PersonId = 2
                        },
                        new
                        {
                            Id = -6,
                            InterestId = 2,
                            LinkId = 0,
                            PersonId = 3
                        },
                        new
                        {
                            Id = -7,
                            InterestId = 1,
                            LinkId = 0,
                            PersonId = 3
                        },
                        new
                        {
                            Id = -8,
                            InterestId = 2,
                            LinkId = 0,
                            PersonId = 4
                        },
                        new
                        {
                            Id = -9,
                            InterestId = 3,
                            LinkId = 0,
                            PersonId = 4
                        },
                        new
                        {
                            Id = -10,
                            InterestId = 1,
                            LinkId = 0,
                            PersonId = 4
                        },
                        new
                        {
                            Id = -11,
                            InterestId = 1,
                            LinkId = 0,
                            PersonId = 5
                        },
                        new
                        {
                            Id = -12,
                            InterestId = 5,
                            LinkId = 0,
                            PersonId = 5
                        });
                });

            modelBuilder.Entity("Labb4__API.Models.Link", b =>
                {
                    b.HasOne("Labb4__API.Models.Intrest", "Interest")
                        .WithMany("Links")
                        .HasForeignKey("InterestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Interest");
                });

            modelBuilder.Entity("Labb4__API.Models.PersonInterest", b =>
                {
                    b.HasOne("Labb4__API.Models.Intrest", "Interest")
                        .WithMany("PersonInterests")
                        .HasForeignKey("InterestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb4__API.Models.Link", "Link")
                        .WithMany()
                        .HasForeignKey("LinkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb4__API.Models.Person", "Person")
                        .WithMany("PersonIntrests")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Interest");

                    b.Navigation("Link");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Labb4__API.Models.Intrest", b =>
                {
                    b.Navigation("Links");

                    b.Navigation("PersonInterests");
                });

            modelBuilder.Entity("Labb4__API.Models.Person", b =>
                {
                    b.Navigation("PersonIntrests");
                });
#pragma warning restore 612, 618
        }
    }
}
