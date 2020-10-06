using FruitBasket.Player;
using System;
using System.Diagnostics;

namespace FruitBasket.GameEngine
{
    class StopGame
    {
        private static Stopwatch _timer = new Stopwatch();
      
        static StopGame()
        {
            _timer.Start();
        }

        public static bool HasACorrectAnsver(byte number)
        {
            if (number == Basket.Weigth)
            {
                return true;
            }
            return false;
        }

        public static bool IsTimeOut(uint endTime)
        {
            if (GetTime() > endTime)
            {
                return true;
            }
            return false;
        }

        public static bool IsAttemptLimit(byte attemptsCount, byte attemptsLimit)
        {
            if (attemptsCount > attemptsLimit)
            {
                return true;
            }

            return false;
        }

        public static ushort GetTime()
        {
            return (ushort)_timer.ElapsedMilliseconds;
        }


        //public static int SetClosestAnsver(DefaultPlayer player)
        //{
        //    var closestNumber = 40;

        //    if (Math.Abs(Basket.Weigth - player.GetCurrentNumber()) < Math.Abs(Basket.Weigth - closestNumber))
        //    {
        //        closestNumber = player.GetCurrentNumber();
        //        _winner = player;
        //    }
        //    return closestNumber;
        //}

        //public static DefaultPlayer GetWinner()
        //{
        //    Console.WriteLine(_winner.Name + _winner.PlayerId + SetClosestAnsver(_winner));
        //    return _winner;
        //}
    }
}

