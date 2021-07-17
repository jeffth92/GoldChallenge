using BadgeClass;
using BadgeREPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgeUI
{
    class BadgeUI
    {
        public BadgeRepository _BadgeRepo = new BadgeRepository();
        public void Run()
        {
            Menu();
        }
        private void Menu()
        {
            bool Running = true;
            while (Running)
            {
                {
                    Console.WriteLine("Menu\n" +
                        "Hello Security Admin, What would you like to do?\n" +
                    "1. Add a badge\n" +
                    "2. Edit a badge\n" +
                    "3. List all badges\n" +
                    "4. Close Software");
                    string menuSelect = Console.ReadLine();
                    switch (menuSelect)
                    {
                        case "1":
                            CreateNewBadge();
                            break;
                        case "2":
                            EditBadge();
                            break;
                        case "3":
                            ListAllBadges();
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
                }
            }
        }
        private void CreateNewBadge()
        {
            Console.Clear();
            Badge newBadge = new Badge();
            newBadge.DoorNames = new List<string>();
            Console.WriteLine("What's the number on the badge?");
            newBadge.BadgeID = Int32.Parse(Console.ReadLine());
            bool adding = true;
            while (adding)
            {
                Console.WriteLine("List a door that it needs access to:");
                string inputDoor = Console.ReadLine();
                newBadge.DoorNames.Add(inputDoor);
                Console.WriteLine("Any other doors(y/n)?");
                string input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "y":
                        adding = true;
                        break;
                    case "n":
                        adding = false;
                        _BadgeRepo.AddBadge(newBadge);
                        break;
                    default:
                        Console.WriteLine("Entry rejected. Please enter y or n.");
                        break;
                }
            }
        }
        private void EditBadge()
        {
            Console.Clear();
            Console.WriteLine("What is the number on the Badge?");
            int input = Int32.Parse(Console.ReadLine());
            List<string> doors = _BadgeRepo.GetListOfDoors(input); //new
            foreach (string element in doors)
            {
                Console.WriteLine($"{element}");
            }
            Console.WriteLine("What would you like to do?\n" +
                      "1. Remove a Door\n" +
                      "2. Add a Door");
            string alterDoor = Console.ReadLine();
            switch (alterDoor)
            {
                case "1":
                    Console.WriteLine("Which Door to Remove?");
                    foreach (string element in doors)
                    {
                        Console.WriteLine($"{element}");
                    }
                    doors.Remove(Console.ReadLine());
                    break;
                case "2":
                    Console.WriteLine("Which Door to Add?");
                    doors.Add(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Please enter a valid selection.");
                    break;
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }
        private void ListAllBadges()
        {
            foreach (KeyValuePair<int, List<string>> kvp in _BadgeRepo.badgeDictionary)
            {
                Console.WriteLine($"Badge #{kvp.Key}");
                foreach (string door in kvp.Value)
                {
                    Console.WriteLine($"Access to {door}");
                }
            }
        }
    }
}

