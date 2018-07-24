using System;
using System.Collections.Generic;
using System.Text;

namespace RxSpike
{
    class Observer : IObserver<string>
    {
        public void OnCompleted()
        {
            
        }

        public void OnError(Exception error)
        {
        }

        public void OnNext(string x)
        {
            Console.WriteLine(x);
        }
    }
}
