using Bank.Core.Entities;
using Bank.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Core.Services
{
    public class AccountService:IAccountService
    {
        private readonly IAsyncRepository<Account> _repository;
        public AccountService(IAsyncRepository<Account> accountRepository)
        {
            this._repository = accountRepository;
        }

        public Task Add(Account account)
        {
            return this._repository.AddAsync(account);
        }


        public Task Delete(int Id)
        {
            return this._repository.DeleteAsync(this._repository.GetByIdAsync(Id).Result);
        }

        public Task<IReadOnlyList<Account>> Get()
        {
            return this._repository.ListAllAsync();
        }

        public Task<Account> GetById(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public Task Update(Account account)
        {
            return _repository.UpdateAsync(account);
        }

    }
}
