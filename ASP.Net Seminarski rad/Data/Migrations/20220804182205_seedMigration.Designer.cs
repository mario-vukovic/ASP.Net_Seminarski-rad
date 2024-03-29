﻿// <auto-generated />
using System;
using ASP.Net_Seminarski_rad.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASP.Net_Seminarski_rad.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220804182205_seedMigration")]
    partial class seedMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ASP.Net_Seminarski_rad.Models.Dbo.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2329dfcf-fac4-46c8-a92d-cad42ebc10e3",
                            Dob = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAcTzSRm+rzdmEj8cHCYH3f4BXSLxIH4WvAk4i3VsoaJTFj4BR+DxfKcm2tgbeT/Fg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "96cb4354-a04b-4494-876e-1a6fed31dcc6",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e18395ca-0083-425d-a228-b6807d271a23",
                            Dob = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "user@user.com",
                            EmailConfirmed = true,
                            FirstName = "BasicUser",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@USER.COM",
                            NormalizedUserName = "USER@USER.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJiFn5sTF/PROr0Yw1+MkwKi7q6n40vmwlLD+0NQAusEBZboVF6cEpWoTT3boH9xDA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "394f623e-9712-4f6b-9820-949b839806fe",
                            TwoFactorEnabled = false,
                            UserName = "user@user.com"
                        });
                });

            modelBuilder.Entity("ASP.Net_Seminarski_rad.Models.Dbo.FileStorage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("DownloadUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileExtension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhysicalPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FileStorage");
                });

            modelBuilder.Entity("ASP.Net_Seminarski_rad.Models.Dbo.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ProductImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Brown, made of real deer skin, used to cut down tree the picture was taken on",
                            Name = "Wonderful Winter Boots",
                            Price = 320m,
                            ProductCategoryId = 1,
                            ProductImgUrl = "https://www.hotter.com/blog/wp-content/uploads/2016/11/RUBY_SL-RT-300x200.jpg",
                            Quantity = 19m
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Snow not included",
                            Name = "Rain and winter Boots",
                            Price = 120m,
                            ProductCategoryId = 1,
                            ProductImgUrl = "https://capitaliron.ca/wp-content/uploads/2021/02/Boots-snow-300x200.jpeg",
                            Quantity = 7m
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "I have no idea what this is, but it sure is stylish",
                            Name = "Barefoot Winter Shoes",
                            Price = 560m,
                            ProductCategoryId = 1,
                            ProductImgUrl = "https://lh4.googleusercontent.com/uKiSMORQwKFcFD6mmxTLQKOJYzDnfa1SI-t4kUkZU0ctklvkYovubYe8YlXhmBLCYwHaM0VBvTuD2j68ODBCanhIY_nJteVdkPl6CtfVV2QQUvTf3wa4nukJsuB0NHrQWezwFjRI",
                            Quantity = 1m
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Approved by the Saviour himself",
                            Name = "Brown Summer Sandals",
                            Price = 540m,
                            ProductCategoryId = 2,
                            ProductImgUrl = "https://i.ebayimg.com/thumbs/images/g/brcAAOSw9k5XQKi5/s-l300.jpg",
                            Quantity = 67m
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "It's free, just take your shoes off",
                            Name = "Bare feet",
                            Price = 0m,
                            ProductCategoryId = 2,
                            ProductImgUrl = "https://images.squarespace-cdn.com/content/v1/5b6c9532cc8fed0c2edbc0cc/1562095212390-Y0VENOYPZFPWLUY24FDA/adult-bare-feet-barefoot-1249546.jpg",
                            Quantity = 999m
                        },
                        new
                        {
                            Id = 6,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is the first thing that appears when I google for 'summer shoes', you tell me",
                            Name = "Some sort of white shoes",
                            Price = 90m,
                            ProductCategoryId = 2,
                            ProductImgUrl = "https://www.shoes.hr/site/assets/files/21725/carl-perf_mephisto_white_leather_shoe-sneaker_for_summer_for_men_perforated_5136957_3.300x0.jpg",
                            Quantity = 7m
                        },
                        new
                        {
                            Id = 7,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Diarrhea coloured",
                            Name = "Timberlands",
                            Price = 117m,
                            ProductCategoryId = 3,
                            ProductImgUrl = "https://i.ebayimg.com/thumbs/images/g/GwQAAOSwpOdi4qjF/s-l300.jpg",
                            Quantity = 35m
                        },
                        new
                        {
                            Id = 8,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Not actually made of crocodiles, surprisingly comfy",
                            Name = "Crocs",
                            Price = 220m,
                            ProductCategoryId = 3,
                            ProductImgUrl = "https://www.abcrafty.com/wp-content/uploads/2021/10/tie-dye-crocs_20-300x200.jpg",
                            Quantity = 76m
                        },
                        new
                        {
                            Id = 9,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Pretty damn uggly",
                            Name = "Ugg Boots",
                            Price = 780m,
                            ProductCategoryId = 3,
                            ProductImgUrl = "https://cdn.shopify.com/s/files/1/1327/1087/products/ugg-boots-ta-cadence-women-short-ugg-boots-inner-zipper-1_300x.jpg?v=1621910505",
                            Quantity = 12m
                        },
                        new
                        {
                            Id = 10,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "UltraBOOST, what does that even MEAN",
                            Name = "Addidas black",
                            Price = 870m,
                            ProductCategoryId = 4,
                            ProductImgUrl = "https://mangosneakers.com/wp-content/uploads/2021/01/f5ffefac-300x200.jpg",
                            Quantity = 51m
                        },
                        new
                        {
                            Id = 11,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Told you it's all black",
                            Name = "Allstar Converse Black",
                            Price = 170m,
                            ProductCategoryId = 4,
                            ProductImgUrl = "https://repsneakers.net/wp-content/uploads/2021/01/bc31d3c0-300x200.jpg",
                            Quantity = 14m
                        },
                        new
                        {
                            Id = 12,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "I don't really like anything else",
                            Name = "Nothing",
                            Price = 300m,
                            ProductCategoryId = 4,
                            ProductImgUrl = "https://conejovet.com/wp-content/uploads/2017/10/Blank-300x200-300x300.jpg",
                            Quantity = 42m
                        },
                        new
                        {
                            Id = 13,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Perfect for the office Christmas party",
                            Name = "Pink...shoes",
                            Price = 310m,
                            ProductCategoryId = 5,
                            ProductImgUrl = "https://static.vecteezy.com/system/resources/thumbnails/008/623/000/small/pair-of-female-natural-leather-shoe-hand-made-beige-medium-heel-shoes-decorated-with-wooden-element-women-s-shoes-concept-leather-high-quality-and-exclusive-footwear-photo.jpg",
                            Quantity = 22m
                        },
                        new
                        {
                            Id = 14,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "I've never actually seen anyone wear these",
                            Name = "Pink Nike Sneakers",
                            Price = 30m,
                            ProductCategoryId = 5,
                            ProductImgUrl = "https://i.pinimg.com/564x/d3/f0/fe/d3f0fe393d619f2d87933afbf5623038.jpg",
                            Quantity = 57m
                        },
                        new
                        {
                            Id = 15,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "I used to get my ass whopped by these",
                            Name = "IKona Sw005 Fawn",
                            Price = 420m,
                            ProductCategoryId = 5,
                            ProductImgUrl = "https://shoeslylo.pk/wp-content/uploads/2019/08/Buy-Beautiful-IKona-Sw005-Fawn-Color-Shoes-300x200.jpeg",
                            Quantity = 69m
                        });
                });

            modelBuilder.Entity("ASP.Net_Seminarski_rad.Models.Dbo.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Shoes best worn during the winter to keep you warm",
                            ProductId = 0,
                            Title = "Winter shoes"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Shoes best worn during the summer, although who am I to tell you what to do, if you want to be cold; You be cold",
                            ProductId = 0,
                            Title = "Summer shoes"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "For some reason people thing these look good and won't stop wearing them. Fashion, wow.",
                            ProductId = 0,
                            Title = "Ugly shoes"
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "I like black...that's it",
                            ProductId = 0,
                            Title = "Shoes I like"
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Damn, those are big",
                            ProductId = 0,
                            Title = "Shoes your mom wears"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "ae3cd568-6242-4891-8d78-78065a39acf8",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "eaeca1cf-599d-4aa1-afd1-d8fb542e3754",
                            Name = "BasicUser",
                            NormalizedName = "BASICUSER"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "d6d4d551-1575-4864-a8e4-4cd6e4b01ba3",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        },
                        new
                        {
                            Id = "4",
                            ConcurrencyStamp = "3a40e8db-d1ff-4a56-8ea1-50b215510066",
                            Name = "Editor",
                            NormalizedName = "EDITOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "2",
                            RoleId = "2"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ASP.Net_Seminarski_rad.Models.Dbo.Product", b =>
                {
                    b.HasOne("ASP.Net_Seminarski_rad.Models.Dbo.ProductCategory", "ProductCategory")
                        .WithMany("Product")
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ASP.Net_Seminarski_rad.Models.Dbo.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ASP.Net_Seminarski_rad.Models.Dbo.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASP.Net_Seminarski_rad.Models.Dbo.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ASP.Net_Seminarski_rad.Models.Dbo.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASP.Net_Seminarski_rad.Models.Dbo.ProductCategory", b =>
                {
                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
