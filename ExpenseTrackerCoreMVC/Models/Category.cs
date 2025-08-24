using System.ComponentModel.DataAnnotations;

namespace ExpenseTrackerCoreMVC.Models
{
	public class Category
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; } = string.Empty;
		public DateTime DateAdded { get; set; } = DateTime.Now;

		public ICollection<Expense> Expenses { get; set; }
	}
}
