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
		[Required]
		public string Category { get; set; } = string.Empty;
		public DateTime DateAdded { get; set; } = DateTime.Now;
	}
}
