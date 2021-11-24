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
       
       
        static string[] story = new string[100];

        static int currentPage = 0;

        static string[] page;
        static string storyWritten;
        static string optionA;
        static string optionB;
        static string pageA = "0";
        static string pageB;

        


        static void Main(string[] args)
        {
            StoryInitialization(); // where the story is saved, this initializes the story
            PageChange(); // since it's initialized to be the title page, this will always play the title page here
            

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
                    else if (readKeyInput.Key == ConsoleKey.B)        // quits the game
                    {
                        gameOver = true;
                    }
                }

                else if (OnTitleScreen == false)
                {
                    if (readKeyInput.Key == ConsoleKey.A)
                    {
                        currentPage = Int32.Parse(pageA);
                        PageChange();
                    }
                    else if (readKeyInput.Key == ConsoleKey.B)
                    {
                        currentPage = Int32.Parse(pageB);
                        PageChange();
                    }
                }
            }

        }
        
        
       
        
       
       
        
        static void StoryInitialization() // where the story is saved
        {
            story[0] = "title_Start_Quit_1_ ";
            story[1] = "You wake up in a dark room, groggy and confused. The first thing you notice is the dust of the bed which you're resting on, along with the scent of mildew lingering in the air. Your confusion morphs into fear, you realise you don't remember where you are, nor how you got here. Squinting around the room, you can faintly see the outline of a dresser, along with a faint glow under the crack of what you assume is the door._Explore the room_Open the door_2_3"; // the title page  
            
            story[2] = "Thinking it probably isn't the best idea to boldly jump out into the unknown, you instead look around the room. To your left is that door, with the dresser directly across from you. To your right there appears to be some sort of cabinet, and upon closer inspection, a window covered by a long, simple curtain._Look out the window _Open the door _4_3";  

            story[3] = "Opening the door, you're greeted by a startling sight. An ornately decorated hall greets you on the other side, wall mounted candles illuminating the carpet with its swirling patterns. To your right, a large, wooden door blocks your path, to your left, a seemingly unending hall._Go right_Go left_5_6"; 

            story[4] = "Walking towards the window, you see the faint rays of moonlight filtering through the gaps in the fabric. On the other side, a weathered window with a simple latch is seen. Looking out, you notice you're on what seems to be the second floor, a roof sloping out just below you, leading your eyes to a large courtyard. Before you can find out any more, you hear the click of footsteps coming this way._Hide!_Go on the roof_7_8"; // see story 4

            story[5] = "Walking up to the large doors, you push forward; slowly moving the heavy wood aside, you find yourself in a magnificent library. Everywhere you look, books line the walls, except for the large fareplace directly across from you. A large portrait looms overhead, and a worn chair sits by a small table by the fireplace._Investigate the painting_Look at the books_9_11"; // see story 12
         
            story[6] = "With one last glance, you decide to sneak down the hall towards the unkown. With each step the heavy beating of your heart is all you hear. Slowly passing closed doors, you come to a grand foyer. Two grand staircases line the walls; the main focus point, a sparkling chandalier, hangs comfortably in the center of the room, right a bove a shining grand piano. Further down the hall, the sound of a door closing, along with the accompaning clicks of footsteps, gets your attention._Go downstairs_Run back to your room!_ _10"; // see story 15
            //story[16] = "Go downstairs"; // see story 30
            //story[17] = "Run back to your room"; // see story 33

            story[7] = "Climbing into the cabinet as quick as you can, you hold your breath as the door to your room creaks open. You hear a faint gasp as a glass breaks. 'Lady Camilla? Lady Camilla I must ask you to come this instant!' An older voice cries out, as they run down the hall._Continue hiding_Leave the cabinet_ _ "; // see story 9
            //story[19] = "Continue Hiding"; // see story 36
            //story[20] = "Leave the cabinet"; // see story 39

            story[8] = "Quickly opening the latch and swinging the window open, you clamber out onto the roof. It's colder than you expected, crossing your arms as you shiver under the moonlight. Getting a better look now, you can see a decorated fountain in the middle of the courtyard, surrounded by a garden of roses. further past that, a hedge maze with some large, white, object in the middle of it. Now that you think of it, how are you going to get down from here?_The tree by the corner of the courtyard_Find an unlocked window_ _ "; // see story 9
           
            story[9] = "The painting seems very old, it consists of a woman and man, along with three children. One girl sticks out to you though, her long brown hair, and her ear to ear grin, complimented by her joyful blue eyes. Seeing her so happy... it fills you with sadness._ _ _ _ ";
           
            story[10] = "Running back to your room, you look around in panic. The cabinet could probably hide a child your size. Looking out the window to the softly sloped roof below you, you notice the latch seems pretty easy to open._Hide!_Climb out onto the roof_7_8";

            story[11] = "Looking around the countless bookshelves, you run your hand along them as you walk by. You can tell its a well kept room, almost jealous that the books were kept better than you. Now in the back corner of the room you stop. A large book titled 'The History of the von Trapps' catches you eyes. You don't know why, but you instinctively reach out and grab it. But in doing so, the entire bookshelf begins to shake violently, soon slowly swinging open to reveal a sectret staircase._Enter the staircase_Make a torch first_ _ ";

            story[12] = "Quickly running down the stairs you slide under the piano, as you listen to the mysterious steps pass by. Slowly crawling out from your hiding place, you begin to get a better look. A large mirror is centered on the wall below the rails of the upper landing.";


        }

        static void PageChange()
        {
            
            page = story[currentPage].Split('_');

            storyWritten = page[0];
            optionA = page[1];
            optionB = page[2];
            pageA = page[3];
            pageB = page[4];

            Console.WriteLine("");
            Console.WriteLine(storyWritten);
            Console.WriteLine();
            Console.WriteLine("What will you do?");
            Console.WriteLine("A " + optionA + " " + pageA);
            Console.WriteLine("B " + optionB + " " + pageB);

        }



        // page
        // page[0] = You wake up in a dark room, groggy and confused. The first thing you notice is the dust of the bed which you're resting on, along with the scent of mildew lingering in the air. Your confusion morphs into fear, you realise you don't remember where you are, nor how you got here. Squinting around the room, you can faintly see the outline of a dresser, along with a faint glow under the crack of what you assume is the door.
        // page[1] = Explore the room
        // page[2] = Open the door
        // page[3] = 2
        // page[4] = 3
        

    }
}
