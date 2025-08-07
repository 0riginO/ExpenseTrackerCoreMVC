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
				existingExpense.Category = expense.Category;
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
	}
}
