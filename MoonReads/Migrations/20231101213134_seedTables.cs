using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoonReads.Migrations
{
    /// <inheritdoc />
    public partial class seedTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Books_BookId",
                table: "Ratings");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "Ratings",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "BookCategories",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "BookAuthors",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "AuthorCategories",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=414", "Winfield Blanda" },
                    { 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=468", "Danika Ritchie" },
                    { 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=1015", "Annette Torp" },
                    { 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=537", "Augustus Metz" },
                    { 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=939", "Roxane Watsica" },
                    { 6, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=130", "Rubye Homenick" },
                    { 7, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=70", "Dock McLaughlin" },
                    { 8, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=957", "Roosevelt Jacobson" },
                    { 9, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=230", "Talia Gusikowski" },
                    { 10, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=1023", "Eleanora Kemmer" },
                    { 11, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=1083", "Elian Gutmann" },
                    { 12, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=531", "Levi Kassulke" },
                    { 13, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=583", "Collin Stehr" },
                    { 14, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=858", "Ferne Hegmann" },
                    { 15, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=778", "Casper Davis" },
                    { 16, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=126", "Maximo Kovacek" },
                    { 17, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=868", "Genoveva Stamm" },
                    { 18, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=61", "Deion Leffler" },
                    { 19, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=289", "Margarete Rogahn" },
                    { 20, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=824", "Rosalyn Donnelly" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Shoes, Health & Automotive" },
                    { 2, "Games & Industrial" },
                    { 3, "Automotive" },
                    { 4, "Jewelery & Industrial" },
                    { 5, "Clothing & Home" },
                    { 6, "Books" },
                    { 7, "Sports & Sports" },
                    { 8, "Computers, Outdoors & Sports" },
                    { 9, "Clothing & Garden" },
                    { 10, "Sports" },
                    { 11, "Movies, Books & Outdoors" },
                    { 12, "Baby" },
                    { 13, "Jewelery, Grocery & Industrial" },
                    { 14, "Grocery, Baby & Outdoors" },
                    { 15, "Movies, Automotive & Outdoors" },
                    { 16, "Outdoors, Movies & Movies" },
                    { 17, "Grocery, Baby & Sports" },
                    { 18, "Music, Outdoors & Garden" },
                    { 19, "Automotive" },
                    { 20, "Beauty, Toys & Grocery" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=554", "Murray, Mayert and Davis" },
                    { 2, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=23", "Cummerata, Zieme and Roob" },
                    { 3, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=325", "Ebert - Auer" },
                    { 4, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=339", "Dickinson - Lakin" },
                    { 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=481", "Osinski Inc" },
                    { 6, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=631", "Kiehn - Vandervort" },
                    { 7, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=148", "Pagac, Barton and Rempel" },
                    { 8, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=958", "Windler, Wolf and Kuhlman" },
                    { 9, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=70", "Kreiger Group" },
                    { 10, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=132", "Harber - Welch" },
                    { 11, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=341", "Terry Inc" },
                    { 12, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=721", "Greenholt, Ward and Douglas" },
                    { 13, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=1016", "Ward - Sauer" },
                    { 14, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=399", "Hayes Group" },
                    { 15, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=351", "Rice - Grant" },
                    { 16, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=707", "Bailey - Goodwin" },
                    { 17, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=191", "Hane - Rosenbaum" },
                    { 18, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=363", "Zieme, Conn and Larkin" },
                    { 19, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=543", "Konopelski, Cartwright and Kreiger" },
                    { 20, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=780", "Gulgowski, Rippin and Kuhic" }
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
                    { 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=1063", "5116426031", 539, 13, new DateOnly(2023, 4, 20), "Rustic Rubber Car" },
                    { 2, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=66", "8076820884", 615, 8, new DateOnly(2023, 2, 28), "Handcrafted Rubber Ball" },
                    { 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=95", "2599686854", 305, 1, new DateOnly(2023, 5, 28), "Fantastic Wooden Shoes" },
                    { 4, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=268", "7341218283", 480, 7, new DateOnly(2023, 10, 26), "Rustic Fresh Ball" },
                    { 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=623", "1608789223", 507, 9, new DateOnly(2023, 5, 27), "Practical Frozen Pizza" },
                    { 6, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=494", "4838863203", 683, 18, new DateOnly(2023, 3, 22), "Small Frozen Pizza" },
                    { 7, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=244", "4820678626", 317, 18, new DateOnly(2023, 7, 16), "Fantastic Wooden Cheese" },
                    { 8, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=408", "3758518032", 899, 20, new DateOnly(2022, 12, 16), "Fantastic Concrete Pants" },
                    { 9, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=959", "7386787998", 814, 16, new DateOnly(2023, 8, 2), "Gorgeous Plastic Pants" },
                    { 10, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=235", "8591468301", 169, 13, new DateOnly(2023, 1, 18), "Gorgeous Plastic Pizza" },
                    { 11, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=937", "8158790465", 176, 5, new DateOnly(2022, 12, 2), "Rustic Metal Pants" },
                    { 12, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=495", "1840870636", 363, 10, new DateOnly(2023, 3, 2), "Incredible Steel Towels" },
                    { 13, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=140", "4692203286", 228, 14, new DateOnly(2023, 10, 19), "Fantastic Frozen Chicken" },
                    { 14, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=503", "2322799178", 110, 8, new DateOnly(2023, 6, 20), "Rustic Concrete Bacon" },
                    { 15, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=993", "9544164996", 546, 17, new DateOnly(2022, 12, 11), "Gorgeous Fresh Keyboard" },
                    { 16, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=914", "4770406926", 429, 10, new DateOnly(2023, 7, 31), "Generic Granite Car" },
                    { 17, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=694", "4623002707", 493, 8, new DateOnly(2023, 4, 30), "Small Granite Shoes" },
                    { 18, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=174", "7873691400", 782, 3, new DateOnly(2023, 1, 5), "Rustic Wooden Computer" },
                    { 19, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=14", "6902603187", 633, 9, new DateOnly(2023, 7, 18), "Handmade Cotton Ball" },
                    { 20, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=522", "1997162859", 819, 7, new DateOnly(2023, 2, 21), "Refined Concrete Shoes" },
                    { 21, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=309", "5911425368", 734, 20, new DateOnly(2023, 7, 23), "Handmade Soft Shoes" },
                    { 22, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=294", "5680937265", 736, 6, new DateOnly(2023, 4, 18), "Unbranded Cotton Bike" },
                    { 23, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=362", "5630229609", 242, 18, new DateOnly(2022, 11, 21), "Licensed Soft Chicken" },
                    { 24, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=759", "9452938914", 259, 17, new DateOnly(2023, 3, 19), "Unbranded Soft Soap" },
                    { 25, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=507", "2271572739", 755, 7, new DateOnly(2022, 12, 26), "Tasty Cotton Keyboard" },
                    { 26, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=877", "4417043431", 184, 2, new DateOnly(2023, 6, 9), "Practical Wooden Keyboard" },
                    { 27, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=890", "7418187669", 673, 18, new DateOnly(2023, 2, 7), "Gorgeous Cotton Ball" },
                    { 28, "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=724", "4705722126", 301, 13, new DateOnly(2022, 11, 21), "Incredible Plastic Car" },
                    { 29, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=747", "3552133791", 645, 11, new DateOnly(2023, 6, 30), "Generic Soft Cheese" },
                    { 30, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=214", "8681842440", 781, 3, new DateOnly(2023, 9, 17), "Practical Metal Chair" },
                    { 31, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=297", "6824089466", 241, 13, new DateOnly(2023, 9, 17), "Gorgeous Metal Sausages" },
                    { 32, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=833", "5691580443", 153, 3, new DateOnly(2023, 6, 19), "Incredible Cotton Chicken" },
                    { 33, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=753", "6467909584", 643, 17, new DateOnly(2023, 6, 27), "Ergonomic Steel Soap" },
                    { 34, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=906", "1703955766", 324, 6, new DateOnly(2023, 9, 16), "Refined Steel Computer" },
                    { 35, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=785", "6711427050", 566, 17, new DateOnly(2023, 5, 16), "Generic Fresh Tuna" },
                    { 36, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=805", "1291406998", 853, 18, new DateOnly(2023, 9, 19), "Ergonomic Metal Tuna" },
                    { 37, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=392", "6165651878", 489, 19, new DateOnly(2023, 1, 7), "Rustic Metal Ball" },
                    { 38, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=497", "4594825120", 569, 11, new DateOnly(2022, 12, 28), "Licensed Frozen Chicken" },
                    { 39, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=622", "3597209169", 488, 12, new DateOnly(2023, 7, 22), "Handcrafted Plastic Bike" },
                    { 40, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=475", "5265475934", 887, 11, new DateOnly(2023, 5, 4), "Generic Frozen Ball" },
                    { 41, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=479", "9950206860", 843, 12, new DateOnly(2022, 11, 22), "Small Fresh Shirt" },
                    { 42, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=1074", "4549563358", 208, 17, new DateOnly(2022, 12, 2), "Gorgeous Wooden Keyboard" },
                    { 43, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=798", "8448548243", 242, 11, new DateOnly(2023, 8, 21), "Fantastic Metal Chips" },
                    { 44, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=153", "2635244535", 143, 8, new DateOnly(2023, 7, 3), "Small Granite Hat" },
                    { 45, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=234", "6638308376", 162, 20, new DateOnly(2023, 5, 22), "Tasty Metal Hat" },
                    { 46, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=336", "7298738324", 357, 18, new DateOnly(2023, 10, 6), "Fantastic Frozen Chair" },
                    { 47, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=814", "8520282119", 177, 4, new DateOnly(2023, 8, 1), "Awesome Metal Chips" },
                    { 48, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=158", "7657732813", 856, 5, new DateOnly(2023, 8, 18), "Intelligent Rubber Shirt" },
                    { 49, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=350", "6305380749", 834, 3, new DateOnly(2023, 9, 27), "Small Soft Fish" },
                    { 50, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=713", "3283670460", 417, 12, new DateOnly(2023, 1, 17), "Tasty Plastic Table" }
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
                    { 1, 33, 1 },
                    { 2, 33, 3 },
                    { 3, 50, 4 },
                    { 4, 13, 3 },
                    { 5, 1, 1 },
                    { 6, 24, 2 },
                    { 7, 24, 2 },
                    { 8, 25, 1 },
                    { 9, 46, 2 },
                    { 10, 16, 4 },
                    { 11, 33, 3 },
                    { 12, 50, 1 },
                    { 13, 31, 4 },
                    { 14, 23, 3 },
                    { 15, 34, 2 },
                    { 16, 16, 3 },
                    { 17, 34, 1 },
                    { 18, 33, 3 },
                    { 19, 22, 4 },
                    { 20, 7, 3 },
                    { 21, 28, 1 },
                    { 22, 8, 3 },
                    { 23, 30, 2 },
                    { 24, 37, 3 },
                    { 25, 15, 2 },
                    { 26, 37, 3 },
                    { 27, 45, 5 },
                    { 28, 2, 3 },
                    { 29, 31, 4 },
                    { 30, 50, 1 },
                    { 31, 3, 1 },
                    { 32, 34, 3 },
                    { 33, 23, 4 },
                    { 34, 38, 1 },
                    { 35, 41, 2 },
                    { 36, 22, 4 },
                    { 37, 50, 4 },
                    { 38, 25, 3 },
                    { 39, 19, 4 },
                    { 40, 9, 5 },
                    { 41, 38, 3 },
                    { 42, 17, 1 },
                    { 43, 4, 4 },
                    { 44, 14, 5 },
                    { 45, 28, 3 },
                    { 46, 17, 2 },
                    { 47, 23, 2 },
                    { 48, 29, 1 },
                    { 49, 41, 1 },
                    { 50, 45, 5 },
                    { 51, 17, 4 },
                    { 52, 32, 2 },
                    { 53, 9, 5 },
                    { 54, 8, 2 },
                    { 55, 23, 3 },
                    { 56, 18, 1 },
                    { 57, 34, 3 },
                    { 58, 1, 2 },
                    { 59, 20, 4 },
                    { 60, 45, 4 },
                    { 61, 9, 5 },
                    { 62, 14, 5 },
                    { 63, 47, 2 },
                    { 64, 34, 5 },
                    { 65, 33, 5 },
                    { 66, 39, 4 },
                    { 67, 10, 3 },
                    { 68, 42, 2 },
                    { 69, 11, 4 },
                    { 70, 25, 5 },
                    { 71, 13, 5 },
                    { 72, 30, 5 },
                    { 73, 6, 4 },
                    { 74, 14, 2 },
                    { 75, 27, 3 },
                    { 76, 9, 3 },
                    { 77, 28, 2 },
                    { 78, 27, 4 },
                    { 79, 5, 3 },
                    { 80, 45, 5 },
                    { 81, 34, 2 },
                    { 82, 29, 5 },
                    { 83, 32, 4 },
                    { 84, 41, 3 },
                    { 85, 7, 2 },
                    { 86, 34, 5 },
                    { 87, 37, 5 },
                    { 88, 7, 2 },
                    { 89, 11, 3 },
                    { 90, 6, 3 },
                    { 91, 4, 1 },
                    { 92, 28, 5 },
                    { 93, 38, 4 },
                    { 94, 24, 3 },
                    { 95, 19, 2 },
                    { 96, 30, 3 },
                    { 97, 44, 2 },
                    { 98, 40, 4 },
                    { 99, 18, 4 },
                    { 100, 32, 1 },
                    { 101, 22, 2 },
                    { 102, 33, 1 },
                    { 103, 20, 5 },
                    { 104, 37, 1 },
                    { 105, 42, 3 },
                    { 106, 9, 4 },
                    { 107, 40, 5 },
                    { 108, 30, 5 },
                    { 109, 12, 4 },
                    { 110, 39, 5 },
                    { 111, 25, 1 },
                    { 112, 45, 1 },
                    { 113, 1, 4 },
                    { 114, 42, 1 },
                    { 115, 10, 5 },
                    { 116, 2, 4 },
                    { 117, 6, 2 },
                    { 118, 33, 2 },
                    { 119, 31, 3 },
                    { 120, 32, 4 },
                    { 121, 24, 2 },
                    { 122, 2, 1 },
                    { 123, 27, 1 },
                    { 124, 20, 1 },
                    { 125, 2, 2 },
                    { 126, 3, 3 },
                    { 127, 1, 5 },
                    { 128, 42, 4 },
                    { 129, 42, 2 },
                    { 130, 4, 4 },
                    { 131, 2, 2 },
                    { 132, 26, 4 },
                    { 133, 25, 4 },
                    { 134, 39, 2 },
                    { 135, 4, 3 },
                    { 136, 27, 4 },
                    { 137, 9, 2 },
                    { 138, 38, 1 },
                    { 139, 5, 2 },
                    { 140, 16, 3 },
                    { 141, 44, 5 },
                    { 142, 45, 1 },
                    { 143, 36, 1 },
                    { 144, 36, 2 },
                    { 145, 28, 2 },
                    { 146, 19, 4 },
                    { 147, 29, 5 },
                    { 148, 40, 5 },
                    { 149, 25, 5 },
                    { 150, 12, 2 },
                    { 151, 17, 1 },
                    { 152, 10, 3 },
                    { 153, 30, 3 },
                    { 154, 12, 3 },
                    { 155, 17, 2 },
                    { 156, 18, 1 },
                    { 157, 38, 1 },
                    { 158, 11, 3 },
                    { 159, 2, 5 },
                    { 160, 39, 2 },
                    { 161, 22, 3 },
                    { 162, 28, 2 },
                    { 163, 21, 5 },
                    { 164, 27, 5 },
                    { 165, 37, 3 },
                    { 166, 37, 1 },
                    { 167, 27, 5 },
                    { 168, 21, 5 },
                    { 169, 49, 5 },
                    { 170, 14, 1 },
                    { 171, 49, 1 },
                    { 172, 19, 3 },
                    { 173, 6, 5 },
                    { 174, 31, 2 },
                    { 175, 12, 1 },
                    { 176, 2, 3 },
                    { 177, 17, 5 },
                    { 178, 9, 1 },
                    { 179, 15, 5 },
                    { 180, 40, 4 },
                    { 181, 40, 2 },
                    { 182, 45, 4 },
                    { 183, 36, 2 },
                    { 184, 21, 5 },
                    { 185, 48, 1 },
                    { 186, 34, 2 },
                    { 187, 18, 1 },
                    { 188, 18, 2 },
                    { 189, 34, 3 },
                    { 190, 50, 4 },
                    { 191, 45, 3 },
                    { 192, 35, 1 },
                    { 193, 9, 2 },
                    { 194, 4, 2 },
                    { 195, 48, 4 },
                    { 196, 13, 3 },
                    { 197, 12, 3 },
                    { 198, 3, 3 },
                    { 199, 36, 1 },
                    { 200, 28, 1 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Books_BookId",
                table: "Ratings",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Books_BookId",
                table: "Ratings");

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 6, 11 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 6, 18 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 7, 19 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 8, 11 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 10, 15 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 10, 18 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 11, 11 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 11, 14 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 11, 18 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 13, 3 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 13, 16 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 15, 7 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 15, 10 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 16, 8 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 16, 13 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 16, 19 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 17, 5 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 17, 11 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 17, 17 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 17, 20 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 18, 19 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 19, 4 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 19, 7 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 19, 11 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 20, 3 });

            migrationBuilder.DeleteData(
                table: "AuthorCategories",
                keyColumns: new[] { "AuthorId", "CategoryId" },
                keyValues: new object[] { 20, 4 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 12, 8 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 15, 8 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 18, 8 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 19, 9 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 15, 11 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 7, 12 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 6, 13 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 11, 13 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 16, 13 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 8, 16 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2, 17 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 6, 19 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 19, 20 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 9, 21 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 11, 21 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 6, 23 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 17, 24 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 5, 26 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 10, 26 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 14, 26 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 10, 27 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 16, 27 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 1, 28 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 7, 31 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 15, 31 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 4, 32 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 12, 32 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 15, 32 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 16, 32 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 5, 33 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 16, 33 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 6, 34 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 9, 34 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 12, 34 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 12, 35 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 13, 35 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 18, 35 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 19, 35 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 6, 36 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 7, 36 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 18, 36 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 5, 37 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 12, 38 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 3, 39 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 19, 39 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 3, 40 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 8, 40 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 3, 41 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 8, 42 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 13, 42 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 3, 44 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 1, 45 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 4, 45 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 8, 46 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 14, 46 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 6, 47 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 3, 48 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 9, 49 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 5, 18 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 7, 20 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 8, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 9, 13 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 10, 13 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 10, 19 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 11, 13 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 13, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 15, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 15, 16 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 17, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 17, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 18, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 18, 16 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 20, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 20, 16 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 20, 20 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 22, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 22, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 22, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 22, 18 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 23, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 24, 14 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 24, 16 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 26, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 27, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 27, 17 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 28, 11 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 28, 18 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 28, 20 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 30, 17 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 32, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 33, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 33, 20 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 35, 19 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 36, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 37, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 37, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 38, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 38, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 39, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 39, 16 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 40, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 41, 13 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 42, 15 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 43, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 43, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 43, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 43, 20 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 45, 12 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 45, 13 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 46, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 46, 12 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 47, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 47, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 47, 16 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 48, 15 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 49, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 49, 11 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 50, 12 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 50, 16 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 50, 18 });

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "BookCategories");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "BookAuthors");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AuthorCategories");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "Ratings",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Books_BookId",
                table: "Ratings",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id");
        }
    }
}
