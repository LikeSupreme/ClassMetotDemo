using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();

            customer1.customerId = 1;
            customer1.customerName = "Yusuf Eren";
            customer1.customerSurname = "Aydın";

            //Console.WriteLine(customer1.customerId + " Id numaralı müşteri " + customer1.customerName + " " + customer1.customerSurname);

            Customer customer2 = new Customer();

            customer2.customerId = 2;
            customer2.customerName = "John";
            customer2.customerSurname = "Doe";


            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
        }
    }
}
