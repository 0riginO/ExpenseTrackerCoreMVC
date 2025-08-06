using Microsoft.AspNetCore.Mvc;

namespace ExpenseTrackerCoreMVC.Controllers
{
	public class CategoriesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
