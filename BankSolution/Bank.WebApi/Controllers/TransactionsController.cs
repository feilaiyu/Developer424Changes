using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bank.Core.Entities;
using Bank.Infrastructure.Data;
using Bank.Core.Interfaces;

namespace Bank.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionService _service;

        public TransactionsController(ITransactionService transactionService)
        {
            _service = transactionService;
        }

        // GET: api/Transactions
        [HttpGet]
        public async Task<IReadOnlyList<Transaction>> GetTransaction()
        {
            return await _service.Get();
        }
    }
}
