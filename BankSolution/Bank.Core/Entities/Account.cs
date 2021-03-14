using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Core.Entities
{
    public class Account:BaseEntity
    {

        public string Name { get; set; }

        public string Number { get; set; }

        public float Amount { get; set; }
        
    }
}
