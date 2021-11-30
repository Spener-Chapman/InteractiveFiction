using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        static string[] savePage;
        static string storyWritten;
        static string optionA;
        static string optionB;
        static string pageA = "0";
        static string pageB;

        


        static void Main(string[] args)
        {
            story = System.IO.File.ReadAllLines(@"story.txt");
            savePage = System.IO.File.ReadAllLines(@"savefile.txt");
            WriteTitlePage(); // since it's initialized to be the title page, this will always play the title page here
            

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
                        if (string.IsNullOrWhiteSpace(savePage[0]))
                        {
                            Console.WriteLine("There is no save found");
                        }
                        else
                        {
                            
                            page = savePage;
                            WritePage();
                            OnTitleScreen = false;
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
                            PageChange();
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
                            PageChange();
                        }
                    }
                    else if (readKeyInput.Key == ConsoleKey.C)        // saves what page you're on in a file called savefile.txt
                    {
                        System.IO.File.WriteAllLines(@"savefile.txt", page);
                        savePage = System.IO.File.ReadAllLines(@"savefile.txt");
                        gameOver = true;
                    }
                }
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("What will you do?");
            Console.ResetColor();
            if (string.IsNullOrWhiteSpace(page[3]))
            {
                
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("A ");
                Console.ResetColor();
                Console.WriteLine(optionA);
            }
            if (string.IsNullOrWhiteSpace(page[4]))
            {

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("B ");
                Console.ResetColor();
                Console.WriteLine(optionB);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("C ");
            Console.ResetColor();
            Console.WriteLine("Save & Quit");
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
        }
        
        

        static void PageChange()
        {
            
            page = story[currentPage].Split('_');

            

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
