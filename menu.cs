using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teamMaker
{
    class menu
    {
        String team1Name = "";
        String team2Name = "";

        public void addingPlayers(int numPlayers, playerControl playerObj)
        {
            
            for (int i = 0; i < numPlayers; i++)
            {
                Console.WriteLine(String.Format("Enter player {0} name:", i+1));
                String player = Console.ReadLine();
                playerObj.addPlayerName(player, i + 1, "No Team");            
            }
            pageBreak();
            Console.WriteLine("Here are all the player names: ");
            Console.WriteLine(playerObj.showAllPlayers());
            pageBreak();
        }

        public bool displayMenu(playerControl playerObj)
        {
            pageBreak();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(String.Format("{0,20}", "- Menu Options -\n"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(String.Format("[1] - {0,20}", "Add More Players"));
            Console.WriteLine(String.Format("[2] - {0,20}", "Show All Players"));
            Console.WriteLine(String.Format("[3] - {0,20}", "Create Team"));
            Console.WriteLine(String.Format("[4] - {0,20}", "Show Teams"));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(String.Format("[5] - {0,20}", "Quit"));
            Console.ForegroundColor = ConsoleColor.White;
            pageBreak();

            Console.Write("> ");
            String userChoice = Console.ReadLine();
            int selectedOption;

            bool shouldExit = true;
            

            if (int.TryParse(userChoice, out selectedOption))
            {
                switch (selectedOption)
                {
                    case 1:

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(String.Format("{0,20}", " Adding PLayers: "));
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine("Add Player name:");
                        Console.Write("> ");
                        String Addplayer = Console.ReadLine();

                        playerObj.addNewPlayer(Addplayer);
                        Console.WriteLine("Player {} Added Successfuly", Addplayer);

                        return shouldExit = true;                    
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(String.Format("{0,20}", " All Players: "));
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(playerObj.showAllPlayers());

                        return shouldExit;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(String.Format("{0,20}", " Create Teams: "));
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine("Enter Team 1 Name: ");
                        Console.Write(">");
                        team1Name = Console.ReadLine();

                        Console.WriteLine("Enter Team 2 Name: ");
                        Console.Write(">");
                        team2Name = Console.ReadLine();

                        playerObj.genTeams(team1Name, team2Name);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(String.Format("{0, 30}", " Here are the teams: "), "\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(playerObj.showAllPlayers());

                        return shouldExit;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(String.Format("{0, 20}", " Here are the teams: "), "\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine(playerObj.showPlayerAndTeam(team1Name, team2Name));
                        return shouldExit;

                    case 5:
                        Console.WriteLine("Are you sure you want to EXIT yes/no? ");
                        String userOpt = Console.ReadLine();

                        if(userOpt.ToLower() == "yes")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Bye....");
                            Console.ForegroundColor = ConsoleColor.White;
                            return shouldExit = false;
                        }
                        else
                        {
                            return shouldExit;
                        }
                        
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Menu Option !");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter A Valid Number !");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return shouldExit;
        }

        public void pageBreak()
        {
            Console.WriteLine("-------------------------------------");
        }
    }
}
