﻿// <auto-generated />
using System;
using Imi.Project.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.BlogPost", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("PostDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BlogPosts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            PostDate = new DateTime(2021, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Recept: Eclairs"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            PostDate = new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Nieuw product: Vegan Apple Crumble"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            PostDate = new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Glazed in de Krant van West-Vlaanderen"
                        });
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            Name = "Taart"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            Name = "Gebak"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            Name = "Koekjes met glazuur"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000004"),
                            Name = "Koekjes met rolfondant"
                        });
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.DietaryRequirement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.HasKey("Id");

                    b.ToTable("DietaryRequirements");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            Name = "Vegan"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            Name = "Glutenvrij"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            Name = "Notenvrij"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000004"),
                            Name = "Lactosevrij"
                        });
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            CategoryId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Description = "Frans nagerecht van kersen in een lekker gebakken roommengsel uit de oven.",
                            Name = "Clafoutis van kersen",
                            Price = 8.50m
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            CategoryId = new Guid("00000000-0000-0000-0000-000000000002"),
                            Description = "Marmercake is de ultieme combinatie van een vanillecake en een chocoladecake.",
                            Name = "Marble Cake",
                            Price = 6m
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            CategoryId = new Guid("00000000-0000-0000-0000-000000000003"),
                            Description = "Vanille vegan koekjes met pompoenglazuur",
                            Name = "6 Vegan Pumpkin Cookies",
                            Price = 5m
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000004"),
                            CategoryId = new Guid("00000000-0000-0000-0000-000000000002"),
                            Description = "Frans gebakje op smaak gebracht met rum, een culinaire specialiteit uit de streek rond Bordeaux",
                            Name = "6 Cannelés de Bordeaux",
                            Price = 4.50m
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000005"),
                            CategoryId = new Guid("00000000-0000-0000-0000-000000000003"),
                            Description = "Vanille-kaneelkoekjes met vanille glazuur in Kertsthema.",
                            Name = "6 Chistmas Cinnamon Cookies",
                            Price = 5.50m
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000006"),
                            CategoryId = new Guid("00000000-0000-0000-0000-000000000004"),
                            Description = "Vanillekoekjes van het huis met roze rolfondant en het Glazed-logo.",
                            Name = "6 Glazed Signature Fondant Cookies",
                            Price = 3.50m
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000007"),
                            CategoryId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Description = "Kaastaart met citroencoulis op een bodem van caramelcrumble.",
                            Name = "Lemon Cheescake",
                            Price = 7.50m
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000008"),
                            CategoryId = new Guid("00000000-0000-0000-0000-000000000003"),
                            Description = "Glazed signature vanille-donutkoekjes met roze glazuur en sprinkles.",
                            Name = "6 Glazed Doughnut Cookies",
                            Price = 6.50m
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000009"),
                            CategoryId = new Guid("00000000-0000-0000-0000-000000000004"),
                            Description = "Hartvormige chocoladekoekjes met afwerking in rode rolfondant",
                            Name = "6 Valentine Fondant Cookies",
                            Price = 4.50m
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000010"),
                            CategoryId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Description = "Verse crumble met stukjes appel en kaneel, heerlijk warm met een bolltje vanille-ijs.",
                            Name = "Vegan Apple Crumble",
                            Price = 7.50m
                        });
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.ProductDietaryRequirement", b =>
                {
                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DietaryRequirementId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductId", "DietaryRequirementId");

                    b.HasIndex("DietaryRequirementId");

                    b.ToTable("ProductsDietaryRequirements");

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("00000000-0000-0000-0000-000000000002"),
                            DietaryRequirementId = new Guid("00000000-0000-0000-0000-000000000003")
                        },
                        new
                        {
                            ProductId = new Guid("00000000-0000-0000-0000-000000000003"),
                            DietaryRequirementId = new Guid("00000000-0000-0000-0000-000000000001")
                        },
                        new
                        {
                            ProductId = new Guid("00000000-0000-0000-0000-000000000003"),
                            DietaryRequirementId = new Guid("00000000-0000-0000-0000-000000000002")
                        },
                        new
                        {
                            ProductId = new Guid("00000000-0000-0000-0000-000000000003"),
                            DietaryRequirementId = new Guid("00000000-0000-0000-0000-000000000003")
                        },
                        new
                        {
                            ProductId = new Guid("00000000-0000-0000-0000-000000000003"),
                            DietaryRequirementId = new Guid("00000000-0000-0000-0000-000000000004")
                        },
                        new
                        {
                            ProductId = new Guid("00000000-0000-0000-0000-000000000005"),
                            DietaryRequirementId = new Guid("00000000-0000-0000-0000-000000000002")
                        },
                        new
                        {
                            ProductId = new Guid("00000000-0000-0000-0000-000000000005"),
                            DietaryRequirementId = new Guid("00000000-0000-0000-0000-000000000004")
                        },
                        new
                        {
                            ProductId = new Guid("00000000-0000-0000-0000-000000000006"),
                            DietaryRequirementId = new Guid("00000000-0000-0000-0000-000000000003")
                        },
                        new
                        {
                            ProductId = new Guid("00000000-0000-0000-0000-000000000006"),
                            DietaryRequirementId = new Guid("00000000-0000-0000-0000-000000000004")
                        },
                        new
                        {
                            ProductId = new Guid("00000000-0000-0000-0000-000000000008"),
                            DietaryRequirementId = new Guid("00000000-0000-0000-0000-000000000003")
                        },
                        new
                        {
                            ProductId = new Guid("00000000-0000-0000-0000-000000000009"),
                            DietaryRequirementId = new Guid("00000000-0000-0000-0000-000000000002")
                        },
                        new
                        {
                            ProductId = new Guid("00000000-0000-0000-0000-000000000009"),
                            DietaryRequirementId = new Guid("00000000-0000-0000-0000-000000000003")
                        },
                        new
                        {
                            ProductId = new Guid("00000000-0000-0000-0000-000000000009"),
                            DietaryRequirementId = new Guid("00000000-0000-0000-0000-000000000004")
                        },
                        new
                        {
                            ProductId = new Guid("00000000-0000-0000-0000-000000000010"),
                            DietaryRequirementId = new Guid("00000000-0000-0000-0000-000000000001")
                        },
                        new
                        {
                            ProductId = new Guid("00000000-0000-0000-0000-000000000010"),
                            DietaryRequirementId = new Guid("00000000-0000-0000-0000-000000000004")
                        });
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            Email = "amaury.decru@test.com",
                            Name = "Decru",
                            Password = "Test123",
                            PhoneNumber = "+32 111 111 111",
                            Surname = "Amaury"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            Email = "john.doe@test.com",
                            Name = "Doe",
                            Password = "Test123",
                            PhoneNumber = "+32 222 222 222",
                            Surname = "John"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            Email = "jane.doe@test.com",
                            Name = "Doe",
                            Password = "Test123",
                            PhoneNumber = "+32 333 333 333",
                            Surname = "Jane"
                        });
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Product", b =>
                {
                    b.HasOne("Imi.Project.Api.Core.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.ProductDietaryRequirement", b =>
                {
                    b.HasOne("Imi.Project.Api.Core.Entities.DietaryRequirement", "DietaryRequirement")
                        .WithMany("ProductDietaryRequirements")
                        .HasForeignKey("DietaryRequirementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Imi.Project.Api.Core.Entities.Product", "Product")
                        .WithMany("ProductDietaryRequirements")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
