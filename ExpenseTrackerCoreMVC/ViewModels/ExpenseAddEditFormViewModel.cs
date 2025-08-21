using ExpenseTrackerCoreMVC.Models;

namespace ExpenseTrackerCoreMVC.ViewModels
{
	public class ExpenseAddEditFormViewModel
	{
		public Expense Expense { get; set; }
		public IEnumerable<Category> Categories { get; set; }
	}
}
