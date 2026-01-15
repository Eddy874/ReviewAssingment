using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewAssignment
{
    internal abstract class Customer : ICustomer
    {
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public decimal DiscountAmount { get; protected set; }
        public string DiscountType { get; protected set; }

        protected int NumOfTransactions = 0;

        protected Customer(string first, string last, string type)
        {
            FirstName = first;
            LastName = last;
            DiscountAmount = 0;
            DiscountType = type;
        }

        // implemented abstractly
        public abstract void CalculateDiscountAmount();

        // implemented interface
        public void PrintName()
        {
            Console.WriteLine($"Customer Full Name: {FirstName} {LastName} - {DiscountType}");
        }

        public void SetDiscountAmount(decimal discount)
        {
            DiscountAmount = discount;
        }

        // Removed duplicate explicit interface implementations
    }
}