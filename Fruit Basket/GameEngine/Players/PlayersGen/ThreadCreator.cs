using FruitBasket.GameEngine;
using FruitBasket.Player;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Fruit_Basket.GameEngine.Players.PlayersGen
{
    class ThreadCreator
    {
        public static Thread CreateThread(byte limitOfAttempts, ushort timeLimit, byte factor)
        {
            var thread = new Thread(new StartGame(limitOfAttempts, timeLimit, factor).ExecuteThread);
            
            return thread;
        }
    }
}
