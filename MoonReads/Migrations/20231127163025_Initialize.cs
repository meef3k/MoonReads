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
                    BookId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=179", "Stephan Gerlach" },
                    { 2, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=1075", "Tony Hilll" },
                    { 3, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=1017", "Carlos Bauch" },
                    { 4, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=599", "Everette Leffler" },
                    { 5, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=980", "Elissa McDermott" },
                    { 6, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=973", "Emmanuel Kulas" },
                    { 7, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=682", "Lupe Koepp" },
                    { 8, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=97", "Geoffrey Kling" },
                    { 9, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=451", "Keyon Leuschke" },
                    { 10, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=328", "Jovany Kertzmann" },
                    { 11, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=53", "Davon Purdy" },
                    { 12, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=993", "Erich Dicki" },
                    { 13, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=881", "Demario Kuvalis" },
                    { 14, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=605", "Elsa Konopelski" },
                    { 15, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=417", "Marianne Haley" },
                    { 16, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=745", "Raina Mohr" },
                    { 17, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=717", "Sabryna Graham" },
                    { 18, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=132", "Caitlyn Bergnaum" },
                    { 19, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=784", "Osborne Rau" },
                    { 20, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=688", "Andrew Ernser" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Automotive, Tools & Health" },
                    { 2, "Kids & Sports" },
                    { 3, "Shoes, Movies & Books" },
                    { 4, "Health & Industrial" },
                    { 5, "Clothing & Books" },
                    { 6, "Kids, Tools & Grocery" },
                    { 7, "Music & Sports" },
                    { 8, "Grocery & Outdoors" },
                    { 9, "Tools & Sports" },
                    { 10, "Automotive, Computers & Toys" },
                    { 11, "Tools" },
                    { 12, "Baby & Kids" },
                    { 13, "Jewelery & Outdoors" },
                    { 14, "Home" },
                    { 15, "Home" },
                    { 16, "Outdoors, Garden & Industrial" },
                    { 17, "Books & Baby" },
                    { 18, "Tools" },
                    { 19, "Sports" },
                    { 20, "Games, Books & Automotive" }
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
                    { 8, "Ratings", 0 }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=439", "Buckridge Inc" },
                    { 2, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=206", "Emard, O'Kon and Hills" },
                    { 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=369", "Rosenbaum, Hickle and Cremin" },
                    { 4, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=475", "Gaylord and Sons" },
                    { 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=590", "Leannon, Osinski and Jones" },
                    { 6, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=890", "Harris and Sons" },
                    { 7, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=293", "Corwin Group" },
                    { 8, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=705", "Willms Inc" },
                    { 9, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=904", "Lesch and Sons" },
                    { 10, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=262", "Stoltenberg, Pollich and Connelly" },
                    { 11, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=807", "Schinner, Hettinger and Brekke" },
                    { 12, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=211", "Fay, Flatley and D'Amore" },
                    { 13, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=614", "Kreiger, Stracke and Bins" },
                    { 14, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=248", "Mills, Hilpert and Hickle" },
                    { 15, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=163", "Goldner, Pacocha and Fahey" },
                    { 16, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=845", "Tremblay, Gutmann and Senger" },
                    { 17, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=963", "Bruen Inc" },
                    { 18, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=124", "Kunde - Collier" },
                    { 19, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=631", "Lemke, Abshire and McKenzie" },
                    { 20, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=1059", "Stiedemann Inc" }
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
                    { 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=709", "5876265278", 571, 4, new DateOnly(2023, 7, 11), "Awesome Soft Mouse" },
                    { 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=558", "2325691828", 105, 1, new DateOnly(2023, 10, 4), "Fantastic Cotton Pants" },
                    { 3, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=32", "9214539889", 227, 10, new DateOnly(2022, 11, 29), "Intelligent Fresh Chicken" },
                    { 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=187", "7438322983", 361, 8, new DateOnly(2023, 1, 31), "Awesome Concrete Bike" },
                    { 5, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=942", "4052797290", 590, 4, new DateOnly(2022, 12, 5), "Rustic Concrete Table" },
                    { 6, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=311", "7871363723", 300, 18, new DateOnly(2023, 11, 8), "Handmade Concrete Salad" },
                    { 7, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=463", "1608003857", 502, 9, new DateOnly(2023, 8, 16), "Awesome Concrete Salad" },
                    { 8, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=532", "8320410533", 900, 5, new DateOnly(2023, 5, 11), "Fantastic Wooden Pizza" },
                    { 9, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=28", "8814571823", 850, 15, new DateOnly(2022, 12, 25), "Sleek Wooden Sausages" },
                    { 10, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=684", "3876124976", 181, 6, new DateOnly(2023, 2, 8), "Practical Cotton Sausages" },
                    { 11, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=694", "6749458697", 375, 15, new DateOnly(2023, 8, 14), "Gorgeous Cotton Table" },
                    { 12, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=644", "9893135231", 740, 2, new DateOnly(2023, 8, 12), "Ergonomic Granite Salad" },
                    { 13, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=267", "2397420416", 496, 17, new DateOnly(2023, 4, 13), "Incredible Fresh Keyboard" },
                    { 14, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=59", "6706669335", 296, 9, new DateOnly(2023, 3, 3), "Ergonomic Fresh Chair" },
                    { 15, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=146", "3661067701", 841, 15, new DateOnly(2023, 5, 22), "Small Metal Shirt" },
                    { 16, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=303", "4176067537", 524, 18, new DateOnly(2023, 4, 13), "Practical Wooden Shoes" },
                    { 17, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=796", "9802943631", 737, 16, new DateOnly(2022, 12, 11), "Rustic Fresh Bacon" },
                    { 18, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=12", "1064415683", 141, 1, new DateOnly(2022, 12, 23), "Awesome Metal Hat" },
                    { 19, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=50", "9194191807", 740, 3, new DateOnly(2023, 8, 21), "Handcrafted Concrete Salad" },
                    { 20, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=215", "7583681214", 713, 19, new DateOnly(2023, 9, 25), "Ergonomic Soft Towels" },
                    { 21, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=442", "1193584200", 123, 9, new DateOnly(2023, 9, 19), "Generic Plastic Pants" },
                    { 22, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=692", "3520023524", 823, 6, new DateOnly(2023, 5, 10), "Fantastic Steel Towels" },
                    { 23, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=841", "8149567994", 250, 9, new DateOnly(2023, 5, 24), "Handcrafted Steel Chicken" },
                    { 24, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=468", "6638390521", 803, 12, new DateOnly(2023, 5, 13), "Gorgeous Fresh Towels" },
                    { 25, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=182", "6944971293", 601, 6, new DateOnly(2023, 4, 20), "Unbranded Granite Gloves" },
                    { 26, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=0", "7032019327", 725, 1, new DateOnly(2022, 12, 22), "Gorgeous Steel Hat" },
                    { 27, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=637", "6044952160", 565, 10, new DateOnly(2022, 12, 6), "Fantastic Concrete Table" },
                    { 28, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=26", "9504334468", 618, 13, new DateOnly(2023, 10, 3), "Tasty Wooden Cheese" },
                    { 29, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=708", "5559070356", 849, 10, new DateOnly(2023, 11, 27), "Small Soft Computer" },
                    { 30, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=1053", "1329933378", 861, 9, new DateOnly(2023, 2, 11), "Unbranded Concrete Shoes" },
                    { 31, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=514", "9843905751", 612, 6, new DateOnly(2023, 8, 15), "Fantastic Frozen Chair" },
                    { 32, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=526", "6386208676", 646, 2, new DateOnly(2023, 5, 24), "Incredible Plastic Sausages" },
                    { 33, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=448", "6160638403", 505, 6, new DateOnly(2023, 7, 30), "Handcrafted Fresh Sausages" },
                    { 34, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=1035", "1480052519", 579, 8, new DateOnly(2023, 6, 11), "Refined Plastic Computer" },
                    { 35, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=132", "2091264857", 282, 7, new DateOnly(2023, 6, 11), "Handcrafted Rubber Keyboard" },
                    { 36, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=205", "3516856076", 681, 14, new DateOnly(2023, 2, 28), "Gorgeous Fresh Computer" },
                    { 37, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=56", "4271775149", 142, 3, new DateOnly(2023, 6, 23), "Handcrafted Fresh Car" },
                    { 38, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=285", "2080387156", 638, 18, new DateOnly(2023, 5, 13), "Handcrafted Cotton Salad" },
                    { 39, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=826", "3646360144", 403, 13, new DateOnly(2023, 4, 11), "Practical Wooden Car" },
                    { 40, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=770", "1815379465", 599, 11, new DateOnly(2023, 5, 13), "Gorgeous Frozen Fish" },
                    { 41, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=788", "6680103695", 728, 6, new DateOnly(2022, 12, 16), "Handmade Concrete Pants" },
                    { 42, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=823", "3839788592", 861, 19, new DateOnly(2023, 4, 30), "Rustic Plastic Pants" },
                    { 43, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=1008", "4396015913", 227, 20, new DateOnly(2023, 8, 18), "Refined Rubber Pants" },
                    { 44, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=727", "1585067238", 557, 9, new DateOnly(2023, 10, 14), "Awesome Wooden Towels" },
                    { 45, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=98", "3827292794", 886, 17, new DateOnly(2023, 10, 26), "Ergonomic Rubber Chips" },
                    { 46, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=289", "4748030300", 361, 9, new DateOnly(2022, 12, 13), "Practical Soft Mouse" },
                    { 47, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=14", "3007231702", 685, 20, new DateOnly(2023, 2, 2), "Ergonomic Plastic Chips" },
                    { 48, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=703", "3526826977", 626, 16, new DateOnly(2023, 2, 16), "Fantastic Metal Gloves" },
                    { 49, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=252", "8466222887", 336, 9, new DateOnly(2023, 4, 28), "Tasty Steel Chair" },
                    { 50, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=158", "9255388104", 310, 7, new DateOnly(2023, 5, 3), "Incredible Rubber Soap" }
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
                columns: new[] { "Id", "BookId", "Rate" },
                values: new object[,]
                {
                    { 1, 31, 3 },
                    { 2, 9, 1 },
                    { 3, 17, 4 },
                    { 4, 29, 3 },
                    { 5, 9, 2 },
                    { 6, 39, 2 },
                    { 7, 38, 1 },
                    { 8, 50, 1 },
                    { 9, 16, 1 },
                    { 10, 8, 4 },
                    { 11, 21, 1 },
                    { 12, 36, 2 },
                    { 13, 25, 2 },
                    { 14, 23, 2 },
                    { 15, 35, 2 },
                    { 16, 44, 2 },
                    { 17, 19, 1 },
                    { 18, 36, 1 },
                    { 19, 15, 1 },
                    { 20, 7, 1 },
                    { 21, 18, 1 },
                    { 22, 48, 1 },
                    { 23, 36, 2 },
                    { 24, 45, 3 },
                    { 25, 39, 2 },
                    { 26, 49, 1 },
                    { 27, 44, 2 },
                    { 28, 4, 4 },
                    { 29, 15, 3 },
                    { 30, 33, 5 },
                    { 31, 26, 5 },
                    { 32, 49, 1 },
                    { 33, 49, 4 },
                    { 34, 19, 4 },
                    { 35, 13, 4 },
                    { 36, 14, 1 },
                    { 37, 24, 1 },
                    { 38, 8, 5 },
                    { 39, 22, 4 },
                    { 40, 33, 4 },
                    { 41, 8, 2 },
                    { 42, 4, 1 },
                    { 43, 1, 4 },
                    { 44, 17, 2 },
                    { 45, 37, 1 },
                    { 46, 50, 2 },
                    { 47, 50, 1 },
                    { 48, 35, 4 },
                    { 49, 23, 3 },
                    { 50, 3, 2 },
                    { 51, 4, 2 },
                    { 52, 33, 3 },
                    { 53, 33, 2 },
                    { 54, 18, 3 },
                    { 55, 42, 5 },
                    { 56, 32, 3 },
                    { 57, 7, 5 },
                    { 58, 9, 4 },
                    { 59, 30, 2 },
                    { 60, 11, 1 },
                    { 61, 14, 1 },
                    { 62, 25, 5 },
                    { 63, 35, 5 },
                    { 64, 38, 4 },
                    { 65, 19, 2 },
                    { 66, 34, 4 },
                    { 67, 30, 1 },
                    { 68, 46, 5 },
                    { 69, 30, 1 },
                    { 70, 49, 1 },
                    { 71, 35, 1 },
                    { 72, 11, 3 },
                    { 73, 46, 1 },
                    { 74, 2, 3 },
                    { 75, 39, 3 },
                    { 76, 11, 3 },
                    { 77, 12, 3 },
                    { 78, 25, 2 },
                    { 79, 35, 3 },
                    { 80, 47, 2 },
                    { 81, 21, 1 },
                    { 82, 26, 3 },
                    { 83, 8, 3 },
                    { 84, 8, 1 },
                    { 85, 49, 5 },
                    { 86, 34, 5 },
                    { 87, 21, 2 },
                    { 88, 45, 5 },
                    { 89, 28, 2 },
                    { 90, 30, 1 },
                    { 91, 34, 1 },
                    { 92, 26, 5 },
                    { 93, 15, 2 },
                    { 94, 40, 4 },
                    { 95, 5, 2 },
                    { 96, 48, 1 },
                    { 97, 2, 1 },
                    { 98, 23, 3 },
                    { 99, 7, 5 },
                    { 100, 14, 4 },
                    { 101, 22, 4 },
                    { 102, 24, 4 },
                    { 103, 48, 2 },
                    { 104, 24, 5 },
                    { 105, 27, 2 },
                    { 106, 6, 4 },
                    { 107, 47, 5 },
                    { 108, 39, 4 },
                    { 109, 15, 1 },
                    { 110, 29, 5 },
                    { 111, 16, 1 },
                    { 112, 50, 1 },
                    { 113, 48, 3 },
                    { 114, 6, 1 },
                    { 115, 49, 4 },
                    { 116, 40, 5 },
                    { 117, 33, 4 },
                    { 118, 39, 2 },
                    { 119, 7, 4 },
                    { 120, 18, 4 },
                    { 121, 6, 3 },
                    { 122, 20, 5 },
                    { 123, 10, 2 },
                    { 124, 27, 4 },
                    { 125, 50, 3 },
                    { 126, 31, 5 },
                    { 127, 31, 1 },
                    { 128, 6, 4 },
                    { 129, 38, 4 },
                    { 130, 48, 1 },
                    { 131, 5, 4 },
                    { 132, 13, 1 },
                    { 133, 48, 5 },
                    { 134, 2, 1 },
                    { 135, 13, 4 },
                    { 136, 42, 1 },
                    { 137, 28, 1 },
                    { 138, 9, 5 },
                    { 139, 34, 5 },
                    { 140, 40, 5 },
                    { 141, 31, 5 },
                    { 142, 11, 3 },
                    { 143, 24, 4 },
                    { 144, 16, 1 },
                    { 145, 48, 3 },
                    { 146, 30, 4 },
                    { 147, 18, 5 },
                    { 148, 2, 4 },
                    { 149, 43, 5 },
                    { 150, 33, 1 },
                    { 151, 31, 2 },
                    { 152, 12, 2 },
                    { 153, 14, 3 },
                    { 154, 30, 3 },
                    { 155, 43, 3 },
                    { 156, 46, 1 },
                    { 157, 18, 2 },
                    { 158, 18, 3 },
                    { 159, 6, 3 },
                    { 160, 43, 4 },
                    { 161, 23, 1 },
                    { 162, 45, 2 },
                    { 163, 26, 2 },
                    { 164, 39, 3 },
                    { 165, 26, 1 },
                    { 166, 18, 5 },
                    { 167, 13, 1 },
                    { 168, 25, 4 },
                    { 169, 5, 1 },
                    { 170, 2, 5 },
                    { 171, 31, 5 },
                    { 172, 39, 1 },
                    { 173, 7, 3 },
                    { 174, 3, 4 },
                    { 175, 40, 3 },
                    { 176, 20, 5 },
                    { 177, 6, 4 },
                    { 178, 20, 5 },
                    { 179, 30, 3 },
                    { 180, 29, 1 },
                    { 181, 42, 4 },
                    { 182, 5, 2 },
                    { 183, 18, 2 },
                    { 184, 47, 3 },
                    { 185, 34, 1 },
                    { 186, 8, 2 },
                    { 187, 21, 3 },
                    { 188, 9, 5 },
                    { 189, 38, 1 },
                    { 190, 21, 4 },
                    { 191, 16, 3 },
                    { 192, 16, 5 },
                    { 193, 35, 1 },
                    { 194, 48, 2 },
                    { 195, 42, 2 },
                    { 196, 46, 5 },
                    { 197, 25, 5 },
                    { 198, 36, 1 },
                    { 199, 12, 4 },
                    { 200, 10, 3 }
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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
