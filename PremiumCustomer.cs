using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewAssignment
{
    internal class PremiumCustomer : Customer
    {
        public PremiumCustomer(
            string first, //this is the first name (it is good to comment on your codes for self documentation)
            string last,
            string type = "Premium"
            ) : base(
                first,
                last,
                type

                )
        {
            DiscountAmount = 0.1m;
        }
        public override void CalculateDiscountAmount()
        {
            // increment transaction counter (start new transaction)
            NumOfTransactions++;


            Console.WriteLine("Performing new transaction for Trial Customer");
        }
    }
}