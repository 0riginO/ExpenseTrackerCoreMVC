namespace ExpenseTrackerCoreMVC.Models
{
	public class Expense
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public decimal Amount { get; set; }
		public string Category { get; set; } = string.Empty;
		public DateTime DateAdded { get; set; } = DateTime.Now;
	}
}
