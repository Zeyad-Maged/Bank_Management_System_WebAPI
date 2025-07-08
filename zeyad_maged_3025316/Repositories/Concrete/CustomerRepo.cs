using Microsoft.EntityFrameworkCore;
using zeyad_maged_3025316.Data;
using zeyad_maged_3025316.DTOs.CustomerDTOs;
using zeyad_maged_3025316.Models;
using zeyad_maged_3025316.Repositories.Interfaces;

namespace zeyad_maged_3025316.Repositories.Concrete
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly AppDbContext _context;
        public CustomerRepo(AppDbContext context)
        {
            _context = context;
        }

        public CustomerGetDTO CustomerGet(int Id)
        {
            var search = _context.customers
                .Include(x => x.branches)
                .Include(y => y.BankCard)
                .FirstOrDefault(i => i.Id == Id);
            if (search == null)
            {
                return null;
            }
            return new CustomerGetDTO
            {
                Name = search.Name,
                Email = search.Email,
                PhoneNumber = search.PhoneNumber,
                branches = search.branches.Select(i => new DTOs.Basic.BasicBranchDTO
                { 
                    Name = i.Name,
                    Location = i.Location
                }).ToList(),
                BankCard = new DTOs.Basic.BasicBankCardDTO
                {
                    ExpiryDate = search.BankCard.ExpiryDate,
                    CardNumber = search.BankCard.CardNumber
                }
            };
        }

        public bool CustomerPost(CustomerPostDTO dto)
        {
            var customer = new Customer
            {
                Name = dto.Name,
                Email = dto.Email,
                PhoneNumber = dto.PhoneNumber,
                branches = dto.branches.Select(i => new Branch
                {
                    Name = i.Name,
                    Location = i.Location
                }).ToList(),
                BankCard = new BankCard
                { 
                    CardNumber = dto.BankCard.CardNumber,
                    ExpiryDate = dto.BankCard.ExpiryDate
                },
                accounts = dto.accounts.Select(i => new Account
                {
                    AccountNumber = i.AccountNumber,
                    Balance = i.Balance,
                }).ToList()
            };
            if (customer == null)
            {
                return false;
            }
            _context.customers.Add(customer);
            _context.SaveChanges();
            return true;
        }
    }
}
