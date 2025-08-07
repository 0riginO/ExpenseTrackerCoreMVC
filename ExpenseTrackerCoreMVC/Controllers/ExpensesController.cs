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

		public async Task<IActionResult> Update(int id)
		{
			var expense = await _expensesService.GetExpenseByIdAsync(id); // Fetch the expense by ID asynchronously
			if (expense == null)
			{
				return NotFound(); // Return 404 if the expense is not found
			}
			return View(expense);
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
		[HttpPost]
		public async Task<IActionResult> Update(int id, Expense expense)
		{
			if (id != expense.Id)
			{
				return NotFound();
			}
			if (ModelState.IsValid)
			{
				await _expensesService.Update(id, expense); // Update the expense asynchronously
				return RedirectToAction("Index"); // Redirect to the Index action after update
			}
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Delete(int id)
		{
			var expense = await _expensesService.GetExpenseByIdAsync(id); // Fetch the expense by ID asynchronously
			if (expense == null)
			{
				return NotFound(); // Return 404 if the expense is not found
			}
			await _expensesService.Delete(id);
			return RedirectToAction("Index");
		}
	}
}
