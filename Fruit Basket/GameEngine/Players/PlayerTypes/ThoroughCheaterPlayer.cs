using Fruit_Basket.GameEngine;

namespace FruitBasket.Player.Players
{
    class ThoroughCheaterPlayer : DefaultPlayer
    {
        private byte number = 39;

        public ThoroughCheaterPlayer(string name, int playerId) :
            base(name, playerId){}

        public override void GetNextNumber()
        {
            number++;

            while (IsAlreadyTriedNumber(number))
            {
                number++;
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
