using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Linq;
using zeyad_maged_3025316.Data;
using zeyad_maged_3025316.DTOs.Basic;
using zeyad_maged_3025316.DTOs.BranchDTOs;
using zeyad_maged_3025316.Models;
using zeyad_maged_3025316.Repositories.Interfaces;

namespace zeyad_maged_3025316.Repositories.Concrete
{
    public class BranchRepo : IBranchRepo
    {
        private readonly AppDbContext _context;
        public BranchRepo(AppDbContext context)
        {
            _context = context;
        }

        public bool BranchDelete(int Id)
        {
            var search = _context.branches.FirstOrDefault(i => i.Id ==  Id);
            if (search == null)
            {
                return false;
            }
            _context.branches.Remove(search);
            _context.SaveChanges();
            return true;
        }

        public List<BranchGetDTO> BranchGet()
        {
            var lis = _context.branches
                .Include(x => x.customers)
                .ThenInclude(y => y.accounts)
                .Select(i => new BranchGetDTO
                {
                    Name = i.Name,
                    Location = i.Location,
                    customerAccount = _context.customers.Select(z => new DTOs.Merged.CustomerAccountDTO
                    {
                        Name = z.Name,
                        Email = z.Email,
                        PhoneNumber = z.PhoneNumber,
                        accounts = _context.Accounts.Select(o => new BasicAccountDTO
                        {
                            AccountNumber = o.AccountNumber,
                            Balance = o.Balance,
                        }).ToList()
                    }).ToList()
                }).ToList();
            if (lis.IsNullOrEmpty())
            {
                return null;
            }    
            return lis;
        }

        public bool BranchPost(BranchPostDTO dto)
        {
            var branch = new Branch
            {
                Name = dto.Name,
                Location = dto.Location,
                customers = dto.customers.Select(i => new Customer
                {
                    Name = i.Name,
                    Email = i.Email,
                    PhoneNumber = i.PhoneNumber
                }).ToList(),
            };
            if (branch == null)
            {
                return false;
            }
            _context.branches.Add(branch);
            _context.SaveChanges();
            return true;
        }

        public bool BranchPut(BranchPutDTO dto, int Id)
        {
            var search = _context.branches
                .Include(c => c.customers)
                .FirstOrDefault(i => i.Id == Id);

            if (search == null)
            {
                return false;
            }
            search.Location = dto.Location;
            search.Name = dto.Name;


            search.customers.Clear();

            foreach (var customer in dto.CustomerIDs)
            {
                var res = _context.customers.FirstOrDefault(i => i.Id == customer);
                if (res == null)
                {
                    return false;
                }
                search.customers.Add(res);
            }
            _context.SaveChanges();
            return true;

        }
    }
}
