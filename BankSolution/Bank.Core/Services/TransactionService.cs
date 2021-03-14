using Bank.Core.Entities;
using Bank.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Core.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly IAsyncRepository<Transaction> _repository;
        public TransactionService(IAsyncRepository<Transaction> transactionRepository)
        {
            this._repository = transactionRepository;
        }
        public bool AddTransaction(Transaction transaction)
        {
            try
            {
                this._repository.AddAsync(transaction);
            }catch(Exception e)
            {
                return false;
            }
            return true;
            
        }

        public Task<IReadOnlyList<Transaction>> Get()
        {
            return this._repository.ListAllAsync();
        }
    }
}
