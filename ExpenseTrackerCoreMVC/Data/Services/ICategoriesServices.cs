using ExpenseTrackerCoreMVC.Models;

namespace ExpenseTrackerCoreMVC.Data.Services
{
	public interface ICategoriesServices
	{
		Task<IEnumerable<Category>> GetAllCategoriesAsync();
		Task Add(Category category);
	}
}
