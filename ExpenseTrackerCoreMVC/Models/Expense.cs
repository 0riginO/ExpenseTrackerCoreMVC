using System.ComponentModel.DataAnnotations;

namespace ExpenseTrackerCoreMVC.Models
{
	public class Expense
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; } = string.Empty;
		[Required]
		[Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than zero.")]
		public decimal Amount { get; set; }

		// Foreign Key
		[Required]
		public int CategoryId { get; set; }

		// Navigation Property
		//public Category Category { get; set; }
		public DateTime DateAdded { get; set; } = DateTime.Now;
	}
}
