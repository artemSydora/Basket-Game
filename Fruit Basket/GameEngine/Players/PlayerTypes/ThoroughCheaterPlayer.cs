using System;
using System.Collections.Generic;
using System.Text;

namespace FruitBasket.Player.Players
{
    class ThoroughCheaterPlayer : DefaultPlayer
    {
        private List<int> _numbersList = new List<int>();
        private int number = 40;

        public ThoroughCheaterPlayer(string name, int playerId) :
            base(name, playerId)
        {
            _numbersList = new List<int>();
            _numbersList.Add(number);
        }
        public override void GetNextNumber()
        {        
            number++;
            _numbersList.Add(number);
        }

        public override int GetCurrentNumber()
        {
            var number = _numbersList[_numbersList.Count - 1];
            return number;
        }
    }
}
