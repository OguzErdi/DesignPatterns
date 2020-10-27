using DesignPatterns.DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.Decorator
{
    public abstract class PetDecorator : PlayerBase
    {
        private PlayerBase _player;
        public PlayerBase Player { get => _player; set => _player = value; }

        protected PetDecorator(PlayerBase player)
        {
            _player = player;
        }

    }
}
