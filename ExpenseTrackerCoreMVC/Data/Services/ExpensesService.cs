using ExpenseTrackerCoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTrackerCoreMVC.Data.Services
{
	public class ExpensesService : IExpensesService
	{
		private readonly ExpenseTrackerCoreMVCDbContext _context;
		public ExpensesService(ExpenseTrackerCoreMVCDbContext context)
		{
			_context = context;
		}
		public async Task<IEnumerable<Expense>> GetAllExpensesAsync()
		{
			var expenses = await _context.Expenses.ToListAsync();
			return expenses;
		}
		public async Task<IEnumerable<Expense>> GetAllExpensesWithCategoriesAsync()
		{
			var expenses = await _context.Expenses.Include(e => e.Category).ToListAsync();
			return expenses;
		}
		public async Task<Expense> GetExpenseByIdAsync(int id)
		{
			return await _context.Expenses.FindAsync(id);
		}
		public async Task Add(Expense expense)
		{
			await _context.Expenses.AddAsync(expense);
			await _context.SaveChangesAsync();
		}
		public async Task Update(int id, Expense expense)
		{
			var existingExpense = await _context.Expenses.FindAsync(id);
			if (existingExpense != null)
			{
				existingExpense.Name = expense.Name;
				existingExpense.Amount = expense.Amount;
				existingExpense.CategoryId = expense.CategoryId;
				//existingExpense.DateAdded = DateTime.Now; // Update the date added to the current time

				await _context.SaveChangesAsync();
			}
		}
		public async Task Delete(int id)
		{
			var expense = await _context.Expenses.FindAsync(id);
			if (expense != null)
			{
				_context.Expenses.Remove(expense);
				await _context.SaveChangesAsync();
			}
		}

		public IQueryable GetExpensesGroupedByCategory()
		{
			return _context.Expenses
				.GroupBy(e => new { e.CategoryId, e.Category.Name })
				.Select(g => new
				{
					CategoryId = g.Key.CategoryId,
					CategoryName = g.Key.Name,
					TotalAmount = g.Sum(e => e.Amount)
					//ExpenseCount = g.Count()
				});
		}

		public IQueryable GetExpensesSumByDate()
		{
			return _context.Expenses
				.GroupBy(e => e.DateAdded)
				.Select(d => new
				{
					DateAdded = d.Key,
					TotalAmount = d.Sum(e => e.Amount)
				});
		}

		public IQueryable GetAvgExpensesByCategory()
		{
			return _context.Expenses
				.GroupBy(e => new { e.CategoryId, e.Category.Name })
				.Select(g => new
				{
					CategoryName = g.Key.Name,
					AverageAmount = g.Average(e => e.Amount)
				});
		}

		public IQueryable GetTopNExpensesByCategory(int num)
		{
			return _context.Expenses
				.GroupBy(e => new { e.CategoryId, e.Category.Name })
				.Select(g => new
				{
					CategoryName = g.Key.Name,
					TotalAmount = g.Sum(e => e.Amount)
				})
				.OrderByDescending(x => x.TotalAmount) // sort by total descending
				.Take(num); // get only top 5
		}

		public IQueryable GetExpenseFrequencyByCategory()
		{ 
			return _context.Expenses
				.GroupBy(e => new { e.CategoryId, e.Category.Name })
				.Select(g => new
				{
					CategoryName = g.Key.Name,
					ExpenseCount = g.Count()
				});
		}
	}
}
