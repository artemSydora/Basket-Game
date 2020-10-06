using Fruit_Basket.GameEngine.Players.PlayerGen;
using FruitBasket;
using FruitBasket.Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fruit_Basket.GameEngine
{
    static class Winner
    {
        private static PlayerInfo _winner = PlayerInfo.GetInfoList[0];
        private static byte _closestAnswer = 0;


        public static PlayerInfo GetWinner()
        {
            foreach (var player in PlayerInfo.GetInfoList)
            {

                {
                    if (Math.Abs(Basket.Weigth - player.Number) < Math.Abs(Basket.Weigth - _closestAnswer))
                    {
                        _closestAnswer = player.Number;
                        _winner = player;
                    }
                }
            }
            return _winner;
        }
    }
}
