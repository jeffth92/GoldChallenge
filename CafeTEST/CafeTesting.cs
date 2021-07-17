using CafeREPO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CafeTEST
{
    [TestClass]
    public class CafeTesting
    {
        [TestMethod]
        public void Create_newMeal_isnt_null() //create method
        {
            //arrange
            MenuItemRepository repo = new MenuItemRepository();
            MenuItem.MenuItem newMeal = new MenuItem.MenuItem(1, "cheese", "james may", "lactose", 12.00m);
            repo.AddMenuItemToList(newMeal);
            //act
            var testitem = newMeal;
            //assert
            Assert.IsNotNull(testitem);
        }
        [TestMethod]
        public void Read_ListOfMenuItems_isnt_null() //read method
        {
            //arrange
            CafeREPO.MenuItemRepository _MenuItemRepo = new CafeREPO.MenuItemRepository();
            //act
            var testitem =_MenuItemRepo.GetMenuItemList();
            //assert
            Assert.IsNotNull(testitem);
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
        [TestMethod]
        public void RemoveMenuItem_Makes_True() //delete method
        {
            //arrange
            MenuItemRepository repo = new MenuItemRepository();
            MenuItem.MenuItem newMeal = new MenuItem.MenuItem(1, "cheese", "james may", "lactose", 12.00m);
            repo.AddMenuItemToList(newMeal); //which checks out, given create isnt null
            //act
            var test = repo.RemoveMenuItemFromList(newMeal.MealNumber);
            //assert
            Assert.IsTrue(test);
        }
    }
}
