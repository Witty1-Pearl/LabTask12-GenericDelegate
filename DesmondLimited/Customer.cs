using System;
namespace DesmondLimited
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AccountNum { get; set; }
        public string Occupation { get; set; }
        public decimal principal;
        public double rate;
        public int time;

        public Customer(string first, string last, string acctNum, string occupation, decimal principal, double rate,int time)
        {
            FirstName = first;
            LastName = last;
            AccountNum = acctNum;
            Occupation = occupation;
            Principal = principal;
            Rate = rate;
            Time = time;
        }

        public decimal Principal
        {
            get{return principal;}

            set{
                if (value > 0)
                {
                    principal = value;
                } else
                {
                    Console.WriteLine("Principal", value, "Must be greater than 0");
                }
            }
        }
        public double Rate
        {
            get{return rate;}

            set{
                if (value > 0 && value < 1)
                {
                    rate = value;
                } else
                {
                    Console.WriteLine("Rate", value, "Must be greater than 0");
                }
            }
        }

        public int Time
        {
            get{return time;}

            set{
                if (value > 0)
                {
                    time = value;
                } else
                {
                    Console.WriteLine("Time", value, "Must be greater than 0");
                }
            }
        }

        public override string ToString()
        {
            return $"Customer Name: {FirstName} {LastName}\nAccount Number: {AccountNum}\nOccupation: {Occupation}\n";
        }
    }
}