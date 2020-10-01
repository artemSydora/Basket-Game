using System;
using System.Collections.Generic;
using System.Text;

namespace FruitBasket.Player.Players
{
    class RandomPlayer : DefaultPlayer
    {
        private List<int> _numbersList = new List<int>();
        private Random _random;

        public RandomPlayer(string name, int playerId) :
            base(name, playerId)
        {
            _random = new Random();
            _numbersList.Add(_random.Next(40, 140));
        }

        public override void GetNextNumber()
        {
            _numbersList.Add(_random.Next(40, 140));
        }

        public override int GetCurrentNumber()
        {
            var number = _numbersList[_numbersList.Count - 1];
            return number;
        }
    }
}
