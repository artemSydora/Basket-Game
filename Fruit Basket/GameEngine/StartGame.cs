using FruitBasket;
using FruitBasket.Player;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace FruitBasket.GameEngine
{
    class StartGame
    {
        public static List<int> triedNumbers = new List<int>();
        private static int _standardNumber;
        private readonly byte _limitOfAttempts;
        private readonly ushort _timeLimit;
        private readonly byte _factor;
        object locker = new object();

        public StartGame(byte limitOfAttempts, ushort timeLimit, byte factor)
        {
            _limitOfAttempts = limitOfAttempts;
            _timeLimit = timeLimit;
            _factor = factor;
        }

        public void ExecuteThread(object obj)
        {
            var player = obj as DefaultPlayer;
             
            while (!StopGame.HasACorrectAnsver(_standardNumber) && !StopGame.IsTimeOut(_timeLimit))
            {
                lock (locker)
                {
                    if (StopGame.IsAttemptLimit(_limitOfAttempts))
                    {
                        break;
                    }
                }

                _standardNumber = player.GetCurrentNumber();
                triedNumbers.Add(player.GetCurrentNumber());
                Console.WriteLine($"|Player №{player.PlayerId + 1}: {player.Name,16} | Type: {player.GetType().Name,22} | Number: {player.GetCurrentNumber(),5} | Time: {StopGame.GetTime(), 5}ms.{'|'}");                
                PauseThread(player, _factor);
                player.GetNextNumber();
            }
        }

        private void PauseThread(DefaultPlayer player, int factor)
        {
            Thread.Sleep(Math.Abs(player.GetCurrentNumber() - Basket.Weigth) * factor);
        }





    }
}
