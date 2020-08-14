using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BearCaveMVC2.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public DateTime Date { get; set; }
        public float Amount { get; set; }
        public string Type { get; set; } //type of transaction: Direct Debit, Standing Order, Cash

    }
}
