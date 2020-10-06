using Fruit_Basket.GameEngine;
using Fruit_Basket.GameEngine.Players.PlayersGen;
using FruitBasket.Player;
using System.Collections.Generic;
using System.Diagnostics;

namespace FruitBasket.GameEngine
{
    class PlayingField
    {
        private static PlayingField _playingField;
        public readonly int weight = Basket.Weigth;
        public readonly int numberOfPlayers;

        public static PlayingField CreatePlayingField(int numberOfPlayers)
        {
            if (_playingField == null)
            {
                _playingField = new PlayingField(numberOfPlayers);
            }
            return _playingField;
        }

        private PlayingField(int numberOfPlayers)
        {
            this.numberOfPlayers = numberOfPlayers;
        }

        public void Start()
        {
            for(int i = 0; i < numberOfPlayers; i++)
            {
                PlayerCreator.CreatePlayer();
            }

            var newGame = new StartGame();
            newGame.RegisterHandler(Display.ShowPlayerMoves);

            for (int i = 0; i < numberOfPlayers; i++)
            {
                ThreadCreator.CreateThread(newGame).Start(PlayerCreator.Players[i]);
            }
        }
    }
}
