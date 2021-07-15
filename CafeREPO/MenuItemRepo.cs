using MenuItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeREPO
{
    public class MenuItemRepository
    {
        private List<MenuItem.MenuItem> _ListOfMenuItems = new List<MenuItem.MenuItem>();
        public void AddMenuItemToList(MenuItem.MenuItem meal) //create
        {
            _ListOfMenuItems.Add(meal);
        }
        public List<MenuItem.MenuItem> GetMenuItemList() //read
        {
            return _ListOfMenuItems;
        }
        public MenuItem.MenuItem GetMenuItemByNumber(int mealNumber) //helper
        {
            foreach(MenuItem.MenuItem meal in _ListOfMenuItems)
            {
                if(meal.MealNumber == mealNumber)
                {
                    return meal;
                }
            }
            return null;
        }
        public bool RemoveMenuItemFromList(int mealNumber) //delete
        {
            MenuItem.MenuItem meal = GetMenuItemByNumber(mealNumber);
            if(meal == null)
            {
                return false;
            }
            int initialCount = _ListOfMenuItems.Count;
            _ListOfMenuItems.Remove(meal);
            if(initialCount > _ListOfMenuItems.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
