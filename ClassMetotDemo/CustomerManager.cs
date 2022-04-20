using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {

        public void Add(Customer customer)
        {
            Console.WriteLine(customer.customerId + " Id numaralı müşteri " + customer.customerName + " " + customer.customerSurname + " müşterilere eklenmiştir.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.customerId + " Id numaralı müşteri " + customer.customerName + " " + customer.customerSurname + " müşterilerden çıkartılmıştır.");
        }

    }
}
