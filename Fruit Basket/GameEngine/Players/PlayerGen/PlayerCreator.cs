using FruitBasket.Player;
using FruitBasket.Player.Players;
using System;
using System.Collections.Generic;

namespace Fruit_Basket.GameEngine
{
    static class PlayerCreator
    {
        public static int PlayerId { get; private set; } = -1;
        private static List<DefaultPlayer> _playersList = new List<DefaultPlayer>();

        public static DefaultPlayer CreatePlayer()
        {
            var random = new Random();
            PlayerId++;
            DefaultPlayer newPlayer = null;

            switch (random.Next(1, 5))
            {
                case 1:
                    newPlayer = new CheaterPlayer(PlayerNameGenerator.GetNextPlayerName(), PlayerId);
                    break;
                case 2:
                    newPlayer = new MemoryPlayer(PlayerNameGenerator.GetNextPlayerName(), PlayerId);
                    break;
                case 3:
                    newPlayer = new RandomPlayer(PlayerNameGenerator.GetNextPlayerName(), PlayerId);
                    break;
                case 4:
                    newPlayer = new ThoroughCheaterPlayer(PlayerNameGenerator.GetNextPlayerName(), PlayerId);
                    break;
                case 5:
                    newPlayer = new ThoroughPlayer(PlayerNameGenerator.GetNextPlayerName(), PlayerId);
                    break;
            }

            _playersList.Add(newPlayer);
            return newPlayer;
        }

        public static IList<DefaultPlayer> Players
        {
            get
            {
              return _playersList.AsReadOnly();
            }
        }

    }
}
