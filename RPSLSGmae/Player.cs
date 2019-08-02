using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    public abstract class Player
    {
        //Member Variables
        public int WinCounter;
        public string PlayerName;
        public string Gesture;

        //Constructor


        public Player()
        {
            WinCounter = 0;
   
        }

        

        //Member Methods

        public abstract void ChooseGesture();
        public abstract ChooseName()
        {
            Console.WriteLine("Player 1 type your name!");
            player1 = Console.ReadLine();
            return player1;

        }
        public abstract ChooseName()
        {
            Console.WriteLine("Player 2 type your name!");
            player2 = Console.ReadLine();
            return player2;
        }

        
        public string gesture()
        {
            Console.WriteLine("What gesture shall you use?");
            Gesture = Console.ReadLine();
            return Gesture;
        }
       

    }
}
