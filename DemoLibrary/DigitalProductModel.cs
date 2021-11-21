using System;
namespace DemoLibrary
{
    public class DigitalProductModel : IProductModel
    {
        public string Title { get; set; }
        public bool HasOrderBeenCompleted { get; private set; }
        public int TheNumhasbeenSent { get; private set; } = 5;

        public void ShipItem(CustomerModel customer)
        {
            if (TheNumhasbeenSent <1)
            {
                TheNumhasbeenSent = 0;
            }
            else
            {
                Console.WriteLine($"{Title} has been sent to {customer.EmailAddress}.");
                TheNumhasbeenSent -= 1;
            }
        }
    }
}
