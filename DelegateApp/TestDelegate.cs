using System.Collections.Generic;
namespace DelegateApp
{
    public class TestDelegate
    {
        public string Space(string str)// The space method will insert space between the input characters
        {
            string spaceInsert = "";
            foreach (var item in str)
            {
                spaceInsert += item + " ";
            }
            return spaceInsert;
        }

        public string Reverse( string str )// The reverse method will reverse the input string.
        {
            string result = "";
            Stack<char> reversed = new Stack<char>();// Stack is a special type of collection that stores elements in LIFO style (Last In First Out); It stores temporary data in LIFO style
            foreach (var item in str)
            {
                reversed.Push(item);// Push inserts an element at the top of the Stack
            }
            foreach (var item in reversed)
            {
                result += item;
            }
            return result;
        }
    }
}