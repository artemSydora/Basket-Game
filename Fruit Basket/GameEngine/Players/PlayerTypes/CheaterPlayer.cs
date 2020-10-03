using Fruit_Basket.GameEngine;
using FruitBasket.GameEngine;
using System;
using System.Collections.Generic;

namespace FruitBasket.Player.Players
{
    class CheaterPlayer : DefaultPlayer
    {
        private Random _random;

        public CheaterPlayer(string name, int playerId) :
            base(name, playerId)
        {
            _random = new Random();
        }

        public override void GetNextNumber()
        {
            var number = (byte)_random.Next(40, 140);

            while (IsAlreadyTriedNumber(number))
            {
                number = (byte)_random.Next(40, 140);
            }

            _answersList.Add(number);
        }

        private static bool IsAlreadyTriedNumber(byte number)
        {
            foreach (var player in PlayerCreator.Players)
            {
                if (player.Answers.Contains(number))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
