using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teamMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            String programName = " - Team Builder - ";
            Console.WriteLine(String.Format("{0, 50}", programName),"\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Enter Amount of Players: ");
            Console.Write("> ");
            int numPlayers = Convert.ToInt32(Console.ReadLine());
            


            //later need size for player obj
            playerControl playerObj = new playerControl(numPlayers);
            menu menuObj = new menu();

            menuObj.addingPlayers(numPlayers, playerObj);


            // If value is false then program exits
            bool value = true;

            while (value)
            {
                value = menuObj.displayMenu(playerObj);
            }
                       

        }
    }
}
