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
            
            StoryInitialization(); // where the story is saved, this initializes the story
            PageSetup(); // Loads upcoming page
            TitlePage(); // Writes the title page 

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
                        currentPage = optionAPage;           // tells pagesetup what page will be loaded, in this case, option a's path is the page to be loaded

                        PageSetup();                         // sets up the page
                        Page();                              // writes the page

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
       
        
        static void StoryInitialization() // where the story is saved
        {
            story[0] = "You wake up in a dark room, groggy and confused. The first thing you notice is the dust of the bed which you're resting on, along with the scent of mildew lingering in the air. Your confusion morphs into fear, you realise you don't remember where you are, nor how you got here. Squinting around the room, you can faintly see the outline of a dresser, along with a faint glow under the crack of what you assume is the door. "; // the title page  
            story[1] = "Explore the room"; // go to story 3
            story[2] = "Open the door"; // go to story 6

            story[3] = "Thinking it probably isn't the best idea to boldly jump out into the unknown, you instead look around the room. To your left is that door, with the dresser directly across from you. To your right there appears to be some sort of cabinet, and upon closer inspection, a window covered by a long, simple curtain."; // see story 1 
            story[4] = "Look out the window"; // go to story 9
            story[5] = "Open the door"; // go to story 6 

            story[6] = "Opening the door, you're greeted by a startling sight. An ornately decorated hall greets you on the other side, wall mounted candles illuminating the carpet with its swirling patterns. To your right, a large, wooden door blocks your path, to your left, a seemingly unending hall."; //  see story 2, or 6
            story[7] = "Go right"; // go to story 12
            story[8] = "Go left"; //  go to story 15

            story[9] = "Walking towards the window, you see the faint rays of moonlight filtering through the gaps in the fabric. On the other side, a weathered window with a simple latch is seen. Looking out, you notice you're on what seems to be the second floor, a roof sloping out just below you, leading your eyes to a large courtyard. Before you can find out any more, you hear the click of footsteps coming this way."; // see story 4
            story[10] = "Hide!"; // go to story 18
            story[11] = "Go out on the roof"; // go to story 21

            story[12] = "Walking up to the large doors, you push forward; slowly moving the heavy wood aside, you find yourself in a magnificent library. Everywhere you look, books line the walls, except for the large fareplace directly across from you. A large portrait looms overhead, and a worn chair sits by a small table by the fireplace."; // see story 12
            story[13] = "Investigate the painting"; // see story 24
            story[14] = "Investigate the books"; // see story 27

            story[15] = "With one last glance, you decide to sneak down the hall towards the unkown. With each step the heavy beating of your heart is all you hear. Slowly passing closed doors, you come to a grand foyer. Two grand staircases line the walls; the main focus point, a sparkling chandalier, hangs comfortably in the center of the room. Further down the hall, the sound of a door closing, along with the accompaning clicks of footsteps, gets your attention."; // see story 15
            story[16] = "Go downstairs"; // see story 30
            story[17] = "Run back to your room"; // see story 33

            story[18] = "Climbing into the cabinet as quick as you can, you hold your breath as the door to your room creaks open. You hear a faint gasp as a glass breaks. 'Lady Camilla? Lady Camilla I must ask you to come this instant!' An older voice cries out, as they run down the hall"; // see story 9
            story[19] = "Continue Hiding"; // see story 36
            story[20] = "Leave the cabinet"; // see story 39

            story[21] = "Quickly opening the latch and swinging the window open, you clamber out onto the roof. It's colder than you expected, crossing your arms as you shiver under the moonlight. Getting a better look now, you can see a decorated fountain in the middle of the courtyard, surrounded by a garden of roses. further past that, a hedge maze with some large, white, object in the middle of it. Now that you think of it, how are you going to get down from here?"; // see story 9
            story[22] = "The tree in the corner of the courtyard"; // see story 42
            story[23] = "Find an unlocked window"; // see story 45 (enter the foyer)

            story[24] = "The painting seems very old, it consists of a woman and man, along with three children. One girl sticks out to you though, her long brown hair, and her ear to ear grin, complimented by her joyful blue eyes. Seeing her so happy... it fills you with sadness.";
            story[25] = "";
            story[26] = "";

            story[27] = "";
            story[28] = "";
            story[29] = "";

            story[30] = "";
            story[31] = "";
            story[32] = "";

            story[33] = "Running back to your room, you look around in panic. The cabinet could probably hide a child your size. Looking out the window to the softly sloped roof below you, you notice the latch seems pretty easy to open.";
            story[34] = "Hide!"; // see story 18
            story[35] = "Climb out on the roof"; // see story 21




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
                optionAPage = 30;
                optionBPage = 33;
                pageNumber = 6;
            }
            else if (currentPage == 18)
            {
                optionAPage = 36;
                optionBPage = 39;
                pageNumber = 7;
            }
            else if (currentPage == 21)
            {
                optionAPage = 42;
                optionBPage = 45;
                pageNumber = 8;
            }
            else if (currentPage == 24)
            {
                optionAPage = 18;
                optionBPage = 21;
                pageNumber = 9;
            }
            else if (currentPage == 27)
            {
                optionAPage = 18;
                optionBPage = 21;
                pageNumber = 10;
            }
            else if (currentPage == 30)
            {
                optionAPage = 18;
                optionBPage = 21;
                pageNumber = 11;
            }
            else if (currentPage == 33)
            {
                optionAPage = 18;
                optionBPage = 21;
                pageNumber = 12;
            }
        }
    }
}
