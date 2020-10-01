using FruitBasket;
using FruitBasket.Player;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace FruitBasket.GameEngine
{
    class StopGame
    {
        private static Stopwatch _timer = new Stopwatch();
        private static byte _countOfAttempts = 0;

        public static bool HasACorrectAnsver(int standardNumber)
        {
            if (standardNumber == Basket.Weigth)
            {
                return true;
            }
            return false;
        }

        public static bool IsTimeOut(uint endTime)
        {
            if (!_timer.IsRunning)
            {
                throw new Exception();
            }

            if (_timer.ElapsedMilliseconds > endTime)
            {
                return true;
            }
            return false;
        }

        public static bool IsAttemptLimit(ushort timeLimit)
        {
            if (_countOfAttempts >= timeLimit)
            {
                return true;
            }
            _countOfAttempts++;
            return false;
        }

        public static void StartTimer()
        {
            _timer.Start();
        }

        public static long GetTime()
        {
            return _timer.ElapsedMilliseconds;
        }


        //public static void ChooseAWinner(int newValue)
        //{
        //    var closeValue = 40;
        //    if ((_gaugeNumber != Basket.Weigth) || _numberOfAttempts > 100)
        //    {
        //        if (Math.Abs(Basket.Weigth - newValue) < Math.Abs(Basket.Weigth - closeValue))
        //        {
        //            closeValue = newValue;
        //        }
        //    }
        //}
    }
}
