using System;

namespace Day3_Hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri customer1 = new Musteri(); //general customer information
            customer1.ıd = 1234;
            customer1.customerName = " ab ";
            customer1.customerSurname = " cd ";
            customer1.creditRanked = 0.45;

            Musteri customer2 = new Musteri(); //general customer information
            customer2.ıd = 5678;
            customer2.customerName = " ef ";
            customer2.customerSurname = " gh";
            customer2.creditRanked = 0.32;

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            customerManager.Remove(customer1);
            customerManager.Remove(customer2);

            Musteri[] musteriler = new Musteri[] { customer1, customer2 }; //for listing
            foreach (Musteri customer in musteriler)
            {
                Console.WriteLine(customer.customerName);
                Console.WriteLine(customer.customerSurname);
                Console.WriteLine(customer.ıd);
            }
        }
    }
}
