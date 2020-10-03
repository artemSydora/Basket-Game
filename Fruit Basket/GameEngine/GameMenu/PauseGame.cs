using FruitBasket;
using FruitBasket.Player;
using System;
using System.Threading;

namespace Fruit_Basket.GameEngine
{
    class PauseGame
    {
        public static void PauseThread(DefaultPlayer player, int factor)
        {
            Thread.Sleep(Math.Abs(player.GetCurrentNumber() - Basket.Weigth) * factor);
        }
    }
}
