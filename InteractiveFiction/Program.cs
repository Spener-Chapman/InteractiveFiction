using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveFiction
{
    
    class Program
    {
        static bool gameOver = false;
        static bool OnTitleScreen = true;
        static int currentPage = 0;
        static int pageNumber = 1;
        static int optionAPage;
        static int optionBPage;
        static string[] story = new string[100];
        static void Main(string[] args)
        {
            
            StoryInitialization();
            PageSetup();
            TitlePage();

            while (gameOver == false)
            {

                ConsoleKeyInfo readKeyInput = Console.ReadKey(true);

                if (OnTitleScreen == true)
                {
                    if (readKeyInput.Key == ConsoleKey.A)
                    {

                        Page();
                        OnTitleScreen = false;
                    }
                    else if (readKeyInput.Key == ConsoleKey.B)
                    {
                        gameOver = true;
                    }
                }

                else if (OnTitleScreen == false)
                {
                    if (readKeyInput.Key == ConsoleKey.A)
                    {
                        currentPage = optionAPage;

                        PageSetup();
                        Page();

                    }
                    else if (readKeyInput.Key == ConsoleKey.B)
                    {
                        currentPage = optionBPage;
                        PageSetup();
                        Page();

                    }
                }



            
                
            }

        }
        
        
       
        
        static void Page()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Page " + (pageNumber));
            Console.WriteLine("");
            Console.WriteLine("" + story[currentPage]);
            Console.WriteLine("");
            Console.WriteLine("What will you do?");
            Console.WriteLine("");
            Console.WriteLine("A:" + story[(currentPage + 1)]);
            Console.WriteLine("B:" + story[(currentPage + 2)]);
            Console.WriteLine("");
            

        }
        static void TitlePage()
        {
            Console.WriteLine("titlepage wip");
            Console.WriteLine("press a to start");
            Console.WriteLine("press b to quit");

        }
       
        
        static void StoryInitialization()
        {
            story[0] = "You wake up in a dark room, groggy and confused. The first thing you notice is the dust of the bed which you're resting on, along with the scent of mildew lingering in the air. Your confusion morphs into fear, you realise you don't remember where you are, nor how you got here. Squinting around the room, you can faintly see the outline of a dresser, along with a faint glow under the crack of what you assume is the door. "; // the title page  
            story[1] = "Explore the room"; // go to story 3
            story[2] = "Open the door"; // go to story 6

            story[3] = "Thinking it probably isn't the best idea to boldly jump out into the unknown, you instead look around the room. to your left is that door, with the dresser directly across from you. To your right there appears to be some sort of cabinet, and upon closer inspection, a window covered by a long, simple curtain."; // see story 1 
            story[4] = "Look out the window"; // go to story 9
            story[5] = "Open the door"; // go to story 6 

            story[6] = "Opening the door, you're greeted by a startling sight. Sn ornately decorated hall greets you on the other side, wall mounted candles illuminating the carpet with its swirling patterns. To your right, a large, wooden door blocks your path, to your left, a seemingly unending hall."; //  see story 2, or 6
            story[7] = "Go right"; // go to story 12
            story[8] = "Go left"; //  go to story 15

            story[9] = "Walking towards the window, you see the faint rays of moonlight filtering through the gaps in the fabric. On the other side, a weathered window with a simple latch is seen. Looking out, you notice you're on what seems to be the second floor, a roof sloping out just below you, leading your eyes to a large courtyard. Before you can find out any more, you hear the click of footsteps coming this way."; // see story 3
            story[10] = "Hide!"; // go to story 18
            story[11] = "Go out on the roof"; // go to story 21

            story[12] = " went right"; // see story 6
            story[13] = "a"; // see story 25
            story[14] = "b"; // see story 27

            story[15] = " went left"; // see story 6
            story[16] = "a"; // see story 30
            story[17] = "b"; // see story 33

            story[18] = "hid"; // see story 9
            story[19] = "a";
            story[20] = "b";

            story[21] = "roof"; // see story 9
            story[22] = "a";
            story[23] = "b";

            story[24] = "";
            story[25] = "";
            story[26] = "";

            story[27] = "";
            story[28] = "";
            story[29] = "";

            story[30] = "";
            story[31] = "";
            story[32] = "";

            story[33] = "";
            story[34] = "";
            story[35] = "";




        }

        static void PageSetup()
        {
            if (currentPage == 0)
            {
                optionAPage = 3;
                optionBPage = 6;
                pageNumber = 1;
            }
            else if (currentPage == 3)
            {
                optionAPage = 9;
                optionBPage = 6;
                pageNumber = 2;
            }
            else if (currentPage == 6)
            {
                optionAPage = 12;
                optionBPage = 15;
                pageNumber = 3;
            }
            else if (currentPage == 9)
            {
                optionAPage = 18;
                optionBPage = 21;
                pageNumber = 4;
            }
            else if (currentPage == 12)
            {
                optionAPage = 25;
                optionBPage = 26;
                pageNumber = 5;
            }
            else if (currentPage == 15)
            {
                optionAPage = 12;
                optionBPage = 15;
                pageNumber = 6;
            }
            else if (currentPage == 18)
            {
                optionAPage = 12;
                optionBPage = 15;
                pageNumber = 7;
            }
            else if (currentPage == 21)
            {
                optionAPage = 12;
                optionBPage = 15;
                pageNumber = 8;
            }
        }
    }
}
