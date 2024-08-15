namespace FinanceTracker.Models;
public class Goal {
    public int Id { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public decimal TargetAmount { get; set; }
};

