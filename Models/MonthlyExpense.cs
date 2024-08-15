namespace FinanceTracker.Models
{
    public class MonthlyExpense
    {
        public int Id { get; set; }
        public string ExpenseName { get; set; }
        public decimal ExpenseAmount { get; set; }
        public DateTime ExpenseDate { get; set; }
        public decimal LeftOwed { get; set; }
    }
}