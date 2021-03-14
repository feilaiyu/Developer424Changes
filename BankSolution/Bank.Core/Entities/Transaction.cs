using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Core.Entities
{
    public class Transaction:BaseEntity
    {
        public float Amount { get; set; }

        public DateTime Date { get; set; }
        public int FromAccountId { get; set; }
        public int ToAccountId { get; set; }

        [ForeignKey("FromAccountId")]
        public virtual Account FromAccount { get; set; }
        [ForeignKey("ToAccountId")]
        public virtual Account ToAccount { get; set; }

        public Transaction(float amount, DateTime date)
        {
            Amount = amount;
            Date = date;
        }
    }
}
