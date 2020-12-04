using System;
using System.Collections.Generic;
using System.Text;

namespace _06_Developer_Repo
{
    public class DevRepo
    {
        private List<DevClass1> _listofDevs = new List<DevClass1>();
        //Create
        public void AddDevsToList(DevClass1 devs)
        {
            _listofDevs.Add(devs);
        }
       

        //Read

        public List<DevClass1> GetDevList()
        {
            return _listofDevs;
        }

        //Update

        public bool UpdateExisitingDev(string originalDevs, DevClass1 newDevs)
        {
            DevClass1 oldDevs = GetDevByName(originalDevs);

            if(oldDevs!=null)
            {
                oldDevs.Name = newDevs.Name;
                oldDevs.IDs = newDevs.IDs;
                oldDevs.AccessToPluralsight = newDevs.AccessToPluralsight;

                return true;
            }
            else
            {
                return false;
            }

        }

        //Delete
        public bool RemoveNameFromList(string name)
        {
            DevClass1 devs = GetDevByName(name);
            
            if(devs== null)
            {
                return false;
            }
            int initialCount = _listofDevs.Count;
            _listofDevs.Remove(devs);

            if (initialCount > _listofDevs.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //helper method
        public DevClass1 GetDevByName(string name)
        {
            foreach(DevClass1 devs in _listofDevs)
            {
                if(devs.Name==name)
                {
                    return devs;
                }
            }
            return null;
        }
    }
}
