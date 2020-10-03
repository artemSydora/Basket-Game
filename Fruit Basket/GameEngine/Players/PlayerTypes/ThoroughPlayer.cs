using System.Collections.Generic;

namespace FruitBasket.Player.Players
{
    class ThoroughPlayer : DefaultPlayer
    {
        private byte number = 39;

        public ThoroughPlayer(string name, int playerId) :
            base(name, playerId){}

        public override void GetNextNumber()
        {
            number++;
            _answersList.Add(number);
        }
    }
}
