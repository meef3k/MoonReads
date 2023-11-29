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
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
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
                    BookId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    AuthorId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ratings_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ratings_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: false),
                    BookId = table.Column<int>(type: "integer", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviews_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ReviewRatings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Rate = table.Column<bool>(type: "boolean", nullable: false),
                    ReviewId = table.Column<int>(type: "integer", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewRatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReviewRatings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReviewRatings_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=95", "Orpha Bode" },
                    { 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=317", "Summer Gutkowski" },
                    { 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=680", "Dominic Langworth" },
                    { 4, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=672", "Kelvin Schamberger" },
                    { 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=464", "Ward Herman" },
                    { 6, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=1047", "Dudley Price" },
                    { 7, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=65", "Newell West" },
                    { 8, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=658", "Jackeline Hagenes" },
                    { 9, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=345", "Jeremie Hackett" },
                    { 10, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=483", "Garret Schowalter" },
                    { 11, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=1056", "Domingo O'Hara" },
                    { 12, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=1043", "Bernardo Feil" },
                    { 13, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=328", "Abigail Klein" },
                    { 14, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=761", "Loraine Langworth" },
                    { 15, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=824", "Werner Ullrich" },
                    { 16, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=1063", "Mazie Zieme" },
                    { 17, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=752", "Desiree Schmitt" },
                    { 18, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=701", "Olga Purdy" },
                    { 19, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=536", "Brendon O'Conner" },
                    { 20, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=188", "Sienna Mills" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Home" },
                    { 2, "Industrial & Games" },
                    { 3, "Jewelery" },
                    { 4, "Tools & Books" },
                    { 5, "Shoes" },
                    { 6, "Home & Health" },
                    { 7, "Books" },
                    { 8, "Music, Jewelery & Computers" },
                    { 9, "Tools, Books & Automotive" },
                    { 10, "Industrial" },
                    { 11, "Health & Sports" },
                    { 12, "Garden, Books & Computers" },
                    { 13, "Grocery, Automotive & Toys" },
                    { 14, "Baby" },
                    { 15, "Automotive & Jewelery" },
                    { 16, "Jewelery, Beauty & Electronics" },
                    { 17, "Kids & Games" },
                    { 18, "Automotive & Shoes" },
                    { 19, "Music" },
                    { 20, "Computers & Garden" }
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
                    { 9, "Review", 0 },
                    { 10, "ReviewRatings", 0 }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=550", "Conn Group" },
                    { 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=271", "Hoppe - Schultz" },
                    { 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=560", "Kozey - Franecki" },
                    { 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=676", "Bergnaum LLC" },
                    { 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=1001", "Reinger, Kiehn and Carter" },
                    { 6, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=733", "Grant, Mertz and Klocko" },
                    { 7, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=293", "Goyette - Spinka" },
                    { 8, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=874", "Farrell Group" },
                    { 9, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=286", "Keebler - Macejkovic" },
                    { 10, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=430", "Swift Group" },
                    { 11, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=828", "Fadel - Runolfsdottir" },
                    { 12, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=66", "D'Amore Group" },
                    { 13, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=482", "Shanahan and Sons" },
                    { 14, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=290", "Johnston and Sons" },
                    { 15, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=827", "Considine, Swift and Feil" },
                    { 16, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=265", "Kautzer - Green" },
                    { 17, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=939", "Koelpin Group" },
                    { 18, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=954", "MacGyver Group" },
                    { 19, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=404", "Zulauf, Runolfsdottir and Lemke" },
                    { 20, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=888", "Nikolaus - Sporer" }
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
                columns: new[] { "Id", "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=611", "4306143309", 705, 8, new DateOnly(2023, 4, 20), "Refined Rubber Gloves" },
                    { 2, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=70", "8854330358", 308, 4, new DateOnly(2023, 9, 10), "Generic Frozen Table" },
                    { 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=1038", "2393537779", 518, 18, new DateOnly(2023, 6, 28), "Intelligent Frozen Gloves" },
                    { 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=1003", "4635504493", 696, 6, new DateOnly(2023, 3, 26), "Licensed Plastic Bike" },
                    { 5, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=625", "9112995498", 639, 15, new DateOnly(2023, 1, 19), "Unbranded Wooden Hat" },
                    { 6, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=758", "6288622803", 424, 3, new DateOnly(2023, 7, 8), "Awesome Fresh Hat" },
                    { 7, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=520", "9790046839", 174, 1, new DateOnly(2023, 2, 27), "Tasty Concrete Soap" },
                    { 8, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=934", "1852916230", 167, 12, new DateOnly(2023, 1, 9), "Fantastic Fresh Hat" },
                    { 9, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=400", "4150500287", 358, 1, new DateOnly(2023, 8, 14), "Fantastic Wooden Pizza" },
                    { 10, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=836", "6825215194", 238, 13, new DateOnly(2023, 5, 28), "Unbranded Metal Chicken" },
                    { 11, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=973", "1224977086", 274, 15, new DateOnly(2022, 12, 12), "Ergonomic Soft Chair" },
                    { 12, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=694", "4526652655", 143, 15, new DateOnly(2023, 4, 13), "Ergonomic Metal Computer" },
                    { 13, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=953", "5192561557", 382, 13, new DateOnly(2023, 1, 12), "Practical Concrete Bacon" },
                    { 14, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=174", "5475633640", 571, 19, new DateOnly(2023, 10, 18), "Incredible Cotton Keyboard" },
                    { 15, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=732", "2903351668", 738, 20, new DateOnly(2023, 8, 14), "Handcrafted Soft Keyboard" },
                    { 16, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=854", "6187745585", 182, 18, new DateOnly(2023, 8, 6), "Licensed Frozen Fish" },
                    { 17, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=692", "7861082958", 185, 16, new DateOnly(2023, 1, 4), "Rustic Granite Bacon" },
                    { 18, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=992", "4289309897", 431, 18, new DateOnly(2023, 3, 5), "Tasty Plastic Mouse" },
                    { 19, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=540", "9478770088", 891, 4, new DateOnly(2023, 3, 1), "Incredible Granite Chair" },
                    { 20, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=767", "1122453197", 535, 12, new DateOnly(2023, 3, 17), "Intelligent Fresh Tuna" },
                    { 21, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=692", "3055669072", 100, 2, new DateOnly(2023, 1, 15), "Tasty Wooden Chair" },
                    { 22, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=390", "5819904630", 110, 3, new DateOnly(2023, 10, 16), "Tasty Frozen Shirt" },
                    { 23, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=34", "2145658048", 214, 10, new DateOnly(2023, 6, 15), "Small Granite Mouse" },
                    { 24, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=303", "4355258324", 679, 13, new DateOnly(2023, 2, 19), "Ergonomic Rubber Fish" },
                    { 25, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=519", "7942268619", 216, 13, new DateOnly(2023, 8, 16), "Gorgeous Granite Bike" },
                    { 26, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=25", "1118710887", 638, 6, new DateOnly(2023, 8, 19), "Refined Cotton Bacon" },
                    { 27, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=447", "1350966208", 848, 2, new DateOnly(2023, 9, 22), "Rustic Soft Salad" },
                    { 28, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=707", "9227648600", 512, 16, new DateOnly(2023, 8, 26), "Handmade Concrete Towels" },
                    { 29, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=613", "9354283277", 313, 19, new DateOnly(2023, 3, 26), "Handmade Wooden Bacon" },
                    { 30, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=213", "9437972192", 859, 13, new DateOnly(2023, 4, 16), "Generic Steel Shirt" },
                    { 31, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=750", "4279818325", 881, 19, new DateOnly(2023, 5, 23), "Ergonomic Soft Fish" },
                    { 32, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=261", "4285330674", 742, 3, new DateOnly(2023, 8, 14), "Rustic Steel Bacon" },
                    { 33, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=751", "5593145756", 496, 15, new DateOnly(2023, 3, 15), "Intelligent Steel Cheese" },
                    { 34, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=883", "9836064795", 525, 18, new DateOnly(2023, 4, 11), "Handmade Frozen Keyboard" },
                    { 35, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=904", "9408407957", 273, 15, new DateOnly(2023, 4, 14), "Refined Plastic Keyboard" },
                    { 36, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=143", "3617332511", 200, 20, new DateOnly(2023, 10, 11), "Unbranded Soft Chicken" },
                    { 37, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=1078", "3993434959", 198, 12, new DateOnly(2023, 10, 4), "Incredible Wooden Bacon" },
                    { 38, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=537", "5668009075", 620, 9, new DateOnly(2023, 6, 17), "Licensed Concrete Keyboard" },
                    { 39, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=798", "8038909612", 427, 12, new DateOnly(2023, 10, 9), "Licensed Concrete Car" },
                    { 40, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=712", "7830817136", 702, 11, new DateOnly(2022, 12, 23), "Tasty Steel Ball" },
                    { 41, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=359", "4584614585", 661, 12, new DateOnly(2023, 4, 14), "Handcrafted Cotton Salad" },
                    { 42, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=221", "4859078052", 673, 6, new DateOnly(2023, 6, 20), "Intelligent Fresh Salad" },
                    { 43, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=544", "5613819535", 381, 15, new DateOnly(2023, 5, 7), "Gorgeous Metal Tuna" },
                    { 44, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=433", "9326296305", 664, 2, new DateOnly(2023, 10, 14), "Practical Cotton Fish" },
                    { 45, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=596", "3016533636", 872, 17, new DateOnly(2023, 1, 29), "Licensed Rubber Chips" },
                    { 46, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=737", "3381407959", 307, 2, new DateOnly(2023, 4, 6), "Intelligent Metal Chicken" },
                    { 47, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=636", "6752726042", 161, 19, new DateOnly(2023, 11, 13), "Practical Plastic Hat" },
                    { 48, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=690", "7137593144", 552, 8, new DateOnly(2023, 11, 6), "Fantastic Concrete Sausages" },
                    { 49, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=288", "9508191402", 168, 7, new DateOnly(2023, 9, 20), "Fantastic Plastic Cheese" },
                    { 50, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=245", "3725038993", 576, 9, new DateOnly(2023, 8, 17), "Rustic Plastic Gloves" }
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

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "AuthorId", "BookId", "Rate", "UserId" },
                values: new object[,]
                {
                    { 1, null, 38, 5, null },
                    { 2, null, 36, 5, null },
                    { 3, null, 33, 2, null },
                    { 4, null, 44, 3, null },
                    { 5, null, 32, 5, null },
                    { 6, null, 26, 4, null },
                    { 7, null, 16, 5, null },
                    { 8, null, 49, 3, null },
                    { 9, null, 5, 2, null },
                    { 10, null, 12, 1, null },
                    { 11, null, 33, 5, null },
                    { 12, null, 49, 1, null },
                    { 13, null, 8, 3, null },
                    { 14, null, 33, 2, null },
                    { 15, null, 47, 1, null },
                    { 16, null, 46, 5, null },
                    { 17, null, 24, 5, null },
                    { 18, null, 24, 4, null },
                    { 19, null, 27, 2, null },
                    { 20, null, 9, 5, null },
                    { 21, null, 2, 4, null },
                    { 22, null, 20, 1, null },
                    { 23, null, 3, 3, null },
                    { 24, null, 31, 5, null },
                    { 25, null, 35, 4, null },
                    { 26, null, 15, 3, null },
                    { 27, null, 31, 3, null },
                    { 28, null, 38, 2, null },
                    { 29, null, 32, 1, null },
                    { 30, null, 4, 4, null },
                    { 31, null, 19, 5, null },
                    { 32, null, 21, 3, null },
                    { 33, null, 11, 2, null },
                    { 34, null, 41, 1, null },
                    { 35, null, 38, 2, null },
                    { 36, null, 32, 1, null },
                    { 37, null, 13, 1, null },
                    { 38, null, 39, 5, null },
                    { 39, null, 46, 1, null },
                    { 40, null, 42, 2, null },
                    { 41, null, 13, 4, null },
                    { 42, null, 28, 1, null },
                    { 43, null, 27, 4, null },
                    { 44, null, 15, 3, null },
                    { 45, null, 20, 4, null },
                    { 46, null, 1, 2, null },
                    { 47, null, 29, 2, null },
                    { 48, null, 9, 4, null },
                    { 49, null, 3, 2, null },
                    { 50, null, 15, 3, null },
                    { 51, null, 25, 1, null },
                    { 52, null, 38, 5, null },
                    { 53, null, 20, 5, null },
                    { 54, null, 40, 5, null },
                    { 55, null, 4, 5, null },
                    { 56, null, 13, 5, null },
                    { 57, null, 42, 3, null },
                    { 58, null, 37, 5, null },
                    { 59, null, 18, 3, null },
                    { 60, null, 49, 5, null },
                    { 61, null, 26, 4, null },
                    { 62, null, 27, 4, null },
                    { 63, null, 24, 5, null },
                    { 64, null, 36, 2, null },
                    { 65, null, 27, 2, null },
                    { 66, null, 6, 4, null },
                    { 67, null, 4, 3, null },
                    { 68, null, 20, 3, null },
                    { 69, null, 23, 2, null },
                    { 70, null, 28, 2, null },
                    { 71, null, 16, 2, null },
                    { 72, null, 43, 2, null },
                    { 73, null, 49, 3, null },
                    { 74, null, 43, 2, null },
                    { 75, null, 37, 1, null },
                    { 76, null, 20, 1, null },
                    { 77, null, 39, 4, null },
                    { 78, null, 2, 3, null },
                    { 79, null, 30, 3, null },
                    { 80, null, 31, 1, null },
                    { 81, null, 35, 4, null },
                    { 82, null, 46, 3, null },
                    { 83, null, 33, 4, null },
                    { 84, null, 31, 4, null },
                    { 85, null, 29, 1, null },
                    { 86, null, 48, 1, null },
                    { 87, null, 37, 4, null },
                    { 88, null, 47, 5, null },
                    { 89, null, 20, 3, null },
                    { 90, null, 31, 3, null },
                    { 91, null, 23, 3, null },
                    { 92, null, 37, 3, null },
                    { 93, null, 25, 5, null },
                    { 94, null, 45, 4, null },
                    { 95, null, 8, 3, null },
                    { 96, null, 19, 1, null },
                    { 97, null, 19, 1, null },
                    { 98, null, 50, 2, null },
                    { 99, null, 48, 1, null },
                    { 100, null, 5, 3, null },
                    { 101, null, 8, 3, null },
                    { 102, null, 9, 5, null },
                    { 103, null, 39, 3, null },
                    { 104, null, 46, 4, null },
                    { 105, null, 47, 5, null },
                    { 106, null, 35, 1, null },
                    { 107, null, 43, 2, null },
                    { 108, null, 33, 5, null },
                    { 109, null, 44, 4, null },
                    { 110, null, 7, 2, null },
                    { 111, null, 12, 4, null },
                    { 112, null, 35, 5, null },
                    { 113, null, 48, 1, null },
                    { 114, null, 39, 1, null },
                    { 115, null, 11, 5, null },
                    { 116, null, 45, 1, null },
                    { 117, null, 12, 5, null },
                    { 118, null, 17, 2, null },
                    { 119, null, 11, 5, null },
                    { 120, null, 47, 4, null },
                    { 121, null, 7, 4, null },
                    { 122, null, 31, 5, null },
                    { 123, null, 38, 5, null },
                    { 124, null, 11, 2, null },
                    { 125, null, 29, 5, null },
                    { 126, null, 43, 2, null },
                    { 127, null, 40, 5, null },
                    { 128, null, 10, 5, null },
                    { 129, null, 39, 5, null },
                    { 130, null, 35, 5, null },
                    { 131, null, 3, 4, null },
                    { 132, null, 37, 1, null },
                    { 133, null, 34, 2, null },
                    { 134, null, 28, 3, null },
                    { 135, null, 41, 2, null },
                    { 136, null, 26, 3, null },
                    { 137, null, 39, 4, null },
                    { 138, null, 21, 5, null },
                    { 139, null, 9, 1, null },
                    { 140, null, 15, 2, null },
                    { 141, null, 8, 4, null },
                    { 142, null, 45, 1, null },
                    { 143, null, 28, 2, null },
                    { 144, null, 36, 1, null },
                    { 145, null, 24, 5, null },
                    { 146, null, 50, 4, null },
                    { 147, null, 35, 3, null },
                    { 148, null, 26, 5, null },
                    { 149, null, 26, 4, null },
                    { 150, null, 19, 4, null },
                    { 151, null, 41, 4, null },
                    { 152, null, 45, 2, null },
                    { 153, null, 46, 1, null },
                    { 154, null, 17, 3, null },
                    { 155, null, 14, 4, null },
                    { 156, null, 34, 2, null },
                    { 157, null, 41, 5, null },
                    { 158, null, 9, 3, null },
                    { 159, null, 14, 1, null },
                    { 160, null, 26, 2, null },
                    { 161, null, 21, 2, null },
                    { 162, null, 37, 1, null },
                    { 163, null, 43, 4, null },
                    { 164, null, 37, 1, null },
                    { 165, null, 2, 1, null },
                    { 166, null, 8, 1, null },
                    { 167, null, 17, 5, null },
                    { 168, null, 32, 5, null },
                    { 169, null, 25, 4, null },
                    { 170, null, 50, 1, null },
                    { 171, null, 11, 4, null },
                    { 172, null, 16, 2, null },
                    { 173, null, 5, 2, null },
                    { 174, null, 15, 2, null },
                    { 175, null, 40, 5, null },
                    { 176, null, 18, 5, null },
                    { 177, null, 38, 5, null },
                    { 178, null, 48, 5, null },
                    { 179, null, 10, 1, null },
                    { 180, null, 37, 3, null },
                    { 181, null, 5, 5, null },
                    { 182, null, 13, 1, null },
                    { 183, null, 49, 5, null },
                    { 184, null, 44, 4, null },
                    { 185, null, 39, 5, null },
                    { 186, null, 22, 3, null },
                    { 187, null, 17, 5, null },
                    { 188, null, 30, 1, null },
                    { 189, null, 23, 3, null },
                    { 190, null, 35, 2, null },
                    { 191, null, 35, 2, null },
                    { 192, null, 48, 4, null },
                    { 193, null, 35, 2, null },
                    { 194, null, 43, 3, null },
                    { 195, null, 3, 2, null },
                    { 196, null, 10, 1, null },
                    { 197, null, 29, 2, null },
                    { 198, null, 46, 3, null },
                    { 199, null, 39, 5, null },
                    { 200, null, 26, 2, null }
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
                name: "IX_Ratings_AuthorId",
                table: "Ratings",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_BookId",
                table: "Ratings",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewRatings_ReviewId",
                table: "ReviewRatings",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewRatings_UserId",
                table: "ReviewRatings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookId",
                table: "Reviews",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
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
                name: "ReviewRatings");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
