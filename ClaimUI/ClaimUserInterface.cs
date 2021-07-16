using Claim;
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
        private void CreateNewClaim()
        {
            Console.Clear();
            Claim.Claim newClaim = new Claim.Claim();
            Console.WriteLine("Enter the claim id:");
            newClaim.ClaimID = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the claim type (Car, Home, Theft):");
            string type = Console.ReadLine().ToLower();
            string car = "car";
            string home = "home";
            string theft = "theft";
            switch (type)
            {
                case "car":
                    newClaim.ClaimType = car;
                    break;
                case "home":
                    newClaim.ClaimType = home;
                    break;
                case "theft":
                    newClaim.ClaimType = theft;
                    break;
                default:
                    Console.WriteLine("Invalid claim type. Please enter a valid claim type.");
                    break;
            }
            Console.WriteLine("Enter a claim desciption:");
            newClaim.Description = Console.ReadLine();
            Console.WriteLine("Amount of Damage:");
            newClaim.ClaimAmount = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Date of Accident (dd/mm/yy):");
            newClaim.DateOfAccident = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Date of Claim (dd/mm/yy):");
            newClaim.DateOfClaim = DateTime.Parse(Console.ReadLine());
            TimeSpan validCheck = newClaim.DateOfClaim - newClaim.DateOfAccident;
            if(validCheck.TotalDays < 31)
            {
                newClaim.IsValid = true;
            }
            else
            {
                newClaim.IsValid = false;
            }
            _ClaimRepo.AddClaimToList(newClaim);
        }
        private void DisplayAllClaims()
        {
            List<Claim.Claim> listOfClaims = _ClaimRepo.GetClaimList();
            Console.WriteLine("ClaimID     Type     Description     Amount     DateOfAccident     DateOfClaim     IsValid");
            foreach (Claim.Claim claim in listOfClaims)
            {
                Console.WriteLine($"{claim.ClaimID}     {claim.ClaimType}     {claim.Description}     {claim.ClaimAmount}     {claim.DateOfAccident}     {claim.DateOfClaim}     {claim.IsValid}");
            }
        }
    }
}
