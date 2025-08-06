using ExpenseTrackerCoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTrackerCoreMVC.Data.Services
{
	public class CategoriesService : ICategoriesServices
	{
		private readonly ExpenseTrackerCoreMVCDbContext _context;
		public CategoriesService(ExpenseTrackerCoreMVCDbContext context)
		{
			_context = context;
		}
		public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
		{
			var categories = await _context.Categories.ToListAsync();
			return categories;
		}
		public async Task Add(Category category)
		{
			await _context.Categories.AddAsync(category);
			await _context.SaveChangesAsync();
		}
	}
}
