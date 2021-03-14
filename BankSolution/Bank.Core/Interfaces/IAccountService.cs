using Bank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Core.Interfaces
{
    public interface IAccountService
    {
        Task Add(Account account);
        Task<Account> GetById(int id);
        Task<IReadOnlyList<Account>> Get();
        Task Delete(int Id);
        Task Update(Account account);
    }
}
