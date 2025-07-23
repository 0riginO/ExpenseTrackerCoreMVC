using ExpenseTrackerCoreMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTrackerCoreMVC.Controllers
{
	public class ExpensesController : Controller
	{
		// Readonly field to store the injected database context
		private readonly ExpenseTrackerCoreMVCDbContext _context;

		// Constructor that receives the DbContext via Dependency Injection
		public ExpensesController(ExpenseTrackerCoreMVCDbContext context)
		{ 
			_context = context; // Assign the injected context to the private field
		}
		public IActionResult Index()
		{
			var expenses = _context.Expenses.ToList();
			return View(expenses);
		}
	}
}
