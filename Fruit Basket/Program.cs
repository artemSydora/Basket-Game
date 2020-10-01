using Fruit_Basket;
using Fruit_Basket.GameEngine;
using FruitBasket.GameEngine;
using System;
using System.Security.Cryptography.X509Certificates;

namespace FruitBasket
{
    class Program
    {
        public static void DrawLine()
        {
            Console.WriteLine(('|') + new string('=', 91) + ('|'));
        }

        public static void DrawInput(out string input)
        {
            DrawLine();
            Console.Write($"{"Input number of players(2 - 8): ",60}");
            input = Console.ReadLine();
            DrawLine();
        }

        private static bool AreAcceptableLimits(int input)
        {
            if (input >= 1 && input <= 8)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            while (true){
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

                Console.WriteLine($"{'|'}{"Basket weigth:",46} {field.weight,5}kg. {'|',36}");
                DrawLine();
                field.Start();
                Console.ReadLine();
            }
        }
    }
}
