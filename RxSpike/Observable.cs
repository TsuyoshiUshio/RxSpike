using System;
using System.Collections.Generic;
using System.Text;

namespace RxSpike
{
    class Observable : IObservable<string>
    {
        private List<IObserver<string>> obs = new List<IObserver<string>>();

        public IDisposable Subscribe(IObserver<string> o)
        {
            this.obs.Add(o);
            return null; // TODO implement IDispose to the IObserver<string>
        }

        public void Execute(string x)
        {
            foreach (var o in this.obs)
            {
                o.OnNext(x);
            }
        }
    }
}
