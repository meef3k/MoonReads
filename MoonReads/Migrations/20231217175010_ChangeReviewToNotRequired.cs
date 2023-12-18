using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoonReads.Migrations
{
    /// <inheritdoc />
    public partial class ChangeReviewToNotRequired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Reviews_ReviewId",
                table: "Ratings");

            migrationBuilder.AlterColumn<int>(
                name: "ReviewId",
                table: "Ratings",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=75", "Lenna Cartwright" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://picsum.photos/350/500/?image=475", "Giles Rippin" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=660", "Jaylan Daugherty" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=224", "Marvin Boyle" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=563", "Carroll Dickinson" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=898", "Maida Emard" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=322", "Ambrose Daniel" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=414", "Loyal O'Keefe" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=351", "Darrion Casper" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=870", "Eddie O'Reilly" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=231", "Juston Fisher" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://picsum.photos/350/500/?image=771", "Elmore Goodwin" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=215", "Jackeline Rippin" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=880", "Jarrett Howe" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=730", "Keanu Shanahan" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=193", "Jameson Steuber" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=529", "Nigel Marks" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=610", "Jessie Kassulke" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=499", "Johann Parker" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=710", "Beth Rutherford" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=990", "8295662816", 838, 9, new DateOnly(2023, 5, 26), "Incredible Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=825", "4017414471", 182, 17, new DateOnly(2023, 4, 19), "Ergonomic Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=667", "2401392678", 744, 2, new DateOnly(2023, 1, 30), "Incredible Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=462", "4143229587", 833, 7, new DateOnly(2023, 6, 3), "Small Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=836", "3967121541", 203, 14, new DateOnly(2023, 3, 23), "Sleek Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=298", "1281880349", 230, 13, new DateOnly(2023, 8, 28), "Intelligent Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "ReleaseDate", "Title" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=801", "9427323733", 557, new DateOnly(2023, 5, 31), "Rustic Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=499", "7623957898", 333, 19, new DateOnly(2023, 11, 8), "Unbranded Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=92", "9397224729", 631, 9, new DateOnly(2023, 3, 22), "Licensed Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=912", "4524557073", 882, 4, new DateOnly(2023, 2, 6), "Refined Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=761", "3631262931", 693, 3, new DateOnly(2023, 3, 2), "Fantastic Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=293", "5891154956", 572, 13, new DateOnly(2023, 1, 3), "Intelligent Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=610", "3299275144", 751, 13, new DateOnly(2023, 3, 25), "Generic Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "https://picsum.photos/350/500/?image=521", "9348181315", 857, 8, new DateOnly(2023, 7, 9), "Small Fresh Keyboard" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=897", "5383764441", 209, 20, new DateOnly(2023, 3, 6), "Sleek Rubber Bacon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=332", "3492808600", 427, 7, new DateOnly(2023, 4, 17), "Gorgeous Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=877", "4048430814", 435, 5, new DateOnly(2023, 8, 12), "Incredible Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=83", "7301717593", 746, 17, new DateOnly(2023, 12, 10), "Handcrafted Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=935", "6104630139", 607, 5, new DateOnly(2023, 9, 18), "Handmade Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "https://picsum.photos/350/500/?image=505", "8589412547", 267, 1, new DateOnly(2023, 8, 23), "Awesome Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=231", "6607467900", 817, 12, new DateOnly(2023, 3, 6), "Handmade Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=618", "1090916919", 602, 12, new DateOnly(2023, 1, 10), "Ergonomic Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "https://picsum.photos/350/500/?image=860", "3111782126", 281, 7, new DateOnly(2023, 9, 20), "Awesome Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=330", "6725404049", 632, 15, new DateOnly(2023, 8, 6), "Handmade Steel Tuna" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "https://picsum.photos/350/500/?image=444", "2080827621", 853, 8, new DateOnly(2023, 8, 9), "Practical Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=124", "3545492641", 266, 3, new DateOnly(2023, 4, 9), "Intelligent Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=1036", "5041763659", 674, 3, new DateOnly(2023, 2, 5), "Awesome Frozen Soap" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=745", "7783022275", 764, 9, new DateOnly(2023, 7, 30), "Rustic Soft Bike" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=139", "2378371821", 624, 13, new DateOnly(2023, 10, 29), "Awesome Cotton Gloves" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "https://picsum.photos/350/500/?image=1034", "5093057104", 116, 7, new DateOnly(2023, 7, 29), "Small Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=955", "6147389120", 294, 15, new DateOnly(2023, 8, 16), "Small Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=663", "2649295327", 434, 7, new DateOnly(2023, 6, 1), "Intelligent Concrete Sausages" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=898", "2611244732", 305, 12, new DateOnly(2023, 4, 22), "Sleek Granite Fish" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=768", "9732576425", 164, 14, new DateOnly(2023, 6, 13), "Ergonomic Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=740", "5371024675", 476, 20, new DateOnly(2023, 7, 4), "Generic Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=509", "9240141925", 316, 18, new DateOnly(2023, 10, 7), "Ergonomic Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "https://picsum.photos/350/500/?image=729", "3707351659", 620, 8, new DateOnly(2023, 2, 25), "Rustic Granite Chair" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=519", "9568866888", 752, 9, new DateOnly(2023, 7, 24), "Practical Concrete Sausages" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "https://picsum.photos/350/500/?image=148", "4164959370", 290, 3, new DateOnly(2023, 3, 20), "Handmade Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=6", "6634237547", 520, 14, new DateOnly(2023, 7, 6), "Rustic Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=287", "5508269232", 201, 8, new DateOnly(2023, 6, 19), "Handmade Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=672", "4963743103", 186, 15, new DateOnly(2023, 12, 10), "Handcrafted Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=654", "7247213297", 367, 10, new DateOnly(2023, 1, 14), "Rustic Granite Table" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=597", "6654502624", 287, 11, new DateOnly(2023, 7, 21), "Ergonomic Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=515", "2195126880", 441, 7, new DateOnly(2023, 9, 21), "Unbranded Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=183", "6757005228", 833, 12, new DateOnly(2023, 6, 18), "Rustic Soft Pizza" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=894", "2070925474", 425, 2, new DateOnly(2023, 2, 15), "Gorgeous Steel Fish" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=359", "5970143231", 320, 11, new DateOnly(2023, 7, 26), "Sleek Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=476", "7517941036", 368, 16, new DateOnly(2023, 3, 25), "Refined Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=852", "8854140843", 565, 7, new DateOnly(2023, 3, 14), "Intelligent Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Computers, Industrial & Grocery");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Games");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Health");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Music");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Home, Shoes & Outdoors");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Jewelery & Jewelery");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Automotive");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Games, Home & Baby");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Outdoors, Industrial & Books");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Jewelery, Books & Jewelery");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Garden, Jewelery & Grocery");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Music & Music");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Tools & Sports");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "Music");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "Baby");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Games & Movies");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Shoes");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "Health, Games & Home");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "Games, Toys & Movies");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "Name",
                value: "Automotive");

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=157", "Spencer, Dooley and Stiedemann" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=1051", "Price, Rosenbaum and Nolan" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=571", "Cassin - Blanda" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=78", "Schimmel Inc" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=1019", "Stracke - Gleason" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=534", "Mitchell, Dibbert and Jacobson" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=834", "Ortiz Group" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=835", "Conroy LLC" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=119", "Bosco, Johns and Johns" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=78", "Klocko, Zboncak and Fahey" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=910", "Keebler LLC" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=34", "Champlin - Heller" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=986", "Rippin Group" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=641", "Kertzmann - Armstrong" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=209", "Schneider LLC" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=1030", "Dibbert - Wuckert" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://picsum.photos/350/500/?image=455", "Schinner LLC" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=110", "Weber LLC" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=8", "Little, Herzog and Mraz" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=524", "Yundt, Zemlak and Graham" });

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Reviews_ReviewId",
                table: "Ratings",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Reviews_ReviewId",
                table: "Ratings");

            migrationBuilder.AlterColumn<int>(
                name: "ReviewId",
                table: "Ratings",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=749", "Kaylin Hirthe" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://picsum.photos/350/500/?image=297", "Deborah Sauer" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=679", "Patrick Weimann" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=719", "Jackie Green" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=837", "Antonia Waters" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=49", "Bertha Marvin" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=763", "Susan Littel" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=988", "Jaycee Larkin" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=63", "Rasheed Hyatt" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=345", "Lue Gibson" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=1007", "Rowena Schulist" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://picsum.photos/350/500/?image=687", "Vince Mills" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=732", "Eugenia Stokes" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=1073", "Shanie MacGyver" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=278", "Daniela Bartoletti" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=234", "Libby Spencer" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=74", "Roberta Ritchie" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=620", "Demarcus Brown" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=690", "Isai Schmitt" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=531", "Noble Harvey" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=466", "6030298605", 348, 18, new DateOnly(2023, 2, 12), "Ergonomic Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=919", "1514012349", 482, 7, new DateOnly(2023, 10, 7), "Generic Cotton Chips" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=723", "1765247628", 875, 11, new DateOnly(2023, 2, 24), "Fantastic Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=1051", "7569506372", 439, 8, new DateOnly(2023, 2, 6), "Tasty Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=56", "6098951446", 452, 9, new DateOnly(2023, 11, 11), "Tasty Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=625", "1073590732", 534, 8, new DateOnly(2023, 2, 25), "Handmade Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "ReleaseDate", "Title" },
                values: new object[] { "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=414", "1092020648", 249, new DateOnly(2023, 8, 14), "Practical Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=547", "7428364844", 455, 15, new DateOnly(2023, 7, 6), "Ergonomic Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=240", "9949631255", 121, 20, new DateOnly(2023, 4, 28), "Handmade Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=341", "9273179588", 619, 20, new DateOnly(2023, 4, 2), "Gorgeous Metal Sausages" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=520", "2669592026", 719, 15, new DateOnly(2023, 9, 27), "Awesome Plastic Bike" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=974", "5591813704", 287, 14, new DateOnly(2023, 10, 31), "Intelligent Wooden Keyboard" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=102", "5316171938", 648, 19, new DateOnly(2023, 7, 31), "Small Concrete Shoes" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "https://picsum.photos/350/500/?image=123", "7631378459", 520, 9, new DateOnly(2023, 10, 4), "Incredible Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=74", "5216664203", 476, 8, new DateOnly(2023, 3, 25), "Tasty Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=893", "4859256632", 353, 12, new DateOnly(2023, 5, 5), "Generic Soft Table" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=49", "5604270359", 242, 6, new DateOnly(2023, 5, 10), "Tasty Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=194", "4253805954", 829, 18, new DateOnly(2023, 2, 4), "Small Frozen Sausages" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=1035", "3626200130", 811, 19, new DateOnly(2023, 11, 23), "Small Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "https://picsum.photos/350/500/?image=223", "1083828989", 590, 3, new DateOnly(2023, 3, 24), "Handmade Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=17", "8085228730", 234, 9, new DateOnly(2023, 6, 18), "Practical Fresh Soap" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=581", "7814881124", 543, 19, new DateOnly(2023, 5, 28), "Unbranded Cotton Car" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "https://picsum.photos/350/500/?image=540", "6468451297", 385, 19, new DateOnly(2023, 9, 4), "Tasty Metal Chips" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=460", "8419990175", 884, 6, new DateOnly(2023, 3, 28), "Fantastic Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "https://picsum.photos/350/500/?image=909", "1345479458", 416, 11, new DateOnly(2023, 6, 11), "Licensed Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=516", "3387416626", 205, 1, new DateOnly(2023, 7, 24), "Gorgeous Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=340", "4257881849", 747, 2, new DateOnly(2023, 6, 15), "Small Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=587", "6622099832", 118, 10, new DateOnly(2023, 12, 4), "Generic Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=1006", "3553060187", 177, 5, new DateOnly(2023, 8, 19), "Unbranded Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "https://picsum.photos/350/500/?image=862", "5027154350", 190, 13, new DateOnly(2023, 2, 22), "Refined Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=962", "2258455548", 652, 3, new DateOnly(2023, 9, 26), "Incredible Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=895", "7841428666", 714, 6, new DateOnly(2023, 3, 10), "Handcrafted Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=381", "8360017949", 881, 17, new DateOnly(2023, 12, 13), "Fantastic Frozen Pants" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=625", "3086704550", 495, 16, new DateOnly(2023, 5, 9), "Refined Rubber Pizza" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=253", "5471498158", 623, 7, new DateOnly(2023, 3, 20), "Handcrafted Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=752", "5509140806", 630, 6, new DateOnly(2023, 1, 12), "Fantastic Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "https://picsum.photos/350/500/?image=201", "2677045551", 548, 4, new DateOnly(2023, 4, 22), "Handmade Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=271", "3613177107", 585, 4, new DateOnly(2023, 5, 9), "Rustic Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "https://picsum.photos/350/500/?image=1017", "4522412013", 707, 9, new DateOnly(2023, 12, 2), "Refined Wooden Table" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=111", "9512215388", 691, 15, new DateOnly(2023, 2, 11), "Handmade Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/350/500/?image=1061", "7370871067", 144, 6, new DateOnly(2023, 9, 15), "Handmade Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=571", "8499552444", 556, 3, new DateOnly(2023, 9, 3), "Small Wooden Shirt" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/350/500/?image=1053", "3716152315", 835, 4, new DateOnly(2023, 1, 11), "Handmade Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/350/500/?image=828", "2119415494", 398, 9, new DateOnly(2023, 4, 14), "Rustic Plastic Car" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=56", "3484624791", 207, 3, new DateOnly(2023, 6, 23), "Gorgeous Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=1073", "2841467811", 574, 10, new DateOnly(2023, 1, 26), "Fantastic Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=297", "3474679719", 144, 19, new DateOnly(2023, 1, 19), "Generic Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=785", "6194044358", 440, 16, new DateOnly(2023, 7, 18), "Tasty Rubber Cheese" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=951", "3429046523", 565, 4, new DateOnly(2022, 12, 30), "Awesome Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "ImageUrl", "Isbn", "Pages", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=356", "8553736980", 880, 2, new DateOnly(2023, 11, 23), "Generic Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Industrial, Jewelery & Grocery");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Jewelery & Sports");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Computers");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Sports");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Clothing, Electronics & Industrial");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Shoes");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Clothing");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Clothing & Beauty");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Kids & Kids");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Sports & Tools");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Home & Games");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Shoes, Toys & Books");

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
                value: "Toys & Health");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "Music");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Home & Outdoors");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Industrial, Electronics & Grocery");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "Garden");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "Computers");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "Name",
                value: "Garden, Books & Jewelery");

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/350/500/?image=1039", "Prosacco - Kuvalis" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=521", "Collins - Wilkinson" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=546", "Bode, Kohler and Abernathy" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=84", "Murphy, Bahringer and Witting" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/350/500/?image=637", "Reinger - Armstrong" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=467", "Ruecker Group" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=755", "Carter Group" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=230", "Erdman LLC" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/350/500/?image=677", "McDermott, Larkin and Langworth" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=935", "Luettgen - Braun" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/350/500/?image=202", "Torphy - Lehner" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=342", "Shanahan, Hahn and Cartwright" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/350/500/?image=36", "Johns LLC" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=954", "Orn, Heller and Grady" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=678", "Rempel - Fay" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/350/500/?image=431", "Kiehn and Sons" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://picsum.photos/350/500/?image=250", "Stracke - Schimmel" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/350/500/?image=625", "Adams - Collins" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/350/500/?image=695", "Hickle - Hane" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/350/500/?image=886", "Sauer - Willms" });

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Reviews_ReviewId",
                table: "Ratings",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
