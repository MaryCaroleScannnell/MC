using _06_RepoPattern_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepoPattern_Console
{
    class ProgramUI
    {
        private StreamingContentRepo _contentRepo = new StreamingContentRepo();
        //the responsibility of the ProgramUI class is:
        // to run all the ProgramUI methods
        public void Run()
        //this will be the method that starts/runs the application
        {
            SeedContentList();
            Menu();
        }

        //menu method
        private void Menu()
        {
            bool keepRunninng = true;
            while (keepRunninng)
            {

                //display the options for user
                Console.WriteLine("Select a menu option:\n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By Title \n" +
                    "4. Update Existing Content \n" +
                    "5. Delete Existing Content \n" +
                    "6. Exit");

                //get the users input
                string input = Console.ReadLine();

                //evaluate the users input and act accordinngly
                switch (input)
                {
                    case "1":
                        //create new content
                        CreateNewContent();
                        break;
                    case "2":
                        DisplayAllContent();
                        //view all content
                        break;
                    case "3":
                        DisplayContentByTitle();
                        //view content by title
                        break;
                    case "4":
                        UpdateExistingContent();
                        //update exisiting content
                        break;
                    case "5":
                        DeleteExistingContent();
                        //delete existing content
                        break;
                    case "6":
                        //exit
                        keepRunninng = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Please enter valid number");
                        break;
                }
                Console.WriteLine("Please press any key to countinue..");
                Console.ReadKey();
                Console.Clear();
            }
        }
        //method for: Create New StreamingContent
        private void CreateNewContent()
        {
            Console.Clear();
            StreamingContent newContent = new StreamingContent();

            //Title
            Console.WriteLine("Enter the title for the content");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the description for content");
            newContent.Description = Console.ReadLine();

            //Maturity Rating
            Console.WriteLine("Enter rating for conten: (G, PG, PG-13, etc):");
            newContent.MaturityRating = Console.ReadLine();

            //Star Rating
            Console.WriteLine("Enter the star count for the content (5.8, 10, 1.5 etc):");
            string starsAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starsAsString);

            //IsFamilyFriendly
            Console.WriteLine("Is this content family friendly? (y/n)");
            string familyFriendlyString = Console.ReadLine().ToLower();

            if (familyFriendlyString == "y")
            {
                newContent.IsFamilyFriendly = true;
            }
            else
            {
                newContent.IsFamilyFriendly = false;
            }

            //GenreType
            //Horror, RomCom, SciFi, Documentary, Bromance, Drama, Action

            Console.WriteLine("Enter the Genre Number: \n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Bromance\n" +
                "6. Drama\n" +
                "7. Action");
            string genreAsString = Console.ReadLine();
            int genreAsInt = int.Parse(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            _contentRepo.AddContentToList(newContent);
        }

        //method for: New Current StreamingContent that is saved
        private void DisplayAllContent()
        {
            Console.Clear();
            List<StreamingContent> listOfContent = _contentRepo.GetContentList();
            foreach(StreamingContent content in listOfContent)
            {
                Console.WriteLine($"Title:{content.Title}\n" +
                    $" Desc: {content.Description} ");
            }
        }
        //View content by title
        private void DisplayContentByTitle()
        {
            Console.Clear();
            //prompted the user to give me a title
            Console.WriteLine("Enter title of content you would like to see:");
            //get users input

            string title = Console.ReadLine();

            //find the content by that title
           StreamingContent content = _contentRepo.GetContentByTitle(title);

            //display content if it isn't null
            if(content != null)
            {
                Console.WriteLine($"Title:{content.Title}\n" +
                    $" Desc: {content.Description}\n" +
                    $"Maturity Rating: {content.MaturityRating}\n" +
                    $"Stars: {content.StarRating}\n" +
                    $"Is Family Friendly: {content.IsFamilyFriendly}\n" +
                    $"Genre: {content.TypeOfGenre}");
            }
            else
            {
                Console.WriteLine("No content by that title");
            }
        }
        //Update existing content
        private void UpdateExistingContent()
        {
            //display all content
            DisplayAllContent();

            //ask for title you need updated
            Console.WriteLine("Enter the title you would like to update");

            //get the title
            string oldTitle=Console.ReadLine();

            //We will build a new object
            StreamingContent newContent = new StreamingContent();

            //Title
            Console.WriteLine("Enter the title for the content");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the description for content");
            newContent.Description = Console.ReadLine();

            //Maturity Rating
            Console.WriteLine("Enter rating for conten: (G, PG, PG-13, etc):");
            newContent.MaturityRating = Console.ReadLine();

            //Star Rating
            Console.WriteLine("Enter the star count for the content (5.8, 10, 1.5 etc):");
            string starsAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starsAsString);

            //IsFamilyFriendly
            Console.WriteLine("Is this content family friendly? (y/n)");
            string familyFriendlyString = Console.ReadLine().ToLower();

            if (familyFriendlyString == "y")
            {
                newContent.IsFamilyFriendly = true;
            }
            else
            {
                newContent.IsFamilyFriendly = false;
            }

            //GenreType
            //Horror, RomCom, SciFi, Documentary, Bromance, Drama, Action

            Console.WriteLine("Enter the Genre Number: \n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Bromance\n" +
                "6. Drama\n" +
                "7. Action");
            string genreAsString = Console.ReadLine();
            int genreAsInt = int.Parse(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            //verify it worked
           bool wasUpdated= _contentRepo.UpdateExistingContent(oldTitle, newContent);
            if (wasUpdated)
            {
                Console.WriteLine("Content successfully updated!");
            }
            else
            {
                Console.WriteLine("Could not update content");
            }
        }
        //Delete existing content
        private void DeleteExistingContent()
        {

            DisplayAllContent();
            //get the title they want to delete
            Console.WriteLine("\nEnter the title of content you'd like to remove");

            string input = Console.ReadLine();
            //call the delete method//
            bool wasDeleted=_contentRepo.RemoveContentFromList(input);

            //if content was deleted, say so
            //otherwise state it could not be deleted
            if (wasDeleted)
            {
                Console.WriteLine("The content was successfully deleted");
            }
            else
            {
                Console.WriteLine("Content could not be deleted");
            }

        }
        //see method
        private void SeedContentList()
        {
            StreamingContent sharknado = new StreamingContent("Sharknado", "Tornados, but with sharks", "TV-14", 3.3, true, GenreType.Action);
            StreamingContent theRoom = new StreamingContent("The Room", "Banker's life gets turned upside down", "R", 3.7, false, GenreType.Drama);
            StreamingContent rubber = new StreamingContent("Rubber","Car tire comes to life and goes on a killing spree", "R", 5.8, false, GenreType.Documentary);

            _contentRepo.AddContentToList(sharknado);
            _contentRepo.AddContentToList(rubber);
            _contentRepo.AddContentToList(theRoom);
        }
    }

}
