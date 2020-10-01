using System;
using System.Collections.Generic;
using System.Text;

namespace FruitBasket
{
    class Basket
    {
        private static Basket _instance;
        private static int _weigth;

        public static int Weigth
        {
            get
            {
                GetInstance();
                return _weigth;
            }

           private set
            {
                _weigth = value;
            }
        }

        private Basket()
        {
            Weigth = new Random().Next(40, 140);
        }

        private static Basket GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Basket();
            }

            return _instance;
        }
    }
}
