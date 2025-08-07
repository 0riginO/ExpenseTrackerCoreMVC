using ExpenseTrackerCoreMVC.Models;

namespace ExpenseTrackerCoreMVC.Data.Services
{
	public interface ICategoriesService
	{
		Task<IEnumerable<Category>> GetAllCategoriesAsync();
		Task Add(Category category);
		Task<Category> GetCategoryByIdAsync(int id);
		Task Update(int id, Category category);
		Task Delete(int id);
	}
}
