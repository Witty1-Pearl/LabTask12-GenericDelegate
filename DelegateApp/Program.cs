using System;

namespace DelegateApp
{
    public delegate string StrMyDel(string str);// Here I am creating the delegate strMyDel that takes one string parameter and returns a string.
    public delegate string ReverseDel(string str);

    class Program
    {
        static void Main(string[] args)
        {
            var testDel = new TestDelegate();
            StrMyDel strMyDel = testDel.Space;
            ReverseDel reverseDel = testDel.Reverse;
            Console.WriteLine(strMyDel("James"));
            Console.WriteLine(reverseDel("Stuart"));
        }
    }
}
