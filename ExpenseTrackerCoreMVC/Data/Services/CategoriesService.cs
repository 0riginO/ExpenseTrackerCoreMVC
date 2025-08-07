using ExpenseTrackerCoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTrackerCoreMVC.Data.Services
{
	public class CategoriesService : ICategoriesService
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
		public async Task<Category> GetCategoryByIdAsync(int id)
		{
			return await _context.Categories.FindAsync(id);
		}
		public async Task Add(Category category)
		{
			await _context.Categories.AddAsync(category);
			await _context.SaveChangesAsync();
		}
		public async Task Update(int id, Category category)
		{
			var existingCategory = await _context.Categories.FindAsync(id);
			if (existingCategory != null)
			{
				existingCategory.Name = category.Name;
				await _context.SaveChangesAsync();
			}
		}
	}
}
