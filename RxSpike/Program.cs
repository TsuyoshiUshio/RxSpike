using System;
using System.Reactive.Linq;

namespace RxSpike
{
    class Program
    {
        static void Main(string[] args)
        {
            var observable = new Observable();
            observable.Subscribe(new Observer());
            observable.Execute("Hello");

            observable.Subscribe(new Observer());
            observable.Execute("World");
            
            Console.ReadLine();
        }
    }
}
