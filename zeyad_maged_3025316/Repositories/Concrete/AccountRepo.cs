using zeyad_maged_3025316.Data;
using zeyad_maged_3025316.DTOs.AccountDTOs;
using zeyad_maged_3025316.Models;
using zeyad_maged_3025316.Repositories.Interfaces;

namespace zeyad_maged_3025316.Repositories.Concrete
{
    public class AccountRepo : IAccountRepo
    {
        private readonly AppDbContext _context;
        public AccountRepo(AppDbContext context)
        {
            _context = context;
        }

        public bool AccountPost(AccountPostDTO dto, int CustomerId)
        {
            var search = _context.customers.FirstOrDefault(i => i.Id == CustomerId);
            if (search == null)
            {
                return false;
            }
            var account = new Account
            {
                AccountNumber = dto.AccountNumber,
                Balance = dto.Balance,
                CustomerId = CustomerId,
            };
            _context.Accounts.Add(account);
            _context.SaveChanges();
            return true;
        }
    }
}
