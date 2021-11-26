using System;
using System.Collections.Generic;
using static System.Console;

public class Enums
{
    public static void Main(string[] args)
    {
        Customer customers = new Customer();
        customers = new Customer() { Name = "Mark", Gender = 1 };
        customers = new Customer() { Name = "Saly", Gender = 2 };
        List<Customer> cus = new List<Customer>();
        
        foreach (Customer customer in cus)
        {
            WriteLine(customer.Name, customer.Gender);
        }
    }
}

public class Customer
{
    public string Name { get; set; }
    public int Gender { get; set; }
    public Customer()
    {
        Name = "test";
    }
}
