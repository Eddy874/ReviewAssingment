using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewAssignment
{
    internal interface ICustomer
    {
        //Contract for what methods a Customer should have
        void SetDiscountAmount(decimal discount);
        void PrintName();
        void CalculateDiscountAmount();
    }
}
