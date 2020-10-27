using DesignPatterns.ObserverPattern.Observable;
using DesignPatterns.ObserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Demos
{
    public class ObserverPatternDemo
    {
        public static void Start()
        {
            LinkedIn observable = new LinkedIn();

            UnemployedEngineer jack = new UnemployedEngineer(observable, "jack");
            UnemployedHr emily = new UnemployedHr(observable, "emily");
            UnemployedEngineer angely = new UnemployedEngineer(observable, "angely");
            UnemployedHr john = new UnemployedHr(observable, "john");

            observable.NewJobsAvailabel();

            observable.UnRegisterObserver(jack);
            observable.UnRegisterObserver(angely);

            observable.NewJobsAvailabel();

            observable.RegisterObserver(jack);
            observable.RegisterObserver(angely);

            observable.NewJobsAvailabelPullMode();

        }
    }
}
