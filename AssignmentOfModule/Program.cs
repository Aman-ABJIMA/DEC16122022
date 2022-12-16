using System;
namespace MAIN
{
    class Program
    {
        static void Main(string[] args)
        {

            const int Limit = 5;

            Queue<int> waitingLine = new Queue<int>();


            for (int j = 1; j <= 10; j++)
            {
                waitingLine.Enqueue(j);
                Console.WriteLine($"{j} queuing at bus stop");
            }



            Console.WriteLine("\nBus arriving at bus stop to load passengers");

            List<int> passengers = new List<int>();
            List<string> thereLoc = new List<string>();
            Random loc= new Random();

            int a = 1;
            string location;
            while (a <= Limit && waitingLine.Count > 0)
            {
                location= loc.Next(2) == null ? "Jhansi":"Jaipur";
                waitingLine.Dequeue();
                passengers.Add(a);
                thereLoc.Add(location);
                Console.WriteLine($"{a} got on the bus and their destination is {location}");
                a++;
            }

           int count=passengers.Count(),i=0;


           

            Console.WriteLine($"\r\nBus arriving at :Jhansi");
           
            do
            {
                i++;
                if (thereLoc.Equals("Jhansi"))
                {
                    Console.WriteLine($"{i}is getting off");
                    passengers.Remove(i);
                    thereLoc.Remove("Jhansi");
                }


            } while(i <= count);

            Console.WriteLine($"{passengers.Count}Pasengers left");

            Console.WriteLine($"\r\nBus arriving at :Jaipur");
            i = 0;
            do
            {
                i++;
                if (thereLoc.Equals("Jaipur"))
                {
                    Console.WriteLine($"{i}is getting off");
                    passengers.Remove(i);
                    thereLoc.Remove("Jaipur");
                }


            } while (i <= count);
           
            Console.WriteLine($"{passengers.Count} Pasengers left");
            

        }
      
    }
}
   