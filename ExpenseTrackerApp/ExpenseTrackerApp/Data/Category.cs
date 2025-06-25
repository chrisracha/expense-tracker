namespace ExpenseTrackerApp.Data
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? Name { get; set; }
        public ICollection<Expense>? Expenses { get; set; }

    }
}
