using System;
using System.Collections.Generic;
namespace DesmondLimited
{
    public class Interest
    {
        public IList<Customer> Customers {get; set; } = new List<Customer>();

        public Interest(IList<Customer> customers)
        {
            Customers = customers;
        }

        

        public IList<decimal> SimpleInterest()// Declaring the method Simple Interest
        {
            IList<decimal> simpleInterests = new List<decimal>();
            foreach (var customer in Customers)
            {
                decimal interest = customer.Principal * (decimal)customer.Rate * (decimal)customer.Time;
                simpleInterests.Add(interest);
            }
            return simpleInterests;
        }
        public IList<decimal> CompoundInterest() // Declaring the method CompoundInterest
        {
            IList<decimal> compoundInterests = new List<decimal>();
            foreach (var customer in Customers)
            {
                decimal interest = customer.Principal * (decimal)(Math.Pow((1.0 + customer.Rate), (double)customer.Time));
                compoundInterests.Add(interest);
            }
            return compoundInterests;
        }

    }
}