using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    class Game
    {
        //Member Variables
        public List<string> Gesture;
        Player player1;
        Player player2;
        public int winningThreshold;
        public DaRules rules;

        //Constructor
        public Game()
        {
            Gesture = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
            winningThreshold = 2;
            rules = new DaRules();
        }


        //Member Methods
        private void WinningGestures()
        {
            if (player1.Gesture == player2.Gesture)
            {
                Console.WriteLine("It's a tie because someone decided to do some mind reading");
            }
           else if (player1.Gesture == "rock" && player2.Gesture == "lizard" || player2.Gesture == "scissors")
            {
                Console.WriteLine("The rock wins this game!");
            }
            else if (player1.Gesture == "scissors" && player2.Gesture == "lizard" || player2.Gesture ==  "paper")
            {
                Console.WriteLine("Them scissors too sharp");
            }
            else if (player1.Gesture == "paper" && player2.Gesture == "rock" || player2.Gesture == "spock")
            {
                Console.WriteLine("The fibres of the paper are to powerful");
            }
            else if (player1.Gesture == "lizard" && player2.Gesture == "spock" || player2.Gesture == "paper")
            {
                Console.WriteLine("The reptile comes out victorious this one time");
            }
            else if (player1.Gesture == "spock" && player2.Gesture == "rock" || player2.Gesture ==  "scissors")
            {
                Console.WriteLine("This alien is too good for such mediocre gestures");
            }
        }

        private int GetNumberOfPlayers()
        {
            Console.WriteLine("How many players?");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            return numberOfPlayers;
        }
        private void SettingUpPlayers(int numberOfPlayers)
        {
            if
                (numberOfPlayers == 1)
            {
                player1 = new Human();
                player2 = new Computer();
            }
            else
            {
                player1 = new Human();
                player2 = new Human();
            }
        }


        public void RunGame()
        {
            rules.DisplayRules();

            int numberPlayers = GetNumberOfPlayers();
            SettingUpPlayers(numberPlayers);
        }

        private void DisplayWinner()
        {
            if (player1.WinCounter == winningThreshold)
            {
                Console.WriteLine(player1 + " won the game!");
            }
            else
            {
                Console.WriteLine(player2 + " won the game!");
            }
        }

    }
}