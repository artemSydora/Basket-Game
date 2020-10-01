using Fruit_Basket;
using Fruit_Basket.GameEngine;
using Fruit_Basket.GameEngine.Players.PlayersGen;
using FruitBasket.Player;
using FruitBasket.Player.Players;
using System;
using System.Collections.Generic;
using System.Threading;

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
            StopGame.StartTimer();

            for (int i = 0; i < numberOfPlayers; i++)
            {
               ThreadCreator.CreateThread(100, 1500, 1).Start(PlayerCreator.CreatePlayer());
            }
        }
    }
}
