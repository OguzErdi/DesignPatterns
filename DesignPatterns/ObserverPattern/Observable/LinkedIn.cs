using System;
using System.Collections.Generic;
using DesignPatterns.ObserverPattern.Observer;

namespace DesignPatterns.ObserverPattern.Observable
{
    public class LinkedIn : IObservable
    {
        private List<IObserver> _observers;

        private List<string> _engineerPositions = new List<string>();
        private List<string> _hrPositions = new List<string>();

        public List<string> AllPositions = new List<string>();

        public LinkedIn()
        {
            _engineerPositions.Add("MidLevel App Eng.");
            _engineerPositions.Add("Senior App Eng.");

            _hrPositions.Add("HR Intern");
            _hrPositions.Add("HR Generalist");

            AllPositions.AddRange(_engineerPositions);
            AllPositions.AddRange(_hrPositions);

            _observers = new List<IObserver>();
        }

        public List<string> GetEngineerPosition()
        {
            return _engineerPositions;
        }

        public List<string> GetHrPositions()
        {
            return _hrPositions;
        }

        public void NotifyObserver(IObservable observable, List<string> args)
        {
            _observers.ForEach(o => o.Update(observable, args));
        }

        public void NotifyObserver()
        {
            NotifyObserver(this, AllPositions);
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnRegisterObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }


        //classic push approach
        public void NewJobsAvailabel()
        {
            Console.WriteLine("--------Hey people, new positions available!!!!-------");
            NotifyObserver();
        }

        //beacuse of args is null, observer need to call get methods which jobs want to get 
        //so, this approach called pull for this reason.
        public void NewJobsAvailabelPullMode()
        {
            Console.WriteLine("--PULL--Hey people, new positions available!!!!--PULL--");
            NotifyObserver(this, null);
        }
    }
}
