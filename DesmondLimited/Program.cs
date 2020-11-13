using System;
using System.Collections.Generic;
namespace DesmondLimited
{

    public delegate IList<decimal> InterestDel();// Declaring  delegate InterestDel  
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("James", "Stuart", "2251085646", "Accounts Manager", 84000M, 0.8, 8);
            Customer customer2 = new Customer("Nkanu", "Prince", "3065643768", "Programmer", 76000M, 0.7, 5);
            Customer customer3 = new Customer("Ivan", "Smith", "0000765454", "Animator", 60000M, 0.5, 4);
            Customer customer4 = new Customer("Karren", "Collins", "2256798453", "Media Specialist", 74000M, 0.8, 4);
            IList<Customer> customers = new List<Customer>(){customer1, customer2, customer3, customer4};
            Interest interest = new Interest(customers);
            InterestDel simpleinterestDel = interest.SimpleInterest; // instantiating the the delegate InterestDel. And passing a reference method
            InterestDel compoundInterestDel = interest.CompoundInterest;
            
            IList<decimal> simpleInterests = simpleinterestDel();
            IList<decimal> compoundInterests = compoundInterestDel();

           
            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine($"{customers[i]}\nSimple Interest: {simpleInterests[i]:C}\nCompound Interest: {compoundInterests[i]:C}\n");
            }
        }
    }
}
