using CafeREPO;
using MenuItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeUI
{
    class CafeUI
    {
        private CafeREPO.MenuItemRepository _MenuItemRepo = new CafeREPO.MenuItemRepository();
        public void Run()
        {
            MainMenu();
        }
        private void MainMenu()
        {
            bool Running = true;
            while (Running)
            {
                {
                    Console.WriteLine("---Select an option:\n" +
                  "1. Create New Meal\n" +
                  "2. Delete Meal\n" +
                  "3. View all Cafe Menu Items\n" +
                  "4. Exit Application");
                    string menuSelect = Console.ReadLine();
                    switch (menuSelect)
                    {
                        case "1": CreateNewMeal();
                            break;
                        case "2": DeleteMeal();
                            break;
                        case "3": DisplayAllMeals();
                            break;
                        case "4":
                            Console.WriteLine("Closing Software");
                            Running = false;
                            break;
                        default:
                            Console.WriteLine("Please enter a valid number.");
                            break;
                    }
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
            }
        }
        private void CreateNewMeal()
        {
            Console.Clear();
            MenuItem.MenuItem newMeal = new MenuItem.MenuItem();
            Console.WriteLine("Enter the Meal Number:");
            string MealNumberInput = Console.ReadLine();
            newMeal.MealNumber = Int32.Parse(MealNumberInput);
            Console.WriteLine("Enter the Meal Name:");
            newMeal.MealName = Console.ReadLine();
            Console.WriteLine("Write a description:");
            newMeal.Description = Console.ReadLine();
            Console.WriteLine("List Ingedients:");
            newMeal.Ingredients = Console.ReadLine();
            Console.WriteLine("Enter the price (dd.cc):");
            string MealPriceInput = Console.ReadLine();
            newMeal.Price = Decimal.Parse(MealPriceInput);
        }
        private void DisplayAllMeals()
        {
            List<MenuItem.MenuItem> listOfMeals = _MenuItemRepo.GetMenuItemList();
            foreach(MenuItem.MenuItem menuItem in listOfMeals)
            {
                Console.WriteLine($"--- #{menuItem.MealNumber}: {menuItem.MealName}. Flavor text :{menuItem.Description}. Contains:{menuItem.Ingredients}. Price: {menuItem.Price}---");
            }

        }
        private void DeleteMeal()
        {
            Console.Clear();
            DisplayAllMeals();
            Console.WriteLine("Enter the Meal Number you wish to delete:");
            int DeletedMeal = Int32.Parse(Console.ReadLine());
            bool clearingCheck = _MenuItemRepo.RemoveMenuItemFromList(DeletedMeal);
            if(clearingCheck == true)
            {
                Console.WriteLine("Item Removed successfully.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Delete failed.");
            }
        }
    }
}
