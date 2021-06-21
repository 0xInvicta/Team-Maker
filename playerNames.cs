using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teamMaker
{
    class playerNames
    {
        private String name;
        private int ID;
        private String team;

        public playerNames(String name, int ID, String team)
        {
            this.name = name;
            this.ID = ID;
            this.team = team;
        }

        public String getName()
        {
            return this.name;
        }
        public int getID()
        {
            return this.ID;
        }

        public String getTeam()
        {
            return this.team;
        }

        public void setNewTeam(String newTeamName)
        {
            this.team = newTeamName;
        }
    }
    
}
