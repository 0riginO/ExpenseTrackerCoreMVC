using ExpenseTrackerCoreMVC.Models;

namespace ExpenseTrackerCoreMVC.Data.Services
{
	public interface ICategoriesService
	{
		Task<IEnumerable<Category>> GetAllCategoriesAsync();
		Task Add(Category category);
	}
}
