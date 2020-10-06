using System;
using System.Collections.Generic;

namespace FruitBasket.Player.Players
{
    class RandomPlayer : DefaultPlayer
    {
        private Random _random;

        public RandomPlayer(string name, int playerId) :
            base(name, playerId)
        {
            _random = new Random();
        }

        public override void GetNextNumber()
        {
            _answersList.Add((byte)_random.Next(40, 140));
        }
    }
}
