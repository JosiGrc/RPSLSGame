
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    public class Human : Player
    {
        //Member Variable

        //Constructor
        public Human()
        {
                
        }

        //Member Methods
        public override void ChooseGesture()
        {
            Console.WriteLine("Choose a gesture");
            Gesture = Console.ReadLine();
        }
        public override void ChooseName()
        {
            Console.WriteLine("Choose Name");
            PlayerName = Console.ReadLine();
        }

    }
}
