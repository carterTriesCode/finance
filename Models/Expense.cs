namespace FinanceTracker.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string ExpenseName { get; set; }
        public decimal ExpenseAmount { get; set; }
        public DateTime ExpenseDate { get; set; }
    }
}