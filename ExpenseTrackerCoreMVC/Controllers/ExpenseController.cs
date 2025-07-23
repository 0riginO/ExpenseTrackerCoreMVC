using ExpenseTrackerCoreMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTrackerCoreMVC.Controllers
{
	public class ExpenseController : Controller
	{
		// Readonly field to store the injected database context
		private readonly ExpenseTrackerCoreMVCDbContext _context;

		// Constructor that receives the DbContext via Dependency Injection
		public ExpenseController(ExpenseTrackerCoreMVCDbContext context)
		{ 
			_context = context; // Assign the injected context to the private field
		}
		public IActionResult Index()
		{
			return View();
		}
	}
}
