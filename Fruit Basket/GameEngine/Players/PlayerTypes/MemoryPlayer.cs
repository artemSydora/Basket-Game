using System;
using System.Collections.Generic;

namespace FruitBasket.Player.Players
{
    class MemoryPlayer : DefaultPlayer
    {
        private Random _random;

        public MemoryPlayer(string name, int playerId) :
            base(name, playerId)
        {
            _random = new Random();
        }

        public override void GetNextNumber()
        {
            var number = (byte)_random.Next(40, 140);

            while (_answersList.Contains(number))
            {
                number = (byte)_random.Next(40, 140);
            }

           _answersList.Add(number);
        }
    }
}
