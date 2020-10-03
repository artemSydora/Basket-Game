using FruitBasket.GameEngine;
using System;

namespace FruitBasket
{
    class Program
    {
        public static void DrawLine()
        {
            Console.WriteLine(('|') + new string('=', 103) + ('|'));
        }

        public static void DrawInput(out string input)
        {
            DrawLine();
            Console.Write($"{"Input number of players(2 - 8): ",73}");
            input = Console.ReadLine();
            DrawLine();
        }

        private static bool AreAcceptableLimits(int input)
        {
            if (input >= 2 && input <= 8)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            string input;
            var numberOfPlayers = 0;
            DrawInput(out input);

            while (!Int32.TryParse(input, out numberOfPlayers) || !AreAcceptableLimits(numberOfPlayers))
            {
                numberOfPlayers = 0;
                Console.Clear();
                DrawInput(out input);
            }

            PlayingField field = PlayingField.CreatePlayingField(numberOfPlayers);

            Console.WriteLine($"{'|'}{"Basket weigth:",54} {field.weight,5}kg. {'|',40}");
            DrawLine();
            field.Start();
            Console.ReadLine();
        }
    }
}
