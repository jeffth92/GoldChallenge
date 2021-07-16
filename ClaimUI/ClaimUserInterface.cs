using ClaimREPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimUI
{
    class ClaimUserInterface
    {
        private ClaimRepository _ClaimRepo = new ClaimRepository();
        public void Run()
        {
            Menu();
        }
        private void Menu()
        {
            int task = 1;
            bool Running = true;
            while (Running)
            {
                Console.WriteLine("MAIN MENU----------------------------\n" +
                    "------------------------------------------\n" +
                    "1. See All Claims\n" +
                    "2. Take care of next claim\n" +
                    "3. Enter a new claim");
                string menuOption = Console.ReadLine();
                switch (menuOption)
                {
                    case "1": DisplayAllClaims();
                        break;
                    case "2": //skip to next item?
                        break;
                    case "3": CreateNewClaim();
                        break;
                    default: Console.WriteLine("Please Enter a Valid Number.");
                        break;
                }
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void CreatNewClaim()
        {
            Console.Clear();
        }
    }
}
