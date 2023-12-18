using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoonReads.Migrations
{
    /// <inheritdoc />
    public partial class Initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Avatar = table.Column<string>(type: "text", nullable: true),
                    RefreshToken = table.Column<string>(type: "text", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataVersions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Table = table.Column<string>(type: "text", nullable: false),
                    Version = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataVersions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuthorCategories",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorCategories", x => new { x.AuthorId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_AuthorCategories_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: false),
                    ReleaseDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Pages = table.Column<int>(type: "integer", nullable: false),
                    Isbn = table.Column<string>(type: "text", nullable: false),
                    Pending = table.Column<bool>(type: "boolean", nullable: false),
                    PublisherId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Like = table.Column<bool>(type: "boolean", nullable: false),
                    ReviewId = table.Column<int>(type: "integer", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reactions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reactions_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BookAuthors",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "integer", nullable: false),
                    AuthorId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthors", x => new { x.BookId, x.AuthorId });
                    table.ForeignKey(
                        name: "FK_BookAuthors_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthors_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookCategories",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategories", x => new { x.BookId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_BookCategories_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Rate = table.Column<int>(type: "integer", nullable: false),
                    ReviewId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    BookId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=749", "Kaylin Hirthe" },
                    { 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=297", "Deborah Sauer" },
                    { 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=679", "Patrick Weimann" },
                    { 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=719", "Jackie Green" },
                    { 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=837", "Antonia Waters" },
                    { 6, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=49", "Bertha Marvin" },
                    { 7, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=763", "Susan Littel" },
                    { 8, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=988", "Jaycee Larkin" },
                    { 9, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=63", "Rasheed Hyatt" },
                    { 10, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=345", "Lue Gibson" },
                    { 11, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=1007", "Rowena Schulist" },
                    { 12, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=687", "Vince Mills" },
                    { 13, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=732", "Eugenia Stokes" },
                    { 14, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=1073", "Shanie MacGyver" },
                    { 15, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=278", "Daniela Bartoletti" },
                    { 16, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=234", "Libby Spencer" },
                    { 17, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=74", "Roberta Ritchie" },
                    { 18, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=620", "Demarcus Brown" },
                    { 19, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=690", "Isai Schmitt" },
                    { 20, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=531", "Noble Harvey" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Industrial, Jewelery & Grocery" },
                    { 2, "Jewelery & Sports" },
                    { 3, "Computers" },
                    { 4, "Sports" },
                    { 5, "Clothing, Electronics & Industrial" },
                    { 6, "Shoes" },
                    { 7, "Clothing" },
                    { 8, "Clothing & Beauty" },
                    { 9, "Kids & Kids" },
                    { 10, "Sports & Tools" },
                    { 11, "Home & Games" },
                    { 12, "Shoes, Toys & Books" },
                    { 13, "Jewelery & Outdoors" },
                    { 14, "Toys & Health" },
                    { 15, "Music" },
                    { 16, "Home & Outdoors" },
                    { 17, "Industrial, Electronics & Grocery" },
                    { 18, "Garden" },
                    { 19, "Computers" },
                    { 20, "Garden, Books & Jewelery" }
                });

            migrationBuilder.InsertData(
                table: "DataVersions",
                columns: new[] { "Id", "Table", "Version" },
                values: new object[,]
                {
                    { 1, "Authors", 0 },
                    { 2, "Books", 0 },
                    { 3, "Categories", 0 },
                    { 4, "Publishers", 0 },
                    { 5, "AuthorCategories", 0 },
                    { 6, "BookAuthors", 0 },
                    { 7, "BookCategories", 0 },
                    { 8, "Ratings", 0 },
                    { 9, "Reviews", 0 },
                    { 10, "ReviewRatings", 0 }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=1039", "Prosacco - Kuvalis" },
                    { 2, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=521", "Collins - Wilkinson" },
                    { 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=546", "Bode, Kohler and Abernathy" },
                    { 4, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=84", "Murphy, Bahringer and Witting" },
                    { 5, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=637", "Reinger - Armstrong" },
                    { 6, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=467", "Ruecker Group" },
                    { 7, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=755", "Carter Group" },
                    { 8, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=230", "Erdman LLC" },
                    { 9, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=677", "McDermott, Larkin and Langworth" },
                    { 10, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=935", "Luettgen - Braun" },
                    { 11, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=202", "Torphy - Lehner" },
                    { 12, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=342", "Shanahan, Hahn and Cartwright" },
                    { 13, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=36", "Johns LLC" },
                    { 14, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=954", "Orn, Heller and Grady" },
                    { 15, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=678", "Rempel - Fay" },
                    { 16, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=431", "Kiehn and Sons" },
                    { 17, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=250", "Stracke - Schimmel" },
                    { 18, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=625", "Adams - Collins" },
                    { 19, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=695", "Hickle - Hane" },
                    { 20, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=886", "Sauer - Willms" }
                });

            migrationBuilder.InsertData(
                table: "AuthorCategories",
                columns: new[] { "AuthorId", "CategoryId", "Id" },
                values: new object[,]
                {
                    { 2, 3, 50 },
                    { 2, 6, 38 },
                    { 2, 12, 22 },
                    { 3, 10, 43 },
                    { 4, 5, 29 },
                    { 4, 8, 30 },
                    { 5, 1, 41 },
                    { 5, 3, 1 },
                    { 5, 9, 24 },
                    { 6, 11, 40 },
                    { 6, 18, 27 },
                    { 7, 2, 44 },
                    { 7, 3, 20 },
                    { 7, 5, 34 },
                    { 7, 6, 6 },
                    { 7, 19, 2 },
                    { 8, 6, 5 },
                    { 8, 11, 32 },
                    { 9, 3, 14 },
                    { 10, 7, 36 },
                    { 10, 15, 18 },
                    { 10, 18, 11 },
                    { 11, 7, 46 },
                    { 11, 11, 19 },
                    { 11, 14, 33 },
                    { 11, 18, 31 },
                    { 12, 2, 48 },
                    { 12, 3, 35 },
                    { 13, 3, 45 },
                    { 13, 16, 37 },
                    { 15, 7, 26 },
                    { 15, 10, 13 },
                    { 16, 2, 7 },
                    { 16, 8, 39 },
                    { 16, 13, 16 },
                    { 16, 19, 25 },
                    { 17, 1, 8 },
                    { 17, 5, 23 },
                    { 17, 11, 49 },
                    { 17, 17, 15 },
                    { 17, 20, 3 },
                    { 18, 1, 10 },
                    { 18, 19, 9 },
                    { 19, 4, 21 },
                    { 19, 7, 28 },
                    { 19, 11, 17 },
                    { 20, 3, 12 },
                    { 20, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Description", "ImageUrl", "Isbn", "Pages", "Pending", "PublisherId", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=466", "6030298605", 348, false, 18, new DateOnly(2023, 2, 12), "Ergonomic Fresh Towels" },
                    { 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=919", "1514012349", 482, false, 7, new DateOnly(2023, 10, 7), "Generic Cotton Chips" },
                    { 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=723", "1765247628", 875, false, 11, new DateOnly(2023, 2, 24), "Fantastic Concrete Table" },
                    { 4, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=1051", "7569506372", 439, false, 8, new DateOnly(2023, 2, 6), "Tasty Cotton Table" },
                    { 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=56", "6098951446", 452, false, 9, new DateOnly(2023, 11, 11), "Tasty Fresh Bike" },
                    { 6, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=625", "1073590732", 534, false, 8, new DateOnly(2023, 2, 25), "Handmade Concrete Salad" },
                    { 7, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=414", "1092020648", 249, false, 5, new DateOnly(2023, 8, 14), "Practical Wooden Ball" },
                    { 8, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=547", "7428364844", 455, false, 15, new DateOnly(2023, 7, 6), "Ergonomic Metal Soap" },
                    { 9, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=240", "9949631255", 121, false, 20, new DateOnly(2023, 4, 28), "Handmade Fresh Bacon" },
                    { 10, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=341", "9273179588", 619, false, 20, new DateOnly(2023, 4, 2), "Gorgeous Metal Sausages" },
                    { 11, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=520", "2669592026", 719, false, 15, new DateOnly(2023, 9, 27), "Awesome Plastic Bike" },
                    { 12, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=974", "5591813704", 287, false, 14, new DateOnly(2023, 10, 31), "Intelligent Wooden Keyboard" },
                    { 13, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=102", "5316171938", 648, false, 19, new DateOnly(2023, 7, 31), "Small Concrete Shoes" },
                    { 14, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=123", "7631378459", 520, false, 9, new DateOnly(2023, 10, 4), "Incredible Plastic Shoes" },
                    { 15, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=74", "5216664203", 476, false, 8, new DateOnly(2023, 3, 25), "Tasty Soft Towels" },
                    { 16, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=893", "4859256632", 353, false, 12, new DateOnly(2023, 5, 5), "Generic Soft Table" },
                    { 17, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=49", "5604270359", 242, false, 6, new DateOnly(2023, 5, 10), "Tasty Wooden Pizza" },
                    { 18, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=194", "4253805954", 829, false, 18, new DateOnly(2023, 2, 4), "Small Frozen Sausages" },
                    { 19, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=1035", "3626200130", 811, false, 19, new DateOnly(2023, 11, 23), "Small Granite Mouse" },
                    { 20, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=223", "1083828989", 590, false, 3, new DateOnly(2023, 3, 24), "Handmade Wooden Shoes" },
                    { 21, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=17", "8085228730", 234, false, 9, new DateOnly(2023, 6, 18), "Practical Fresh Soap" },
                    { 22, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=581", "7814881124", 543, false, 19, new DateOnly(2023, 5, 28), "Unbranded Cotton Car" },
                    { 23, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=540", "6468451297", 385, false, 19, new DateOnly(2023, 9, 4), "Tasty Metal Chips" },
                    { 24, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=460", "8419990175", 884, false, 6, new DateOnly(2023, 3, 28), "Fantastic Metal Bike" },
                    { 25, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=909", "1345479458", 416, false, 11, new DateOnly(2023, 6, 11), "Licensed Plastic Ball" },
                    { 26, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=516", "3387416626", 205, false, 1, new DateOnly(2023, 7, 24), "Gorgeous Metal Shoes" },
                    { 27, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=340", "4257881849", 747, false, 2, new DateOnly(2023, 6, 15), "Small Metal Tuna" },
                    { 28, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=587", "6622099832", 118, false, 10, new DateOnly(2023, 12, 4), "Generic Cotton Salad" },
                    { 29, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=1006", "3553060187", 177, false, 5, new DateOnly(2023, 8, 19), "Unbranded Soft Tuna" },
                    { 30, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=862", "5027154350", 190, false, 13, new DateOnly(2023, 2, 22), "Refined Rubber Sausages" },
                    { 31, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=962", "2258455548", 652, false, 3, new DateOnly(2023, 9, 26), "Incredible Plastic Tuna" },
                    { 32, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=895", "7841428666", 714, false, 6, new DateOnly(2023, 3, 10), "Handcrafted Rubber Ball" },
                    { 33, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=381", "8360017949", 881, false, 17, new DateOnly(2023, 12, 13), "Fantastic Frozen Pants" },
                    { 34, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=625", "3086704550", 495, false, 16, new DateOnly(2023, 5, 9), "Refined Rubber Pizza" },
                    { 35, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=253", "5471498158", 623, false, 7, new DateOnly(2023, 3, 20), "Handcrafted Frozen Bacon" },
                    { 36, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=752", "5509140806", 630, false, 6, new DateOnly(2023, 1, 12), "Fantastic Wooden Pants" },
                    { 37, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=201", "2677045551", 548, false, 4, new DateOnly(2023, 4, 22), "Handmade Frozen Chair" },
                    { 38, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=271", "3613177107", 585, false, 4, new DateOnly(2023, 5, 9), "Rustic Wooden Hat" },
                    { 39, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=1017", "4522412013", 707, false, 9, new DateOnly(2023, 12, 2), "Refined Wooden Table" },
                    { 40, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=111", "9512215388", 691, false, 15, new DateOnly(2023, 2, 11), "Handmade Concrete Tuna" },
                    { 41, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=1061", "7370871067", 144, false, 6, new DateOnly(2023, 9, 15), "Handmade Frozen Towels" },
                    { 42, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=571", "8499552444", 556, false, 3, new DateOnly(2023, 9, 3), "Small Wooden Shirt" },
                    { 43, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=1053", "3716152315", 835, false, 4, new DateOnly(2023, 1, 11), "Handmade Granite Ball" },
                    { 44, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=828", "2119415494", 398, false, 9, new DateOnly(2023, 4, 14), "Rustic Plastic Car" },
                    { 45, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=56", "3484624791", 207, false, 3, new DateOnly(2023, 6, 23), "Gorgeous Granite Keyboard" },
                    { 46, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=1073", "2841467811", 574, false, 10, new DateOnly(2023, 1, 26), "Fantastic Concrete Pants" },
                    { 47, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=297", "3474679719", 144, false, 19, new DateOnly(2023, 1, 19), "Generic Rubber Mouse" },
                    { 48, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=785", "6194044358", 440, false, 16, new DateOnly(2023, 7, 18), "Tasty Rubber Cheese" },
                    { 49, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=951", "3429046523", 565, false, 4, new DateOnly(2022, 12, 30), "Awesome Plastic Ball" },
                    { 50, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=356", "8553736980", 880, false, 2, new DateOnly(2023, 11, 23), "Generic Wooden Sausages" }
                });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId", "Id" },
                values: new object[,]
                {
                    { 3, 1, 71 },
                    { 2, 2, 3 },
                    { 9, 4, 21 },
                    { 1, 5, 28 },
                    { 8, 6, 16 },
                    { 1, 7, 13 },
                    { 14, 7, 67 },
                    { 1, 8, 73 },
                    { 12, 8, 12 },
                    { 15, 8, 55 },
                    { 18, 8, 1 },
                    { 7, 9, 33 },
                    { 19, 9, 9 },
                    { 6, 10, 47 },
                    { 4, 11, 34 },
                    { 15, 11, 19 },
                    { 7, 12, 64 },
                    { 6, 13, 53 },
                    { 11, 13, 54 },
                    { 16, 13, 14 },
                    { 8, 16, 20 },
                    { 2, 17, 39 },
                    { 2, 18, 74 },
                    { 6, 19, 5 },
                    { 19, 20, 24 },
                    { 9, 21, 35 },
                    { 11, 21, 4 },
                    { 6, 23, 43 },
                    { 17, 24, 45 },
                    { 5, 26, 51 },
                    { 10, 26, 52 },
                    { 14, 26, 2 },
                    { 10, 27, 48 },
                    { 16, 27, 10 },
                    { 1, 28, 30 },
                    { 7, 31, 41 },
                    { 15, 31, 23 },
                    { 4, 32, 37 },
                    { 12, 32, 17 },
                    { 15, 32, 72 },
                    { 16, 32, 66 },
                    { 5, 33, 65 },
                    { 16, 33, 44 },
                    { 6, 34, 46 },
                    { 9, 34, 61 },
                    { 12, 34, 62 },
                    { 12, 35, 49 },
                    { 13, 35, 56 },
                    { 18, 35, 6 },
                    { 19, 35, 29 },
                    { 6, 36, 7 },
                    { 7, 36, 38 },
                    { 18, 36, 27 },
                    { 5, 37, 32 },
                    { 12, 38, 59 },
                    { 3, 39, 11 },
                    { 19, 39, 60 },
                    { 3, 40, 22 },
                    { 8, 40, 69 },
                    { 3, 41, 15 },
                    { 8, 42, 18 },
                    { 13, 42, 8 },
                    { 3, 44, 42 },
                    { 1, 45, 75 },
                    { 4, 45, 70 },
                    { 8, 46, 68 },
                    { 14, 46, 25 },
                    { 6, 47, 50 },
                    { 3, 48, 57 },
                    { 9, 49, 40 }
                });

            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "BookId", "CategoryId", "Id" },
                values: new object[,]
                {
                    { 1, 5, 30 },
                    { 1, 7, 23 },
                    { 1, 12, 75 },
                    { 4, 10, 61 },
                    { 4, 11, 38 },
                    { 5, 18, 3 },
                    { 6, 4, 72 },
                    { 7, 7, 70 },
                    { 7, 20, 2 },
                    { 8, 9, 18 },
                    { 9, 13, 68 },
                    { 10, 7, 21 },
                    { 10, 13, 54 },
                    { 10, 19, 33 },
                    { 11, 13, 22 },
                    { 13, 9, 62 },
                    { 15, 1, 43 },
                    { 15, 4, 55 },
                    { 15, 16, 58 },
                    { 17, 4, 14 },
                    { 17, 5, 45 },
                    { 18, 8, 57 },
                    { 18, 16, 48 },
                    { 20, 3, 56 },
                    { 20, 16, 67 },
                    { 20, 20, 42 },
                    { 22, 2, 50 },
                    { 22, 8, 74 },
                    { 22, 10, 64 },
                    { 22, 18, 8 },
                    { 23, 7, 51 },
                    { 24, 14, 6 },
                    { 24, 16, 46 },
                    { 26, 8, 31 },
                    { 27, 3, 63 },
                    { 27, 17, 39 },
                    { 28, 11, 4 },
                    { 28, 18, 20 },
                    { 28, 20, 49 },
                    { 30, 17, 7 },
                    { 32, 4, 5 },
                    { 33, 8, 1 },
                    { 33, 20, 35 },
                    { 35, 19, 28 },
                    { 36, 8, 27 },
                    { 37, 6, 65 },
                    { 37, 9, 15 },
                    { 38, 2, 37 },
                    { 38, 7, 47 },
                    { 39, 5, 32 },
                    { 39, 16, 25 },
                    { 40, 1, 17 },
                    { 41, 13, 69 },
                    { 42, 15, 11 },
                    { 43, 5, 71 },
                    { 43, 7, 73 },
                    { 43, 9, 44 },
                    { 43, 20, 53 },
                    { 45, 12, 34 },
                    { 45, 13, 40 },
                    { 46, 4, 36 },
                    { 46, 12, 24 },
                    { 47, 3, 60 },
                    { 47, 6, 9 },
                    { 47, 16, 52 },
                    { 48, 15, 41 },
                    { 49, 5, 29 },
                    { 49, 11, 66 },
                    { 50, 12, 16 },
                    { 50, 16, 19 },
                    { 50, 18, 13 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AuthorCategories_CategoryId",
                table: "AuthorCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_AuthorId",
                table: "BookAuthors",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BookCategories_CategoryId",
                table: "BookCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_BookId",
                table: "Ratings",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_ReviewId",
                table: "Ratings",
                column: "ReviewId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_ReviewId",
                table: "Reactions",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_UserId",
                table: "Reactions",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AuthorCategories");

            migrationBuilder.DropTable(
                name: "BookAuthors");

            migrationBuilder.DropTable(
                name: "BookCategories");

            migrationBuilder.DropTable(
                name: "DataVersions");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Reactions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
