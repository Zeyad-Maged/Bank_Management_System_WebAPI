using Microsoft.EntityFrameworkCore;
using zeyad_maged_3025316.Models;

namespace zeyad_maged_3025316.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .HasIndex(i => i.AccountNumber)
                .IsUnique();
            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Branch> branches { get; set; }
        public DbSet<BankCard> bankCards { get; set; }
    }
}
