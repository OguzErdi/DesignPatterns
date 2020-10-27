using DesignPatterns.ObserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern.Observable
{
    public interface IObservable
    {
        void RegisterObserver(IObserver observer);
        void UnRegisterObserver(IObserver observer);
        void NotifyObserver();
    }
}
