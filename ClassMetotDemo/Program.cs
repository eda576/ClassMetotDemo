using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            { 
                CustomerName ="Eda Nur",
                CustomerSurname = "Özaltın",
                CustomerId = "1001",
                CustomerAddress = "İstanbul"
                
            };

            Customer customer2 = new Customer();
            customer2.CustomerName = "Fikriye";
            customer2.CustomerSurname = "Özaltın";
            customer2.CustomerId = "1002";
            customer2.CustomerAddress = "İstanbul";

            Customer customer3 = new Customer();
            customer3.CustomerName = "Murat";
            customer3.CustomerSurname = "Özaltın";
            customer3.CustomerId = "1003";
            customer3.CustomerAddress = "İstanbul";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.Add(customer1);

            CustomerManager customerManager2 = new CustomerManager();
            customerManager1.Delate(customer2);

            CustomerManager customerManager3 = new CustomerManager();
            customerManager1.List(customers);








        }
    }
}
