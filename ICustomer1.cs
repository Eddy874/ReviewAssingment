using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewAssignment
{
    internal interface ICustomer1
    {
        //Contract for what methods a customer should have
        void SetDiscountAmount(decimal discount);
        void PrintName();
        void CalculateDiscountAmount();
    }
}