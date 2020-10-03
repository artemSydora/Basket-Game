using System;

namespace Fruit_Basket
{
    static class PlayerNameGenerator
    {
        private static bool _areNamesShuffled = false;
        private static string[] _names = new string[] { "Artem Sidora", "Grigory Zdorik", "Evgene Plisko", "Denis Rozhko", "Vitaliy Korotkii", "Viktor Pokidko",
                "Viktoriia Sidora", "Oleg Kondrashin", "Evgene Korotkii", "Vadim Popov" };
        private static int _index = -1;

        static PlayerNameGenerator()
        {
            if (!_areNamesShuffled)
            {
                PlayerNamesShuffle();
                _areNamesShuffled = true;
            }
        }

        private static void PlayerNamesShuffle()
        {
            var random = new Random();

            for (int i = _names.Length - 1; i > 1; i--)
            {
                var j = random.Next(0, i);
                if (j <= i && j >= 0)
                {
                    var temp = _names[j];
                    _names[j] = _names[i];
                    _names[i] = temp;
                }
            }
        }

        public static string GetNextPlayerName()
        {
            if (_index < _names.Length - 1)
            {
                _index++;
            }
            return _names[_index];
        }
    }
}
