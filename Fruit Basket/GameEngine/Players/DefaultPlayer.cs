using Fruit_Basket.GameEngine;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FruitBasket.Player
{
    abstract class DefaultPlayer
    {
        public string Name { get; private set; }
        public int PlayerId { get; private set; } = 0;
       
        protected DefaultPlayer(string name, int playerId)
        {
            Name = name;
            PlayerId = playerId;
        }        

        public abstract void GetNextNumber();
        public abstract int GetCurrentNumber();


    }
}
