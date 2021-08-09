using System;
using System.Collections.Generic;

namespace Constructors
{
    partial class program
    {
        static void Main(string[] args)
        {
            var customer = new customer(1, "Tavi");

            var order = new order();
            
            //The following will inistialize the Order but this is not a good practice since this is not the Job of the current class that we are in.
            //customer.Orders = new List<Customer.Order>();
            
            //The following will result in a NullReference error, Orders is not being initialized.
            // customer.Orders.Add(order);
            
            
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            
            
        }
    }
}