using Microsoft.EntityFrameworkCore;
using ExpenseTrackerCoreMVC.Models;

namespace ExpenseTrackerCoreMVC.Data
{
	public class ExpenseTrackerCoreMVCDbContext : DbContext
	{
		public ExpenseTrackerCoreMVCDbContext(DbContextOptions<ExpenseTrackerCoreMVCDbContext> options) : base(options)
		{ 
		}

		public DbSet<Expense> Expenses { get; set; }
		public DbSet<Category> Categories { get; set; }


	}
}
