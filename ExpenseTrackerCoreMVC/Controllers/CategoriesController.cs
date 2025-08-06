using Microsoft.AspNetCore.Mvc;
using ExpenseTrackerCoreMVC.Models;
using ExpenseTrackerCoreMVC.Data.Services;

namespace ExpenseTrackerCoreMVC.Controllers
{
	public class CategoriesController : Controller
	{
		// Readonly field to store the injected database context
		private readonly ICategoriesService _categoriesService;

		// Constructor that receives the DbContext via Dependency Injection
		public CategoriesController(ICategoriesService categoriesService)
		{
			_categoriesService = categoriesService; // Assign the injected context to the private field
		}

		public async Task<IActionResult> Index()
		{
			var categories = await _categoriesService.GetAllCategoriesAsync(); // Fetch all categories asynchronously
			return View(categories);
		}
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(Category category)
		{
			if (ModelState.IsValid)
			{ 
				await _categoriesService.Add(category); // Add the new category asynchronously
				return RedirectToAction("Index"); // Redirect to the Index action after creation
			}
			return View();
		}
	}
}
