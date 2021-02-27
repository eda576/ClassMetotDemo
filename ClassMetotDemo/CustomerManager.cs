using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurname + " " + " isimli ve "+ customer.CustomerId + "id numarasına ait müşteriniz ekelnmiştir.");
        }
        public void List(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.CustomerName + customer.CustomerSurname);
            }
        }
        public void Delate(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurname + " " + " isimli ve " + customer.CustomerId + "id numarasına ait müşteriniz silinmiştir.");
        }
    }
}
