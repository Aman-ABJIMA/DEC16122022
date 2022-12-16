using System;
using MyLibrary;
namespace Extension
{
    class program
    {
        public static void Main(string[] args)
        {
            int n = 12345;
            int result=n.GetDigits();
            Console.WriteLine(result);

        }
    }
}