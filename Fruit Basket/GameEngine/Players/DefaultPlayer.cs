using System.Collections.Generic;

namespace FruitBasket.Player
{
    abstract class DefaultPlayer
    {
        public string Name { get; private set; }
        public int PlayerId { get; private set; } = 0;
        protected List<byte> _answersList;

        protected DefaultPlayer(string name, int playerId)
        {
            Name = name;
            PlayerId = playerId;
            _answersList = new List<byte>();
        }

        public abstract void GetNextNumber();

        public byte GetCurrentNumber()
        {
            var number = _answersList[_answersList.Count - 1];
            return number;
        }

        public IList<byte> Answers
        {
            get { return _answersList.AsReadOnly(); }
        }
    }
}
