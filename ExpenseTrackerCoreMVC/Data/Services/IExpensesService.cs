using ExpenseTrackerCoreMVC.Models;

namespace ExpenseTrackerCoreMVC.Data.Services
{
	public interface IExpensesService
	{
		Task<IEnumerable<Expense>> GetAllExpensesAsync();
		Task Add(Expense expense);
	}
}
