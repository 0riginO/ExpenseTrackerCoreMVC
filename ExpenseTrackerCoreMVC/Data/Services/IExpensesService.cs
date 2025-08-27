using ExpenseTrackerCoreMVC.Models;

namespace ExpenseTrackerCoreMVC.Data.Services
{
	public interface IExpensesService
	{
		Task<IEnumerable<Expense>> GetAllExpensesAsync();
		Task Add(Expense expense);
		Task Update(int id, Expense expense);
    	Task<Expense> GetExpenseByIdAsync(int id);
		Task Delete(int id);
		Task<IEnumerable<Expense>> GetAllExpensesWithCategoriesAsync();
		IQueryable GetExpensesGroupedByCategory();
		IQueryable GetExpensesSumByDate();
	}
}
