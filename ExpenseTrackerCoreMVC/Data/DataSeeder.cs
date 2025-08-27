using ExpenseTrackerCoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTrackerCoreMVC.Data
{
	public class DataSeeder
	{
		public static void SeedData(ModelBuilder modelBuilder)
		{
			var categories = new List<Category>
			{
				new Category { Id = 1, Name = "Utilities", DateAdded = new DateTime(2025, 1, 1) },
				new Category { Id = 2, Name = "Groceries", DateAdded = new DateTime(2025, 1, 1) },
				new Category { Id = 3, Name = "Transportation", DateAdded = new DateTime(2025, 1, 1) },
				new Category { Id = 4, Name = "Entertainment", DateAdded = new DateTime(2025, 1, 1) },
				new Category { Id = 5, Name = "Education", DateAdded = new DateTime(2025, 1, 1) },
				new Category { Id = 6, Name = "Healthcare", DateAdded = new DateTime(2025, 1, 1) },
				new Category { Id = 7, Name = "Insurance", DateAdded = new DateTime(2025, 1, 1) }
			};

			modelBuilder.Entity<Category>().HasData(categories);

			// Fixed static dates
			var expenses = new List<Expense>
			{
				new Expense { Id = 1, Name = "Rent", Amount = 1500.00M, CategoryId = 1, DateAdded = new DateTime(2025, 1, 2) },
				new Expense { Id = 2, Name = "Groceries", Amount = 300.00M, CategoryId = 2, DateAdded = new DateTime(2025, 1, 2) },
				new Expense { Id = 3, Name = "Gasoline", Amount = 50.00M, CategoryId = 3, DateAdded = new DateTime(2025, 1, 3) },
				new Expense { Id = 4, Name = "Movie Night", Amount = 20.00M, CategoryId = 4, DateAdded = new DateTime(2025, 1, 4) },
				new Expense { Id = 5, Name = "Books", Amount = 100.00M, CategoryId = 5, DateAdded = new DateTime(2025, 1, 5) },
				new Expense { Id = 6, Name = "Doctor's Visit", Amount = 200.00M, CategoryId = 6, DateAdded = new DateTime(2025, 1, 6) },
				new Expense { Id = 7, Name = "Insurance Premium", Amount = 100.00M, CategoryId = 7, DateAdded = new DateTime(2025, 1, 7) },
				new Expense { Id = 8, Name = "Phone Bill", Amount = 75.00M, CategoryId = 1, DateAdded = new DateTime(2025, 1, 8) },
				new Expense { Id = 9, Name = "Water Bill", Amount = 60.00M, CategoryId = 1, DateAdded = new DateTime(2025, 1, 9) },
				new Expense { Id = 10, Name = "Electricity", Amount = 120.00M, CategoryId = 1, DateAdded = new DateTime(2025, 1, 10) },
				new Expense { Id = 11, Name = "Snacks", Amount = 25.00M, CategoryId = 2, DateAdded = new DateTime(2025, 1, 11) },
				new Expense { Id = 12, Name = "Supermarket", Amount = 400.00M, CategoryId = 2, DateAdded = new DateTime(2025, 1, 12) },
				new Expense { Id = 13, Name = "Taxi", Amount = 15.00M, CategoryId = 3, DateAdded = new DateTime(2025, 1, 13) },
				new Expense { Id = 14, Name = "Bus Fare", Amount = 10.00M, CategoryId = 3, DateAdded = new DateTime(2025, 1, 14) },
				new Expense { Id = 15, Name = "Concert Ticket", Amount = 75.00M, CategoryId = 4, DateAdded = new DateTime(2025, 1, 15) },
				new Expense { Id = 16, Name = "Online Course", Amount = 200.00M, CategoryId = 5, DateAdded = new DateTime(2025, 1, 16) },
				new Expense { Id = 17, Name = "Tuition Fee", Amount = 500.00M, CategoryId = 5, DateAdded = new DateTime(2025, 1, 17) },
				new Expense { Id = 18, Name = "Hospital Bill", Amount = 350.00M, CategoryId = 6, DateAdded = new DateTime(2025, 1, 18) },
				new Expense { Id = 19, Name = "Medicine", Amount = 80.00M, CategoryId = 6, DateAdded = new DateTime(2025, 1, 19) },
				new Expense { Id = 20, Name = "Dental Checkup", Amount = 150.00M, CategoryId = 6, DateAdded = new DateTime(2025, 1, 20) },
				new Expense { Id = 21, Name = "Car Insurance", Amount = 250.00M, CategoryId = 7, DateAdded = new DateTime(2025, 1, 21) },
				new Expense { Id = 22, Name = "Health Insurance", Amount = 180.00M, CategoryId = 7, DateAdded = new DateTime(2025, 1, 22) },
				new Expense { Id = 23, Name = "Home Insurance", Amount = 220.00M, CategoryId = 7, DateAdded = new DateTime(2025, 1, 23) },
				new Expense { Id = 24, Name = "Streaming Service", Amount = 15.00M, CategoryId = 4, DateAdded = new DateTime(2025, 1, 24) },
				new Expense { Id = 25, Name = "Cinema", Amount = 30.00M, CategoryId = 4, DateAdded = new DateTime(2025, 1, 25) },
				new Expense { Id = 26, Name = "Stationery", Amount = 40.00M, CategoryId = 5, DateAdded = new DateTime(2025, 1, 26) },
				new Expense { Id = 27, Name = "Workshop", Amount = 120.00M, CategoryId = 5, DateAdded = new DateTime(2025, 1, 27) },
				new Expense { Id = 28, Name = "Maintenance", Amount = 300.00M, CategoryId = 1, DateAdded = new DateTime(2025, 1, 28) },
				new Expense { Id = 29, Name = "Grocery Refill", Amount = 200.00M, CategoryId = 2, DateAdded = new DateTime(2025, 1, 29) },
				new Expense { Id = 30, Name = "Gym Membership", Amount = 50.00M, CategoryId = 6, DateAdded = new DateTime(2025, 1, 30) }
			};

			modelBuilder.Entity<Expense>().HasData(expenses);
		}
	}
}
