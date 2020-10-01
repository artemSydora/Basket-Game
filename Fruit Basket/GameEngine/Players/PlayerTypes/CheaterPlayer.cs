using System;
using System.Collections.Generic;
using System.Text;

namespace FruitBasket.Player.Players
{
    class CheaterPlayer : DefaultPlayer
    {
        private List<int> _numbersList = new List<int>();
        protected Random random;

        public CheaterPlayer(string name, int playerId):
            base(name, playerId)
        {   
            random = new Random();
            _numbersList.Add(random.Next(40, 140));
        }

        public override void GetNextNumber()
        {
            _numbersList.Add(random.Next(40, 140));
        }

        public override int GetCurrentNumber()
        {
            var number = _numbersList[_numbersList.Count - 1];
            return number;     
        }


    }
}
