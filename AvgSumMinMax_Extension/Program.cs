using System;
using MyLibrary2;
namespace MY_EXTENSION
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Size of Array:");
            int size=int.Parse(Console.ReadLine());
            int[] arr=new int[size];
            Console.Clear();
            Console.WriteLine("enter the elements");
            for(int i=0;i<size;i++)
            {
                
                arr[i]=int.Parse(Console.ReadLine());
            }
           
            Console.WriteLine($"Avrage:{arr.AVG()}\nSum:{arr.SUM()}\nMax Value:{arr.MAX()}\nMin Value:{arr.MIN()}");
        }
    }
}