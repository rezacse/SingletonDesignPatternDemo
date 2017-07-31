using System;   
using System.Threading.Tasks;

namespace SingletonDesignPatternDemo
{
    public class Program
    {
        static void Main(string[] args)
        {

            Parallel.Invoke(
                PrintCounterForFirst,
                PrintCounterForSecond
               );

            Console.ReadLine();
        }

        private static void PrintCounterForFirst()
        {
            var firstObject = Singleton.GetInstance;
            firstObject.PrintObjectCounter("Counter for first object");
        }

        private static void PrintCounterForSecond()
        {
            var secondObject = Singleton.GetInstance;
            secondObject.PrintObjectCounter("Counter for first object");
        }
    }
}
