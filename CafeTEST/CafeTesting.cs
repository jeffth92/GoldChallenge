using CafeREPO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CafeTEST
{
    [TestClass]
    public class CafeTesting
    {
        [TestMethod]
        public void Create_Check() //not sure how to test, no returns.
        {
            
        }
        [TestMethod]
        public void Read_ListOfMenuItems_isnt_null() //same issue as above.
        {   
            //arrange

            //act

            //assert
        }
        [TestMethod]
        public void GetMenuItemByNumber_MealExists_ReturnMeal() //helper method
        {
            //arrange
            MenuItem.MenuItem menu = new MenuItem.MenuItem(1, "cheese", "james may", "lactose", 12.00m);
            MenuItemRepository repo = new MenuItemRepository();
            repo.AddMenuItemToList(menu);
            //act
            MenuItem.MenuItem result = repo.GetMenuItemByNumber(1);
            //assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.MealNumber, 1);
        }
    }
}
