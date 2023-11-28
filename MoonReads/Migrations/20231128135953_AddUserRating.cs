using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoonReads.Migrations
{
    /// <inheritdoc />
    public partial class AddUserRating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Ratings",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=543", "Clarabelle Powlowski" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=775", "Quinn Considine" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=880", "Otto Maggio" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=244", "Lauriane Strosin" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=92", "Abner Heidenreich" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=1044", "Rhea Pfeffer" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=364", "Wilfredo Hodkiewicz" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=432", "Gabrielle Lakin" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=421", "Garfield Stamm" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=262", "Salvador Hansen" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=744", "Romaine Kling" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=378", "Kelly Hodkiewicz" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=167", "Dorcas Padberg" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=793", "Fern Brown" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=967", "Jerad Dickens" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://picsum.photos/350/500/?image=1051", "Trystan Von" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://picsum.photos/350/500/?image=683", "Jess Hamill" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=185", "Raymundo Langworth" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=840", "Elinore Farrell" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=1027", "Osborne Yundt" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=678", "3647882413", 495, 1, new DateOnly(2023, 10, 14), "Ergonomic Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=465", "6204562929", 667, 5, new DateOnly(2023, 3, 21), "Unbranded Granite Chair" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "https://picsum.photos/350/500/?image=1003", "9965829690", 638, 20, new DateOnly(2023, 11, 9), "Awesome Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "https://picsum.photos/350/500/?image=417", "8479933531", 309, 15, new DateOnly(2023, 1, 12), "Small Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=824", "8533057849", 455, 19, new DateOnly(2023, 10, 10), "Unbranded Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=740", "9028504587", 603, 3, new DateOnly(2023, 7, 18), "Handmade Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=30", "6430041216", 192, 5, new DateOnly(2023, 4, 1), "Licensed Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=482", "3743557381", 382, 2, new DateOnly(2023, 5, 12), "Practical Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=234", "7580080317", 645, 7, new DateOnly(2023, 7, 31), "Small Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl", "Isbn", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=324", "9533957770", 3, new DateOnly(2023, 11, 11), "Practical Frozen Cheese" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "https://picsum.photos/350/500/?image=439", "2617727738", 252, 3, new DateOnly(2023, 8, 25), "Incredible Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=222", "2796964504", 669, 9, new DateOnly(2023, 4, 23), "Handmade Cotton Car" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=726", "7857743640", 404, 6, new DateOnly(2023, 7, 22), "Generic Steel Pants" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=492", "7124188000", 740, 5, new DateOnly(2023, 8, 24), "Refined Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=645", "7496452604", 412, 13, new DateOnly(2023, 7, 16), "Incredible Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=1066", "9433105008", 249, 1, new DateOnly(2023, 10, 2), "Generic Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=993", "1966391637", 431, 5, new DateOnly(2023, 1, 22), "Incredible Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=605", "4972062050", 257, 2, new DateOnly(2023, 11, 12), "Incredible Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=793", "9468221975", 581, 17, new DateOnly(2023, 11, 18), "Handcrafted Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=66", "2927710904", 548, 4, new DateOnly(2023, 3, 15), "Ergonomic Steel Soap" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=1045", "1078714341", 267, 18, new DateOnly(2022, 12, 14), "Fantastic Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=171", "3748955621", 366, 12, new DateOnly(2023, 8, 27), "Practical Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=594", "5455457713", 858, 15, new DateOnly(2023, 7, 10), "Generic Plastic Table" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=639", "1158610975", 829, 11, new DateOnly(2023, 10, 2), "Handmade Plastic Sausages" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=341", "4043744599", 517, 11, new DateOnly(2022, 12, 13), "Intelligent Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=662", "3058998332", 775, 4, new DateOnly(2023, 2, 14), "Handmade Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=219", "6560438570", 831, 15, new DateOnly(2023, 10, 19), "Practical Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=308", "6488140409", 570, 17, new DateOnly(2023, 5, 12), "Licensed Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=761", "1977616391", 496, 9, new DateOnly(2023, 6, 27), "Unbranded Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=791", "7131907090", 518, 7, new DateOnly(2023, 7, 5), "Unbranded Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=948", "2696281133", 569, 12, new DateOnly(2023, 6, 27), "Gorgeous Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=718", "4303454238", 722, 11, new DateOnly(2023, 7, 10), "Sleek Metal Hat" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=57", "4418419754", 843, 19, new DateOnly(2023, 9, 11), "Licensed Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=658", "9493256417", 177, 10, new DateOnly(2023, 2, 28), "Tasty Frozen Pants" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=432", "9782623549", 700, 14, new DateOnly(2022, 12, 7), "Licensed Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=191", "3982094850", 638, 2, new DateOnly(2023, 10, 28), "Ergonomic Granite Table" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=642", "9611325269", 584, 15, new DateOnly(2023, 9, 18), "Licensed Wooden Shirt" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=551", "1728349789", 761, 9, new DateOnly(2023, 4, 14), "Ergonomic Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=879", "6200542125", 150, 15, new DateOnly(2023, 7, 27), "Intelligent Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=125", "6802645032", 615, 6, new DateOnly(2023, 3, 23), "Fantastic Soft Computer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=973", "6434249383", 688, 2, new DateOnly(2023, 5, 20), "Ergonomic Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=411", "9653716610", 472, 9, new DateOnly(2023, 4, 9), "Ergonomic Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=932", "4985725452", 392, 3, new DateOnly(2023, 7, 14), "Licensed Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=741", "4115069149", 344, 13, new DateOnly(2023, 11, 13), "Unbranded Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=610", "2375729096", 594, 19, new DateOnly(2023, 2, 19), "Handcrafted Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=381", "1372512397", 661, 15, new DateOnly(2023, 7, 7), "Handcrafted Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=795", "3992428934", 226, 5, new DateOnly(2023, 3, 17), "Fantastic Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=197", "4829840310", 623, 3, new DateOnly(2022, 12, 29), "Incredible Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "Title" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=1034", "8233836578", 611, 15, "Sleek Frozen Cheese" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=822", "3744033435", 531, 3, new DateOnly(2023, 10, 14), "Unbranded Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Baby, Health & Tools");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Games & Movies");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Industrial & Automotive");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Books & Clothing");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Clothing & Home");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Clothing");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Home, Toys & Games");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Home & Grocery");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Electronics, Kids & Kids");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Outdoors");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Electronics, Shoes & Toys");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Shoes & Baby");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Beauty");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "Games, Toys & Beauty");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "Beauty & Outdoors");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Tools, Tools & Movies");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Books, Games & Industrial");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "Industrial, Garden & Sports");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "Games");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "Name",
                value: "Tools & Books");

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=680", "Hessel, Weber and Doyle" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=388", "Cronin - Schuster" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://picsum.photos/350/500/?image=731", "Heller, Pollich and Ankunding" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=833", "Murphy - Hintz" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=678", "Rodriguez - Hahn" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://picsum.photos/350/500/?image=1021", "Schuster, Dickens and Jerde" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=386", "Connelly - Kerluke" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=76", "Balistreri - Dibbert" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=900", "Weissnat - Cole" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=479", "Carroll, O'Keefe and Nader" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=203", "Zieme - Conroy" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=760", "Deckow, Balistreri and Jacobson" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=925", "Dickinson and Sons" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=76", "Bailey, Friesen and Dickens" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=772", "Cummings, Skiles and Wilderman" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=113", "Windler - Keebler" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://picsum.photos/350/500/?image=279", "Reinger - Mertz" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=136", "Collier Inc" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=406", "Ryan - Daugherty" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=996", "Dare, Bechtelar and Dicki" });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 1, 1, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 4, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 16, 1, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 25, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 45, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 6, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 43, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 42, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 18, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 18, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 16, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 18, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 31, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 9, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 38, 1, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 29, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 25, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 48, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 3, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 10, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 13, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 4, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 38, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 40, 1, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 25, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 42, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 32, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 25, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 48, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 34, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 24, 1, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 47, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 24, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 32, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 30, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 48, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 42, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 34, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 7, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 35, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 36, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 30, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Rate", "UserId" },
                values: new object[] { 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 37, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 28, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 10, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 31, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 10, 1, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 44, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 22, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 22, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 19, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 35, 1, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 35, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 5, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 45, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 35, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 23, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 7, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 13, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 11, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 36, 1, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 24, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 33, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 10, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 27, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 8, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 18, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 32, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 41, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 4, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 31, 1, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 42, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 47, 1, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 34, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 43, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 30, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 45, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 3, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 14, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 32, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 30, 1, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 11, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 50, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 5, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 36, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 44, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 6, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 35, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 39, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 47, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 5, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 40, 1, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 31, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 2, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 30, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 36, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 38, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 6, 1, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 25, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 18, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 31, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 23, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 20, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 37, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 7, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 41, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 50, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 44, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 31, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 18, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 49, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Rate", "UserId" },
                values: new object[] { 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 33, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 29, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 15, 1, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 34, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 4, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 49, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 36, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 28, 1, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 21, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 28, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 6, 1, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 49, 1, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 11, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 3, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 21, 1, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 40, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 35, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 32, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 46, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 35, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 10, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 24, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 38, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 24, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 29, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 29, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 31, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 12, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 50, 1, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 18, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 28, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 44, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 10, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 2, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 28, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 2, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 12, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 40, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 36, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 19, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 49, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 27, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 4, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 8, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 28, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 14, 1, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 34, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 20, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 16, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 7, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 12, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 48, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 9, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 50, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 44, 1, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 45, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 170,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 16, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 47, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 11, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 40, 1, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 1, 1, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 48, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 8, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 21, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 7, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 1, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 50, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 50, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 2, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 2, 2, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 24, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 36, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 44, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 35, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 1, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 45, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 31, 1, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 37, 4, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 41, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 42, 5, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 24, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 3, 1, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 41, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 14, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 21, 3, null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "BookId", "Rate", "UserId" },
                values: new object[] { 22, 4, null });

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_AspNetUsers_UserId",
                table: "Ratings",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_AspNetUsers_UserId",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Ratings");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=179", "Stephan Gerlach" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=1075", "Tony Hilll" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=1017", "Carlos Bauch" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=599", "Everette Leffler" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=980", "Elissa McDermott" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=973", "Emmanuel Kulas" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=682", "Lupe Koepp" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=97", "Geoffrey Kling" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=451", "Keyon Leuschke" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=328", "Jovany Kertzmann" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=53", "Davon Purdy" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=993", "Erich Dicki" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=881", "Demario Kuvalis" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=605", "Elsa Konopelski" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=417", "Marianne Haley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://picsum.photos/350/500/?image=745", "Raina Mohr" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://picsum.photos/350/500/?image=717", "Sabryna Graham" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=132", "Caitlyn Bergnaum" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=784", "Osborne Rau" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=688", "Andrew Ernser" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=709", "5876265278", 571, 4, new DateOnly(2023, 7, 11), "Awesome Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=558", "2325691828", 105, 1, new DateOnly(2023, 10, 4), "Fantastic Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "https://picsum.photos/350/500/?image=32", "9214539889", 227, 10, new DateOnly(2022, 11, 29), "Intelligent Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "https://picsum.photos/350/500/?image=187", "7438322983", 361, 8, new DateOnly(2023, 1, 31), "Awesome Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=942", "4052797290", 590, 4, new DateOnly(2022, 12, 5), "Rustic Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=311", "7871363723", 300, 18, new DateOnly(2023, 11, 8), "Handmade Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=463", "1608003857", 502, 9, new DateOnly(2023, 8, 16), "Awesome Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=532", "8320410533", 900, 5, new DateOnly(2023, 5, 11), "Fantastic Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=28", "8814571823", 850, 15, new DateOnly(2022, 12, 25), "Sleek Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl", "Isbn", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=684", "3876124976", 6, new DateOnly(2023, 2, 8), "Practical Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "https://picsum.photos/350/500/?image=694", "6749458697", 375, 15, new DateOnly(2023, 8, 14), "Gorgeous Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=644", "9893135231", 740, 2, new DateOnly(2023, 8, 12), "Ergonomic Granite Salad" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=267", "2397420416", 496, 17, new DateOnly(2023, 4, 13), "Incredible Fresh Keyboard" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=59", "6706669335", 296, 9, new DateOnly(2023, 3, 3), "Ergonomic Fresh Chair" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=146", "3661067701", 841, 15, new DateOnly(2023, 5, 22), "Small Metal Shirt" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=303", "4176067537", 524, 18, new DateOnly(2023, 4, 13), "Practical Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=796", "9802943631", 737, 16, new DateOnly(2022, 12, 11), "Rustic Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=12", "1064415683", 141, 1, new DateOnly(2022, 12, 23), "Awesome Metal Hat" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=50", "9194191807", 740, 3, new DateOnly(2023, 8, 21), "Handcrafted Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=215", "7583681214", 713, 19, new DateOnly(2023, 9, 25), "Ergonomic Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=442", "1193584200", 123, 9, new DateOnly(2023, 9, 19), "Generic Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=692", "3520023524", 823, 6, new DateOnly(2023, 5, 10), "Fantastic Steel Towels" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=841", "8149567994", 250, 9, new DateOnly(2023, 5, 24), "Handcrafted Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=468", "6638390521", 803, 12, new DateOnly(2023, 5, 13), "Gorgeous Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=182", "6944971293", 601, 6, new DateOnly(2023, 4, 20), "Unbranded Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=0", "7032019327", 725, 1, new DateOnly(2022, 12, 22), "Gorgeous Steel Hat" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=637", "6044952160", 565, 10, new DateOnly(2022, 12, 6), "Fantastic Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=26", "9504334468", 618, 13, new DateOnly(2023, 10, 3), "Tasty Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=708", "5559070356", 849, 10, new DateOnly(2023, 11, 27), "Small Soft Computer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=1053", "1329933378", 861, 9, new DateOnly(2023, 2, 11), "Unbranded Concrete Shoes" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=514", "9843905751", 612, 6, new DateOnly(2023, 8, 15), "Fantastic Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=526", "6386208676", 646, 2, new DateOnly(2023, 5, 24), "Incredible Plastic Sausages" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=448", "6160638403", 505, 6, new DateOnly(2023, 7, 30), "Handcrafted Fresh Sausages" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=1035", "1480052519", 579, 8, new DateOnly(2023, 6, 11), "Refined Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=132", "2091264857", 282, 7, new DateOnly(2023, 6, 11), "Handcrafted Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=205", "3516856076", 681, 14, new DateOnly(2023, 2, 28), "Gorgeous Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=56", "4271775149", 142, 3, new DateOnly(2023, 6, 23), "Handcrafted Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=285", "2080387156", 638, 18, new DateOnly(2023, 5, 13), "Handcrafted Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=826", "3646360144", 403, 13, new DateOnly(2023, 4, 11), "Practical Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=770", "1815379465", 599, 11, new DateOnly(2023, 5, 13), "Gorgeous Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=788", "6680103695", 728, 6, new DateOnly(2022, 12, 16), "Handmade Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=823", "3839788592", 861, 19, new DateOnly(2023, 4, 30), "Rustic Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=1008", "4396015913", 227, 20, new DateOnly(2023, 8, 18), "Refined Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=727", "1585067238", 557, 9, new DateOnly(2023, 10, 14), "Awesome Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=98", "3827292794", 886, 17, new DateOnly(2023, 10, 26), "Ergonomic Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=289", "4748030300", 361, 9, new DateOnly(2022, 12, 13), "Practical Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=14", "3007231702", 685, 20, new DateOnly(2023, 2, 2), "Ergonomic Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=703", "3526826977", 626, 16, new DateOnly(2023, 2, 16), "Fantastic Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "Title" },
                values: new object[] { "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=252", "8466222887", 336, 9, "Tasty Steel Chair" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=158", "9255388104", 310, 7, new DateOnly(2023, 5, 3), "Incredible Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Automotive, Tools & Health");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Kids & Sports");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Shoes, Movies & Books");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Health & Industrial");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Clothing & Books");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Kids, Tools & Grocery");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Music & Sports");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Grocery & Outdoors");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Tools & Sports");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Automotive, Computers & Toys");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Tools");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Baby & Kids");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Jewelery & Outdoors");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "Home");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "Home");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Outdoors, Garden & Industrial");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Books & Baby");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "Tools");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "Sports");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "Name",
                value: "Games, Books & Automotive");

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=439", "Buckridge Inc" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=206", "Emard, O'Kon and Hills" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://picsum.photos/350/500/?image=369", "Rosenbaum, Hickle and Cremin" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=475", "Gaylord and Sons" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=590", "Leannon, Osinski and Jones" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://picsum.photos/350/500/?image=890", "Harris and Sons" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=293", "Corwin Group" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=705", "Willms Inc" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=904", "Lesch and Sons" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=262", "Stoltenberg, Pollich and Connelly" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=807", "Schinner, Hettinger and Brekke" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=211", "Fay, Flatley and D'Amore" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=614", "Kreiger, Stracke and Bins" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=248", "Mills, Hilpert and Hickle" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=163", "Goldner, Pacocha and Fahey" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=845", "Tremblay, Gutmann and Senger" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://picsum.photos/350/500/?image=963", "Bruen Inc" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=124", "Kunde - Collier" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=631", "Lemke, Abshire and McKenzie" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=1059", "Stiedemann Inc" });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 31, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 9, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 17, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 29, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 9, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 39, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 38, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 50, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 16, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 8, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 21, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 36, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 25, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 14,
                column: "BookId",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 35, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 44, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 19, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 18,
                column: "BookId",
                value: 36);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 15, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 7, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 18, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 48, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 36, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 45, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 39, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 49, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 27,
                column: "BookId",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 15, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 33, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 26, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 49, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 49, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 19, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 35,
                column: "BookId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 14, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 24, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 8, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 22, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 33, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 8, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 43,
                column: "Rate",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 17, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 37, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 46,
                column: "BookId",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 50, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 35, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 23, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 51,
                column: "BookId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 33, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 33, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 18, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 42, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 32, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 7, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 9, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 30, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 11, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 14, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 25, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 35, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 38, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 19, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 34, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 30, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 46, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 30, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 49, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 35, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 11, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 73,
                column: "BookId",
                value: 46);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 75,
                column: "BookId",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 11, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 77,
                column: "BookId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 25, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 35, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 47, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 21, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 26, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 8, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 8, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 49, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 34, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 21, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 45, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 28, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 30, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 34, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 26, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 15, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 40, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 48, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 23, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 7, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 100,
                column: "BookId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 22, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 24, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 103,
                column: "BookId",
                value: 48);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 24, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 105,
                column: "BookId",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 6, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 47, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 39, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 15, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 29, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 16, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 50, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 113,
                column: "Rate",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 6, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 115,
                column: "BookId",
                value: 49);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 40, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 33, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 39, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 7, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 120,
                column: "BookId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 6, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 20, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 10, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 27, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 50, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 31, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 31, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 6, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 129,
                column: "BookId",
                value: 38);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 48, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 131,
                column: "BookId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 13, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 48, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 13, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 42, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 28, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 9, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 139,
                column: "BookId",
                value: 34);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 40, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 31, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 11, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 24, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 144,
                column: "BookId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 48, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 30, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 18, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 43, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 33, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 31, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 12, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 14, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 30, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 43, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 46, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 18, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 18, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 6, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 43, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 23, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 162,
                column: "BookId",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 26, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 39, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 165,
                column: "BookId",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 166,
                column: "BookId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 13, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 25, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 31, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 172,
                column: "BookId",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 7, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 40, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 20, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 6, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 20, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 30, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 29, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 42, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 182,
                column: "BookId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 18, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 47, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 34, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 8, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 187,
                column: "BookId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 9, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 38, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 190,
                column: "BookId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 16, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 16, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 35, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 48, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 195,
                column: "BookId",
                value: 42);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 46, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 25, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 198,
                column: "BookId",
                value: 36);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 12, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "BookId", "Rate" },
                values: new object[] { 10, 3 });
        }
    }
}
