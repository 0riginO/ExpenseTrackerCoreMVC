using ExpenseTrackerCoreMVC.Data;
using ExpenseTrackerCoreMVC.Data.Services;
using ExpenseTrackerCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTrackerCoreMVC.Controllers
{
	public class ExpensesController : Controller
	{
		// Readonly field to store the injected database context
		private readonly IExpensesService _expensesService;

		// Constructor that receives the DbContext via Dependency Injection
		public ExpensesController(IExpensesService expensesService)
		{
			_expensesService = expensesService; // Assign the injected context to the private field
		}
		public async Task<IActionResult> Index()
		{
			var expenses = await _expensesService.GetAllExpensesAsync(); // Fetch all expenses asynchronously
			return View(expenses);
		}
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(Expense expense)
		{
			if (ModelState.IsValid)
			{ 
				await _expensesService.Add(expense); // Add the new expense asynchronously
				return RedirectToAction("Index"); // Redirect to the Index action after creation
			}
			return View();
		}
	}
}
