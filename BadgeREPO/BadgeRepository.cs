using BadgeClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgeREPO 
{
    public class BadgeRepository
    {
        public Dictionary<int, List<string>> badgeDictionary = new Dictionary<int, List<string>>();
        public void AddBadge(Badge badge) //create
        {
            badgeDictionary.Add(badge.BadgeID,badge.DoorNames);
        }
        public Dictionary<int, List<string>> GetBadgeList() //read for badges
        {
            return badgeDictionary;
        }
        public List<string> GetListOfDoors(int badgeid) //read for doors
        {
            return badgeDictionary[badgeid];
        }
    }
}

