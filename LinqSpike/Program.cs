using System;
using System.Reactive.Linq;

namespace LinqSpike
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = Observable.Range(1, 10);
            source
                .Where(x => x % 2 == 0)
                .Select(x => x * x)
                .Subscribe(x => Console.WriteLine("value = {0}", x));
            new SubjectSpike().Exec();
            Console.ReadLine();

        }
    }
}
