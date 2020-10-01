using System;
using System.Collections.Generic;
using System.Text;

namespace FruitBasket.Player.Players
{
    class MemoryPlayer : DefaultPlayer
    {
        private List<int> _numberList = new List<int>();
        private Random _random;

        public MemoryPlayer(string name, int playerId) :
            base(name, playerId)
        {
            _random = new Random();
            _numberList.Add(_random.Next(40, 140));
        }

        public override void GetNextNumber()
        {
            var number = _random.Next(40, 140);

            while (_numberList.Contains(number))
            {
                number = _random.Next(40, 140);
            }
            _numberList.Add(number);
        }

        public override int GetCurrentNumber()
        {
            var number = _numberList[_numberList.Count - 1];
            return number;
        }
    }
}
