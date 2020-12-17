using System;

namespace RockPaperScissorsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Namespace.Class ObjectName = new Namespace.Class()
            RockPaperScissors.RockPaperScissorsGame game = new RockPaperScissors.RockPaperScissorsGame();
            game.Play();
        }
    }
}
