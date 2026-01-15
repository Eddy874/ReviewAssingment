using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewAssignment
{
    internal class ProCustomer : Customer
    {
        private int DiscountUpperLimit = 5;

        public ProCustomer(string first, string last, string type = "ProCustomer") : base(first, last, type)
        {
            DiscountUpperLimit = 5;
        }

        public override void CalculateDiscountAmount()
        {
            // increment transaction counter (start new transaction)
            NumOfTransactions++;

            if (NumOfTransactions >= DiscountUpperLimit)
            {
                SetDiscountAmount(0.10m);
            }

            Console.WriteLine("Performing new transaction for Pro Customer");
            Console.WriteLine("Thank you for your purchase!");
        }
    }
}