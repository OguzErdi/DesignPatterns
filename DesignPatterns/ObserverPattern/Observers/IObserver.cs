using DesignPatterns.ObserverPattern.Observable;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern.Observer
{
    public interface IObserver
    {
        void Update(IObservable observable, List<string> args);
    }
}
