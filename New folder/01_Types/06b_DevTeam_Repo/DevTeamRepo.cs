using System.Collections.Generic;

namespace _06b_DevTeam_Repo
{
    public class DevTeamRepo
    {
        public enum TeamNameColor
        {
            Blue = 1,
            Green,
            Red,
            

        }

        private List<DevTeamClass1> _listofDevTeam = new List<DevTeamClass1>();

        //Create

        public void AddDevsToList(DevTeamClass1 dev)
        {
            _listofDevTeam.Add(dev);
        }



        //Read
        public List<DevTeamClass1> GetDevTeamList()
        {
            return _listofDevTeam;
        }
        //Update

        public bool UpdateExisitingDevTeam(string originalDev, DevTeamClass1 newDev)
        {
            DevTeamClass1 oldDev = GetDevTeamByName(originalDev);

            if (oldDev != null)
            {
                oldDev.Developer = newDev.Developer;
                oldDev.TeamName = newDev.TeamName;
                oldDev.TeamID = newDev.TeamID;

                return true;
            }
            else
            {
                return false;
            }

        }

        //Delete
        public bool RemoveNameFromList(string developer)
        {
            DevTeamClass1 dev = GetDevTeamByName(developer);

            if(dev == null)
            {
                return false;
            }
            int initialCount = _listofDevTeam.Count;
            _listofDevTeam.Remove(dev);

            if (initialCount > _listofDevTeam.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //helper method
        public DevTeamClass1 GetDevTeamByName(string developer)
        {
            foreach (DevTeamClass1 dev in _listofDevTeam)
            {
                if (dev.Developer== developer)
                {
                    return dev;
                }
            }
            return null;
        }
    }
}
