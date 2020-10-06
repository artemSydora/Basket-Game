using FruitBasket.Player;
using System.Collections.Generic;

namespace Fruit_Basket.GameEngine.Players.PlayerGen
{
    class PlayerInfo
    {
        private static List<PlayerInfo> _infoList = new List<PlayerInfo>();
        public string Name { get; private set; }
        public string Type { get; private set; }
        public byte Number { get; private set; } = 0;
        public byte Attempts { get; private set; } = 0;
        public ushort Time { get; private set; } = 0;

        public PlayerInfo(string name, string type, byte number, byte attempts, ushort time)
        {
            Name = name;
            Type = type;
            Number = number;
            Attempts = attempts;
            Time = time;
            _infoList.Add(this);
        }

        public static IList<PlayerInfo> GetInfoList
        {
            get
            {
                return _infoList.AsReadOnly();
            }
        }
    }
}
