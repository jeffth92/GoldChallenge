using BadgeREPO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BadgeTEST
{
    [TestClass]
    public class BadgeTesting
    {
        [TestMethod]
        public void AddBadge_IsntNull() //create
        {
            BadgeRepository repo = new BadgeRepository();
            BadgeClass.Badge badge = new BadgeClass.Badge(1, new List<string>());
            repo.AddBadge(badge);
            var test = badge;
            Assert.IsNotNull(test);
        }
        [TestMethod]
        public void GetBadgeList_Doesnt_Return_Null() //read badge
        {
            BadgeRepository repo = new BadgeRepository();
            BadgeClass.Badge badge = new BadgeClass.Badge(1, new List<string>());
            repo.AddBadge(badge);
            var test = repo.GetBadgeList();
            Assert.IsNotNull(test);
        }
        [TestMethod]
        public void GetListOfDoors_Doesnt_Return_Null() //read door
        {
            BadgeRepository repo = new BadgeRepository();
            BadgeClass.Badge badge = new BadgeClass.Badge(1, new List<string>());
            badge.DoorNames.Add("f1");
            repo.AddBadge(badge);
            var test = repo.GetListOfDoors(1);
            Assert.IsNotNull(test);
        }
    }
}
