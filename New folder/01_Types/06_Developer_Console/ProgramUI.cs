using _06_Developer_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Developer_Console
{
    class ProgramUI
    {
        private DevRepo _devRepo = new DevRepo();

        //method to start application//
        public void Run()
        {
            SeedContentList();

            Menu();
        }

        //menu//
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {

                //display our options to user
                
                Console.WriteLine("Select a menu option:\n" +
                    "1. Create New Developers\n" +
                    "2. View All Content\n" +
                    "3. View Developers who need Pluralsight" +
                    "4. Update Exisiting Content \n" +
                    "5. Delete Exisiting Content\n" +
                    "6. Exit") ;

                //get users input
                string input = Console.ReadLine();

                //evaluate users input and act

                switch (input)
                {
                    case "1":
                        CreateNewDevelopers();
                        break;
                    case "2":
                        ViewAllDevelopers();
                        break;
                    case "3":
                        ViewListOfPluralSight();
                        break;
                    case "4":
                        UpdateExistingContent();
                        break;
                    case "5":
                        DeleteExistingContent();
                        break;
                    case "6":
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter valid number");
                        break;
                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }

        }

        //#1
        private void CreateNewDevelopers()
        {
            Console.Clear();
            DevClass1 newContent = new DevClass1();
            //Name
            Console.WriteLine("Enter the name of the developer:");
            newContent.Name = Console.ReadLine();

            //IDs
            Console.WriteLine("Enter the ID nunmber of the developer:");
            string iDsAsString = Console.ReadLine();
            newContent.IDs = int.Parse(iDsAsString);


            //AccessToPluralsight
            Console.WriteLine("Does the developer have access to Pluralsight? (y/n)");
            string pluralSightString = Console.ReadLine().ToLower();

            if(pluralSightString == "y")
            {
                newContent.AccessToPluralsight = true;
                
            }
            else
            {
                newContent.AccessToPluralsight = false;
            }

            _devRepo.AddDevsToList(newContent);
        }

        //#2
        private void ViewAllDevelopers()
        {
            Console.Clear();
            List<DevClass1> listOfDevs = _devRepo.GetDevList();
            foreach(DevClass1 dev in listOfDevs)
            {
                Console.WriteLine($"Name: {dev.Name}\n" +
                    $" ID Number: {dev.IDs}");
            }
        }


        //#3
        private void ViewListOfPluralSight()
        {

            Console.Clear();
            Console.WriteLine("Write y if you would like to see those who still need Pluralsight");
            string pluralSightString = Console.ReadLine().ToLower();

            if (pluralSightString == "y")
            {
                AccessToPluralsight = true;
                Console.WriteLine($"{Name}");

            }
            else
            {
                AccessToPluralsight = false;
            }


        }

        //#4
        private void UpdateExistingContent()
        {
            ViewAllDevelopers();
            Console.WriteLine("Enter Developer you would like to update");
            string oldDevs = Console.ReadLine();

            DevClass1 newContent = new DevClass1();

            //Name
            Console.WriteLine("Enter the name of the developer:");
            newContent.Name = Console.ReadLine();

            //IDs
            Console.WriteLine("Enter the ID nunmber of the developer:");
            string iDsAsString = Console.ReadLine();
            newContent.IDs = int.Parse(iDsAsString);


            //AccessToPluralsight
            Console.WriteLine("Does the developer have access to Pluralsight? (y/n)");
            string pluralSightString = Console.ReadLine().ToLower();

            if (pluralSightString == "y")
            {
                newContent.AccessToPluralsight = true;
            }
            else
            {
                newContent.AccessToPluralsight = false;
            }

            bool wasUpdated = _devRepo.UpdateExisitingDev(oldDevs, newContent);
            if(wasUpdated)
            {
                Console.WriteLine("Successfully updated");
            }
            else
            {
                Console.WriteLine("Could not update");
            }
        }

        //#5
        private void DeleteExistingContent()
        {
            Console.Clear();
            ViewAllDevelopers();
            Console.WriteLine("What Developer do you want to delete?");

            string input = Console.ReadLine();

            bool wasDeleted= _devRepo.RemoveNameFromList(input);

            if(wasDeleted)
            {
                Console.WriteLine("Your Developer was deleted");
            }
            else
            {
                Console.WriteLine("Could not be deleted");
            }
            
            



        }

        //see method
        private void SeedContentList()
        {
            DevClass1 johnDeer = new DevClass1("John Deer",234,true);
            DevClass1 susanSmith = new DevClass1("Susan Smith", 454, false);
            DevClass1 marySue = new DevClass1("Mary Sue", 113, false);

            _devRepo.AddDevsToList(johnDeer);
            _devRepo.AddDevsToList(susanSmith);
            _devRepo.AddDevsToList(marySue);

        }

    }
}
