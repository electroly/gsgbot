using System.Collections.Generic;

namespace GsgBot
{
    public sealed class Game
    {
        public string Name { get; set; } = "";
        public GameType Type { get; set; } = GameType.NumberGuess;
        public string GuessPeriodStartMessage { get; set; } = "";
        public string GuessPeriodEndMessage { get; set; } = "";
        public string GuessType { get; set; } = "";
        public List<string> PollChoices { get; set; } = new();
    }
}
