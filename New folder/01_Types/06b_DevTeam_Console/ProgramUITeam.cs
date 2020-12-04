using _06b_DevTeam_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06b_DevTeam_Console
{
    class ProgramUITeam
    {
        private DevTeamRepo _devTeamRepo = new DevTeamRepo();
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
                //need a list of all Developers that need a Pluralsight license
                Console.WriteLine("Select a menu option:\n" +
                "1. Create New Developers\n" +
                "2. View All Content\n" +
                "3. View Developers within a Team\n" +
                "4. Update Developers\n" +
                "5. Delete Developers\n" +
                "6. Exit");
                //get users input
                string input = Console.ReadLine();


                //evaluate users input and act

                switch (input)
                {
                    case "1":
                        CreateNewDevelopers();
                        break;
                    case "2":
                        ViewAllContent(); 
                        break;
                    case "3":
                        ViewDevsInTeam();
                        break;
                    case "4":
                        UpdateDevelopers();
                        break;
                    case "5":
                        DeleteDevelopers();
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

        //1
        private void CreateNewDevelopers()
        {
            Console.Clear();
            DevTeamClass1 newContent = new DevTeamClass1();
            //Developer
            Console.WriteLine("Enter the name of the developer:");
            newContent.Developer = Console.ReadLine();

            //TeamIDs
            Console.WriteLine("Enter the team ID nunmber of the developer:");
            string iDsAsString = Console.ReadLine();
            newContent.TeamID = int.Parse(iDsAsString);


            //TeamName
            Console.WriteLine("Enter team name for developer");
            newContent.TeamName = Console.ReadLine();

            

            _devTeamRepo.AddDevsToList(newContent);
        }
        //2
        private void ViewAllContent()
        {

                Console.Clear();
                List<DevTeamClass1> listOfDevs = _devTeamRepo.GetDevTeamList();
                foreach (DevTeamClass1 dev in listOfDevs)
                {
                Console.WriteLine($"Name: {dev.Developer}\n" +
                    $" ID Number: {dev.TeamID}\n" +
                    $" Team Name: {dev.TeamName}");
                }
           
        }
        //3
        private void ViewDevsInTeam()
        {
            Console.WriteLine("Which team would you like to see? (Blue, Green, Red)");
            string teamName= Console.ReadLine().ToLower();

           
        }

        //4
        private void UpdateDevelopers()
        {
            ViewAllContent();
            Console.WriteLine("Enter Developer you would like to update");
            string oldDevs = Console.ReadLine();

            DevTeamClass1 newContent = new DevTeamClass1();

            //Name
            Console.WriteLine("Enter the name of the developer:");
            newContent.Developer = Console.ReadLine();

            //IDs
            Console.WriteLine("Enter the ID nunmber of the developer:");
            string iDsAsString = Console.ReadLine();
            newContent.TeamID = int.Parse(iDsAsString);


            //Team
            Console.WriteLine("Enter the team of the developer");
            newContent.TeamName = Console.ReadLine();

   

            bool wasUpdated = _devTeamRepo.UpdateExisitingDevTeam(oldDevs, newContent);
            if (wasUpdated)
            {
                Console.WriteLine("Successfully updated");
            }
            else
            {
                Console.WriteLine("Could not update");
            }
        }

        //5

        private void DeleteDevelopers()
        {
            Console.Clear();
            ViewAllContent();
            Console.WriteLine("What Developer do you want to delete?");

            string input = Console.ReadLine();

            bool wasDeleted = _devTeamRepo.RemoveNameFromList(input);

            if (wasDeleted)
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
            DevTeamClass1 johnDeer = new DevTeamClass1("John Deer", "Blue", 123);
            DevTeamClass1 susanSmith = new DevTeamClass1("Susan Smith", "Green", 456);
            DevTeamClass1 marySue = new DevTeamClass1("Mary Sue", "Red", 789);

            _devTeamRepo.AddDevsToList(johnDeer);
            _devTeamRepo.AddDevsToList(susanSmith);
            _devTeamRepo.AddDevsToList(marySue);

        }




    }

}
