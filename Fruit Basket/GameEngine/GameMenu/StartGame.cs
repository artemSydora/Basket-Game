using Fruit_Basket.GameEngine;
using FruitBasket.Player;
using System;

namespace FruitBasket.GameEngine
{
    class StartGame
    {
        private static byte _standardNumber;
        private object _locker = new object();
        private static byte _attempts = 1;

        public void ExecuteThread(object obj)
        {
            var steps = 1;
            var player = obj as DefaultPlayer;

            while (!StopGame.HasACorrectAnsver(_standardNumber) && !StopGame.IsAttemptLimit(_attempts, 100) && !StopGame.IsTimeOut(1500))
            {
                lock (_locker)
                {
                    player.GetNextNumber();
                    _standardNumber = player.GetCurrentNumber();
                    Console.WriteLine($"| Attempt№: { _attempts++,3} | {player.Name,17}{'(' + steps++.ToString() + ')',-4} | Type: {player.GetType().Name,22} |" +
                        $" Number: {player.GetCurrentNumber(),5} | Time: {StopGame.GetTime(),6}ms.{'|'}");
                }
                PauseGame.PauseThread(player, 1);

            }
        }
    }
}
