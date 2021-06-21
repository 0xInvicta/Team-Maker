using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teamMaker
{
    class playerControl
    {

        //Array of Names
        private playerNames[] playerNames;



        public playerControl(int numPlayers)
        {
            this.playerNames = new playerNames[numPlayers];
        }


        public void addPlayerName(String name, int ID, String team)
        {
            playerNames namesobj = new playerNames(name, ID, team);
            playerNames[ID - 1] = namesobj;
        }

        public int sizeOfArr()
        {
            return this.playerNames.Length;
        }

        public String showAllPlayers()
        {
            String Names = "";

            for (int i = 0; i < playerNames.Length; i++)
            {
                Names = Names + String.Format("ID: {0}    Name: {1}   Team: {2}\n", i + 1, this.playerNames[i].getName(), this.playerNames[i].getTeam());
            }
            return Names;
        }

        public playerNames[] addNewPlayer(String Addplayer)
        {
            //Setting New Array Size
            int n = this.playerNames.Length + 1;
            playerNames[] newArray = new playerNames[n];


            //Copying everything from old array to new one leaving last index value empty
            for (int i = 0; i < playerNames.Length; i++)
            {
                newArray[i] = this.playerNames[i];
            }

            //populating last index value with new name
            this.playerNames = newArray;
            this.addPlayerName(Addplayer, this.playerNames.Length, "No Team");


            return this.playerNames = newArray;
        }

        public void genTeams(String team1Name, String team2Name)
        {

            Random rnd = new Random();

            int totNumPlayers = sizeOfArr();
            int numTeam1 = sizeOfArr() / 2;

            int team1Count = 0;
            int team2Count = 0;


            for (int i = 0; i < totNumPlayers; i++)
            {
                int rndTeamNum = rnd.Next(0, 2);  // creates a number between 0 and 1

                if (rndTeamNum == 0 && team1Count != numTeam1)
                {
                    this.playerNames[i].setNewTeam(team1Name);
                    team1Count++;
                }
                else
                {
                    this.playerNames[i].setNewTeam(team2Name);
                    team2Count++;
                }
            }
            
        }
        public String showPlayerAndTeam(String team1Name, String team2Name)
        {
            String display = "";

            for (int i = 0; i < sizeOfArr(); i++)
            {
                if (this.playerNames[i].getTeam() == "No Team")
                {
                    Console.WriteLine(" No Teams Assigned !");
                    break;
                }

            }
            for (int i = 0; i < sizeOfArr(); i++)
            {
                if (this.playerNames[i].getTeam() == team1Name)
                {
                    display = display + "Name: " + this.playerNames[i].getName() + "   Team:" + this.playerNames[i].getTeam() + "\n"; 
                }
                
            }

            display = display + "\n";

            for (int i = 0; i < sizeOfArr(); i++)
            {
                if (this.playerNames[i].getTeam() == team2Name)
                {
                    display = display + "Name: " + this.playerNames[i].getName() + "   Team: " + this.playerNames[i].getTeam() + "\n";
                }

            }


            return display;
        } 

    }  
}
