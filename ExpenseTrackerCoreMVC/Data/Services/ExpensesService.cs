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
		public async Task Add(Expense expense)
		{
			await _context.Expenses.AddAsync(expense);
			await _context.SaveChangesAsync();
		}
	}
}
