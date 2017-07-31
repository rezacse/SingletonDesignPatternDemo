using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SingletonDesignPatternDemo
{
    public sealed class Singleton
    {

        //to check object creation
        private readonly int _counter;
        private Singleton()
        {
            Console.WriteLine("mumber of instance created : " + ++_counter);
        }


        // lazy initialization for thread safety    
        private static readonly object Obj = new object();
        private static Singleton _instance;
        public static Singleton GetInstance
        {
            get
            {
                //double check
                if (_instance != null)
                    return _instance;

                lock (Obj)
                {
                    if (_instance == null)
                        _instance = new Singleton();
                }

                return _instance;
            }
        }


        //// eger initailization 
        //public static Singleton GetInstance { get; } = new Singleton();


        ////lazy initialization with Lazy  
        //private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton());
        //public static Singleton GetInstance => _instance.Value;

        public void PrintObjectCounter(string message)
        {
            Console.WriteLine(message + ": " + _counter);
        }
                                                             
    }
}
