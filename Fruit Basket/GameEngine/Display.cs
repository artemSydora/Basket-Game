using Fruit_Basket.GameEngine.Players.PlayerGen;
using FruitBasket.Player;
using System;
using System.Collections.Generic;

namespace Fruit_Basket.GameEngine
{
    delegate void MessageHandler(PlayerInfo player);

    class Display
    {
        
        public static void ShowPlayerMoves(PlayerInfo player)
        {
            Console.WriteLine($"| Attempt№: { player.Attempts,3} | {player.Name,17} | Type: {player.Type,22} |" +
                        $" Number: {player.Number,5} | Time: {player.Time,6}ms.{'|'}");
        }

        public static void ShowWinner(PlayerInfo player)
        {
            Console.WriteLine($"|{"***********WINNER!!!!***********", 67} {'|',32}");
            Console.WriteLine($"| Attempt№: { player.Attempts,3} | {player.Name,17} | Type: {player.Type,22} |" +
                        $" Number: {player.Number,5} | Time: {player.Time,6}ms.{'|'}");
        }

    }
}
