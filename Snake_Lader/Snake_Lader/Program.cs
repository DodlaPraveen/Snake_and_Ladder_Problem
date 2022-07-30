using System;

namespace Snake_Lader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Simulation(Single Player)");
            int playerOnePosition = 0;
            Random random = new Random();
            int dieRoll;
            dieRoll = random.Next(1, 7);
            playerOnePosition += dieRoll;
            Console.WriteLine("Position of Player 1 is at " + playerOnePosition);
        }
    }
}
