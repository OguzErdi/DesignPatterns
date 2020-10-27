using DesignPatterns.DecoratorPattern.Component;
using DesignPatterns.DecoratorPattern.Decorator;
using DesignPatterns.ObserverPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Demos
{
    public class DecoratorPatternDemo
    {
        public static void Start()
        {
            PlayerBase playerA = new PlayerA();
            playerA.PrintName();
            playerA.Attack();
            playerA.Jump();
            playerA.Run();

            PlayerBase playerB = new PlayerB();
            playerB.PrintName();
            playerB.Attack();
            playerB.Jump();
            playerB.Run();

            Console.WriteLine("-------------With Decorators-----------");

            playerA = new Tiger(playerA);
            playerA.PrintName();
            playerA.Attack();
            playerA.Jump();
            playerA.Run();

            playerA = new Cheetah(playerA);
            playerA.PrintName();
            playerA.Attack();
            playerA.Jump();
            playerA.Run();

            playerB = new Kangaroo(playerB);
            playerB.PrintName();
            playerB.Attack();
            playerB.Jump();
            playerB.Run();

            playerB = new Tiger(playerB);
            playerB.PrintName();
            playerB.Attack();
            playerB.Jump();
            playerB.Run();
        }
    }
}
