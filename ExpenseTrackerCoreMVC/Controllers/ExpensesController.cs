using ExpenseTrackerCoreMVC.Data.Services;
using ExpenseTrackerCoreMVC.Models;
using ExpenseTrackerCoreMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTrackerCoreMVC.Controllers
{
	public class ExpensesController : Controller
	{
		private readonly IExpensesService _expensesService;
		private readonly ICategoriesService _categoriesService;

		public ExpensesController(IExpensesService expensesService, ICategoriesService categoriesService)
		{
			_expensesService = expensesService;
			_categoriesService = categoriesService;
		}
		public async Task<IActionResult> Index()
		{
			var expenses = await _expensesService.GetAllExpensesWithCategoriesAsync();
			return View(expenses);
		}
		public async Task<IActionResult> Create()
		{
			var categories = await _categoriesService.GetAllCategoriesAsync();

			var viewModel = new ExpenseAddEditFormViewModel
			{
				Expense = new Expense(),
				Categories = categories
			};

			return View(viewModel);
		}

		public async Task<IActionResult> Update(int id)
		{
			var categories = await _categoriesService.GetAllCategoriesAsync(); // Fetch the categories asynchronously
			var expense = await _expensesService.GetExpenseByIdAsync(id); // Fetch the expense by ID asynchronously

			var viewModel = new ExpenseAddEditFormViewModel
			{
				Expense = expense,
				Categories = categories
			};
			if (expense == null)
			{
				return NotFound(); // Return 404 if the expense is not found
			}
			return View(viewModel);
		}

		[HttpPost]
		public async Task<IActionResult> Create(Expense expense)
		{
			if (ModelState.IsValid)
			{
				await _expensesService.Add(expense); // Add the new expense asynchronously
				return RedirectToAction("Index"); // Redirect to the Index action after creation
			}
			else
			{
				return StatusCode(400, "Bad Request");
			}
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
