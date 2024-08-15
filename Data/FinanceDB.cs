using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using DotNetEnv;

namespace FinanceTracker.Data
{
    public class FinanceDbContext : DbContext {
        protected readonly IConfiguration Configuration;

        private string connection_string = "Host=localhost;Database=finance_tracker;Username=admin;Password=admin";
        public FinanceDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
            DotNetEnv.Env.Load();
        }
        public DbSet<Models.User> Users { get; set; }       
         public DbSet<Models.Goal> Goals { get; set; }
        public DbSet<Models.Expense> Expenses { get; set; }
        public DbSet<Models.MonthlyExpense> MonthlyExpenses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseNpgsql(Configuration.GetConnectionString("CONNECTION_STRING"));
        }

    }
}