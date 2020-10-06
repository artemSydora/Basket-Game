using FruitBasket.GameEngine;
using System.Threading;

namespace Fruit_Basket.GameEngine.Players.PlayersGen
{
    class ThreadCreator
    {
        public static Thread CreateThread(StartGame newGame)
        {
            var thread = new Thread(newGame.ExecuteThread);

            return thread;
        }
    }
}
