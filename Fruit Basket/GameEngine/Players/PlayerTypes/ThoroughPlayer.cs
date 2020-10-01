using FruitBasket.Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace FruitBasket.Player.Players
{
    class ThoroughPlayer : DefaultPlayer
    {
        protected List<int> numbersList;
        private int number = 40;

        public ThoroughPlayer(string name, int playerId) :
            base(name, playerId)
        {
            numbersList = new List<int>();
            numbersList.Add(number);
        }
        public override void GetNextNumber()
        {
            number++;
            numbersList.Add(number);
        }

        public override int GetCurrentNumber()
        {
            var number = numbersList[numbersList.Count - 1];
            return number;
        }
    }
}
