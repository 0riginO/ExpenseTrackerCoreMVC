using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExpenseTrackerCoreMVC.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateWithSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DateAdded", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Utilities" },
                    { 2, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Groceries" },
                    { 3, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Transportation" },
                    { 4, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Entertainment" },
                    { 5, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Education" },
                    { 6, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Healthcare" },
                    { 7, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Insurance" }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Amount", "CategoryId", "DateAdded", "Name" },
                values: new object[,]
                {
                    { 1, 1500.00m, 1, new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rent" },
                    { 2, 300.00m, 2, new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Groceries" },
                    { 3, 50.00m, 3, new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gasoline" },
                    { 4, 20.00m, 4, new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie Night" },
                    { 5, 100.00m, 5, new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Books" },
                    { 6, 200.00m, 6, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor's Visit" },
                    { 7, 100.00m, 7, new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Insurance Premium" },
                    { 8, 75.00m, 1, new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone Bill" },
                    { 9, 60.00m, 1, new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Water Bill" },
                    { 10, 120.00m, 1, new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Electricity" },
                    { 11, 25.00m, 2, new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Snacks" },
                    { 12, 400.00m, 2, new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Supermarket" },
                    { 13, 15.00m, 3, new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taxi" },
                    { 14, 10.00m, 3, new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bus Fare" },
                    { 15, 75.00m, 4, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Concert Ticket" },
                    { 16, 200.00m, 5, new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Online Course" },
                    { 17, 500.00m, 5, new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tuition Fee" },
                    { 18, 350.00m, 6, new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hospital Bill" },
                    { 19, 80.00m, 6, new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Medicine" },
                    { 20, 150.00m, 6, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dental Checkup" },
                    { 21, 250.00m, 7, new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Car Insurance" },
                    { 22, 180.00m, 7, new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Health Insurance" },
                    { 23, 220.00m, 7, new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Home Insurance" },
                    { 24, 15.00m, 4, new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Streaming Service" },
                    { 25, 30.00m, 4, new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cinema" },
                    { 26, 40.00m, 5, new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stationery" },
                    { 27, 120.00m, 5, new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Workshop" },
                    { 28, 300.00m, 1, new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maintenance" },
                    { 29, 200.00m, 2, new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grocery Refill" },
                    { 30, 50.00m, 6, new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gym Membership" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 30);

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
        }
    }
}
