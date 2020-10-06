using Fruit_Basket.GameEngine;
using Fruit_Basket.GameEngine.Players.PlayerGen;
using FruitBasket.Player;

namespace FruitBasket.GameEngine
{
    class StartGame
    {
        private static byte _standardNumber;
        private object _locker = new object();
        private static byte _attempts = 1;
        private MessageHandler _message;

        public void RegisterHandler(MessageHandler message)
        {
            _message = message;
        }

        public void ExecuteThread(object obj)
        {
            var player = obj as DefaultPlayer;
            do
            {
                lock (_locker)
                {
                    player.GetNextNumber();
                    _standardNumber = player.GetCurrentNumber();
                    if (_message != null)
                    {
                        _message(new PlayerInfo(player.Name,player.GetType().Name, player.GetCurrentNumber(), _attempts++, StopGame.GetTime()));
                    }
                }
                PauseGame.PauseThread(player, 1);
            } while (!StopGame.HasACorrectAnsver(_standardNumber) && !StopGame.IsAttemptLimit(_attempts, 100) && !StopGame.IsTimeOut(1500));
        }

    }
}
