using ExpenseTrackerCoreMVC.Data;
using ExpenseTrackerCoreMVC.Models;
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
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(Expense expense)
		{
			if (ModelState.IsValid)
			{ 
				_context.Expenses.Add(expense); // Add the new expense to the context
				_context.SaveChanges(); // Save changes to the database
				return RedirectToAction("Index"); // Redirect to the Index action after creation
			}
			return View();
		}
	}
}
