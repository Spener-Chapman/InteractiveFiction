using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InteractiveFiction
{
    //
    //
    //  DO NOT USE PAGE SETUP IT IS HARD CODING
    //
    //



    class Program
    {
        static bool gameOver = false;
        
        static bool OnTitleScreen = true;


        static string[] story;

        static int currentPage = 0;

        static string[] page;
        static string savePage;
        static string storyWritten;
        static string optionA;
        static string optionB;
        static string pageA = "0";
        static string pageB;

        


        static void Main(string[] args)
        {
            
            BootUp();       // checks for errors and boots up the story file, which is needed during the error check

            
            
            

            WriteTitlePage(); // since it's initialized to be the title page, this will always play the title page here

            Console.Write(savePage);
            while (gameOver == false)
            {

                ConsoleKeyInfo readKeyInput = Console.ReadKey(true);

                if (OnTitleScreen == true)                            // the reason this is here is to be able to quit the game from the title screen
                {
                    if (readKeyInput.Key == ConsoleKey.A)             // removes this ability and brings you to page one
                    {
                        
                        currentPage = Int32.Parse(pageA);
                        OnTitleScreen = false;                      
                        PageChange();
                    }
                    else if (readKeyInput.Key == ConsoleKey.B)  // finds the save file, and writes what page was saved on it
                    {
                        if (System.IO.File.Exists(@"savefile.txt"))
                        {
                            savePage = System.IO.File.ReadAllText(@"savefile.txt");
                            page = savePage.Split('_');
                            
                            WritePage();
                            OnTitleScreen = false;
                        }
                        else
                        {
                            Console.WriteLine("There is no save found");         // errpr checking for no save
                        }
                    }
                    else if (readKeyInput.Key == ConsoleKey.C)        // quits the game
                    {
                        gameOver = true;
                    }
                }

                else if (OnTitleScreen == false)
                {
                    if (readKeyInput.Key == ConsoleKey.A)             // chooses option a
                    {
                        if (string.IsNullOrWhiteSpace(page[3]))
                        {
                            ReturnToTitle();
                        }
                        else
                        {
                            
                            currentPage = Int32.Parse(pageA);
                            TurnPage();
                            
                        }
                    }
                    else if (readKeyInput.Key == ConsoleKey.B)        // chooses option b
                    {
                        if (string.IsNullOrWhiteSpace(page[4]))
                        {
                            ReturnToTitle();
                        }
                        else
                        {
                            
                            currentPage = Int32.Parse(pageB);
                            TurnPage();
                            
                        }
                    }
                    else if (readKeyInput.Key == ConsoleKey.C)        // saves what page you're on in a file called savefile.txt
                    {
                        SaveGame();
                        
                    }
                    else if (readKeyInput.Key == ConsoleKey.D)
                    {
                        gameOver = true;
                    }
                }
            }

        }
        
        static void BootUp()
        {
            FindStory();
            FindBlankStory();
            story = System.IO.File.ReadAllLines(@"story.txt");
            FindBlankLines();
        }

        static void FindStory() // checks if the story file exists
        {
            if (System.IO.File.Exists(@"story.txt"))
            {

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("There is no story file");
                Console.WriteLine("");
                Console.WriteLine("Press any Key to exit");
                Console.WriteLine("");
                Console.ReadKey(true);
                Environment.Exit(0);
            }
        }

        static void FindBlankStory()
        {
            if (string.IsNullOrWhiteSpace(System.IO.File.ReadAllText(@"story.txt")))
            {
                Console.WriteLine("Story.txt is empty");
                Console.WriteLine("Press any Key to exit");
                Console.WriteLine("");
                Console.ReadKey(true);
                Environment.Exit(0);
            }
            else 
            {
                
            }
        }

        static void FindBlankLines()
        {
            for (int i = 0; i <= 16; i++)
            {
                if (string.IsNullOrEmpty(story[i]))
                {
                    Console.WriteLine("There is a missing line of story");
                    Console.WriteLine("");
                    Console.WriteLine("Press any Key to exit");
                    Console.WriteLine("");
                    Console.ReadKey(true);
                    Environment.Exit(0);
                }
                else
                {
                    
                }
            }
        }
        static void CheckDelimiterLimit()
        {
            if (page.Length > 5)
            {
                Console.WriteLine("there are too many delimiters in this string");
                Console.WriteLine("");
                Console.WriteLine("Press any Key to exit");
                Console.WriteLine("");
                Console.ReadKey(true);
                Environment.Exit(0);
            }
            if (page.Length < 5)
            {
                Console.WriteLine("there are too few delimiters in this string");
                Console.WriteLine("");
                Console.WriteLine("Press any Key to exit");
                Console.WriteLine("");
                Console.ReadKey(true);
                Environment.Exit(0);
            }
        }
        static void TurnPage()
        {
            if (currentPage > 16)
            {
                Console.WriteLine("There is no page found with this number.");
                Console.WriteLine("");
                Console.WriteLine("Going back to title page.");
                Console.WriteLine("");
                Console.ReadKey(true);
                ReturnToTitle();
            }
            else if (currentPage < 0)
            {
                Console.WriteLine("There is no page found with this number.");
                Console.WriteLine("");
                Console.WriteLine("Press any key to return to the title page.");
                Console.WriteLine("");
                Console.ReadKey(true);
                ReturnToTitle();
            }
            else
            {
                PageChange();
            }
        }
        static void WriteTitlePage()
        {
            page = story[0].Split('_');
            storyWritten = page[0];
            pageA = page[3];

            Console.WriteLine();
            Console.WriteLine(storyWritten);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("A ");
            Console.ResetColor();
            Console.WriteLine("New Game");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("B ");
            Console.ResetColor();
            Console.WriteLine("Load Game");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("C ");
            Console.ResetColor();
            Console.WriteLine("Quit Game");

        }

        static void SaveGame()
        {
            page = story[currentPage].Split('_');
            System.IO.File.WriteAllText(@"savefile.txt", story[currentPage]);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Game Saved");
            Console.ResetColor();
            
        }
        static void WritePage()
        {
            storyWritten = page[0];
            optionA = page[1];
            optionB = page[2];
            pageA = page[3];
            pageB = page[4];

            Console.WriteLine("");
            Console.WriteLine(storyWritten);
            Console.WriteLine();
            
            if (string.IsNullOrWhiteSpace(page[3]))
            {

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("What will you do?");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("A ");
                Console.ResetColor();
                Console.WriteLine(optionA);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("B ");
                Console.ResetColor();
                Console.WriteLine(optionB);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("C ");
                Console.ResetColor();
                Console.WriteLine("Save");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("D ");
                Console.ResetColor();
                Console.WriteLine("Quit");
            }
        }

        static void ReturnToTitle()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            WriteTitlePage();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            OnTitleScreen = true;
        }
        
        

        static void PageChange()
        {
            
            page = story[currentPage].Split('_');
            CheckDelimiterLimit();


            WritePage();

        }



        // page
        // page[0] = You wake up in a dark room, groggy and confused. The first thing you notice is the dust of the bed which you're resting on, along with the scent of mildew lingering in the air. Your confusion morphs into fear, you realise you don't remember where you are, nor how you got here. Squinting around the room, you can faintly see the outline of a dresser, along with a faint glow under the crack of what you assume is the door.
        // page[1] = Explore the room
        // page[2] = Open the door
        // page[3] = 2
        // page[4] = 3
        

    }
}
