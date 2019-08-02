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
        // public DisplayRules();

        //Constructor
        public Game()
        {
            Gesture = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
            winningThreshold = 2;
        }

        //DisplayRules()  Mustc console writeline before the game actually begins

        //Member Methods
        private void WinningGestures()
        {
            if (Player gesture == "rock" && Player gesture == lizard || scissors);
            {
                Console.WriteLine("The rock wins this game!");
            }
            else if(Player gesture == "scissors" && Player gesture == lizard || "paper");
            {
                Console.WriteLine("Them scissors cut too good");
            }
            else if(Player gesture == "paper" && Player gesture == "rock" || "spock");
            {
                Console.WriteLine("The fibres of the paper are to powerful");
            }
            else if(Player gesture == "lizard" && Player gesture == "spock" || "paper");
            {
                Console.WriteLine("The reptile comes out victorious this one time");
            }
            else if(Player gesture == "spock" && Player gesture == "rock" || "scissors");
            {
                Console.WriteLine("This alien is too good for such mediocre gestures");
            }
            else if(Player gesture == Player gesture);
            {
                Console.WriteLine("Whos reading minds?");
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
            DisplayRules();

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
                Console.WriteLine(player2 + " won rthe game!");
            }
        }
        //public string gesture()
        //{
        //    Console.WriteLine("What gesture shall you use?");

        //    Gesture = Console.ReadLine();
        //    return Gesture;
        //}






    }
}
