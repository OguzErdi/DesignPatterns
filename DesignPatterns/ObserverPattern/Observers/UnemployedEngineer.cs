using DesignPatterns.ObserverPattern;
using DesignPatterns.ObserverPattern.Observable;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesignPatterns.ObserverPattern.Observer
{
    public class UnemployedEngineer : IObserver
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }

        public UnemployedEngineer(IObservable observable, string name)
        {
            observable.RegisterObserver(this);
            _name = name;
        }

        public void Update(IObservable observable, List<string> args)
        {
            if (observable is LinkedIn)
            {
                LinkedIn linkedIn = (LinkedIn)observable;

                //if is a pull approach
                if (args == null)
                {
                    args = linkedIn.GetEngineerPosition();
                }

                Console.WriteLine($"{ Name}: I have notifyed that new positions available by LinkedIn. Jobs: {String.Join(", ", args.ToArray())}");
            }
        }

    }
}
