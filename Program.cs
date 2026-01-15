namespace ReviewAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer eddy = new TrialCustomer("Eddy", "Hernandez");
            Customer balto = new PremiumCustomer("Balto", "Hernandez");
            Customer max = new ProCustomer("Max", "Hernandez");

            DoPurchases(eddy);
            DoPurchases(balto);
            DoPurchases(max);
        }

        static void DoPurchases(Customer customer)
        {
            Console.WriteLine("Starting Purchases");
            customer.PrintName();
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                // print resulting discount
                Console.WriteLine($"Customer's dicount amount is: {customer.DiscountAmount}");

                //do a purchase for the customer
                customer.CalculateDiscountAmount();
            }
        }
    }
}