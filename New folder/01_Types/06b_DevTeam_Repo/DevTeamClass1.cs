using System;
using static _06b_DevTeam_Repo.DevTeamRepo;

namespace _06b_DevTeam_Repo
{
    public class DevTeamClass1
    {
        //Plain Old C# Object//

        public string Developer { get; set; }
        public string TeamName { get; set; }
        public int TeamID { get; set; }
        public TeamNameColor ColorName { get; set; }

        public DevTeamClass1() { }
        public DevTeamClass1(string developer, string teamName, int teamID)
        {
            Developer = developer;
            TeamName = teamName;
            TeamID = teamID; 
        }
    }
}
