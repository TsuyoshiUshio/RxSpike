using System;
using System.Collections.Generic;
using System.Reactive.Subjects;
using System.Text;

namespace LinqSpike
{
    class SubjectSpike
    {
        public void Exec()
        {
            Console.WriteLine("---- Subject Spike");
            var subject = new Subject<string>();
            var d = subject.Subscribe(x => Console.WriteLine(x));
            subject.OnNext("Hello");
            subject.OnNext("World");
            d.Dispose();

            subject.OnNext("After your dead.");
        }
    }
}
