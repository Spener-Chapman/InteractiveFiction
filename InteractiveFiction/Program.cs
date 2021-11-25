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
                    if (readKeyInput.Key == ConsoleKey.A)             // chooses option a
                    {
                        currentPage = Int32.Parse(pageA);
                        PageChange();
                    }
                    else if (readKeyInput.Key == ConsoleKey.B)        // chooses option b
                    {
                        currentPage = Int32.Parse(pageB);
                        PageChange();
                    }
                    else if (readKeyInput.Key == ConsoleKey.Escape)        // chooses option b
                    {
                        gameOver = true;
                    }
                }
            }

        }
        
        
       
        
       
       
        
        static void StoryInitialization() // where the story is saved
        {
            story[0] = "Mourning in the Mysterious Mansion_Start_Quit_1_ ";

            story[1] = "You wake up in a dark room, groggy and confused. The first thing you notice is the dust of the bed which you're resting on, along with the scent of mildew lingering in the air. Your confusion morphs into fear, you realise you don't remember where you are, nor how you got here. Squinting around the room, you can faintly see the outline of a dresser, along with a faint glow under the crack of what you assume is the door._Explore the room_Open the door_2_3"; // the title page  
            
            story[2] = "Thinking it probably isn't the best idea to boldly jump out into the unknown, you instead look around the room. To your left is that door, with the dresser directly across from you. To your right there appears to be some sort of cabinet, and upon closer inspection, a window covered by a long, simple curtain._Look out the window _Open the door_4_3";  

            story[3] = "Opening the door, you're greeted by a startling sight. An ornately decorated hall greets you on the other side, wall mounted candles illuminating the carpet with its swirling patterns. To your right, a large, wooden door blocks your path, to your left, a seemingly unending hall._Go right_Go left_5_6"; 

            story[4] = "Walking towards the window, you see the faint rays of moonlight filtering through the gaps in the fabric. On the other side, a weathered window with a simple latch is seen. Looking out, you notice you're on what seems to be the second floor, a roof sloping out just below you, leading your eyes to a large courtyard. Before you can find out any more, you hear the click of footsteps coming this way._Hide!_Go on the roof_7_8"; 

            story[5] = "Walking up to the large doors, you push forward; slowly moving the heavy wood aside, you find yourself in a magnificent library. Everywhere you look, books line the walls, except for the large fareplace directly across from you. A large portrait looms overhead, and a worn chair sits by a small table by the fireplace._Investigate the painting_Look at the books_9_11"; 
         
            story[6] = "With one last glance, you decide to sneak down the hall towards the unkown. With each step the heavy beating of your heart is all you hear. Slowly passing closed doors, you come to a grand foyer. Two grand staircases line the walls; the main focus point, a sparkling chandalier, hangs comfortably in the center of the room, right a bove a shining grand piano. Further down the hall, the sound of a door closing, along with the accompaning clicks of footsteps, gets your attention._Go downstairs_Run back to your room!_12_10";
            
            story[7] = "Climbing into the cabinet as quick as you can, you hold your breath as the door to your room creaks open. You hear a faint gasp as a glass breaks. 'Lady Camilla? Lady Camilla I must ask you to come this instant!' An older voice cries out, as they run down the hall._Continue hiding_Leave the cabinet_13_14"; 
            
            story[8] = "Quickly opening the latch and swinging the window open, you clamber out onto the roof. It's colder than you expected, crossing your arms as you shiver under the moonlight. Getting a better look now, you can see a decorated fountain in the middle of the courtyard, surrounded by a garden of roses. further past that, a hedge maze with some large, white, object in the middle of it. Now that you think of it, how are you going to get down from here?_The tree by the corner of the courtyard_Find an unlocked window_15_16"; 
           
            story[9] = "The painting seems very old, it consists of a woman and man, along with three children. One girl sticks out to you though, her long brown hair, and her ear to ear grin, complimented by her joyful blue eyes. Seeing her so happy... it fills you with sadness. For some reason you cant take your eyes off her, even as you hear the door open, and someone yelling behind you._Ending achieved!: Staring contest_Press escape to quit_ _ "; //ENDING (final?)
           
            story[10] = "Running back to your room, you look around in panic. The cabinet could probably hide a child your size. Looking out the window to the softly sloped roof below you, you notice the latch seems pretty easy to open._Hide!_Climb out onto the roof_7_8";

            story[11] = "Looking around the countless bookshelves, you run your hand along them as you walk by. You can tell its a well kept room, almost jealous that the books were kept better than you. Now in the back corner of the room you stop. A large book titled 'The History of the von Trapps' catches you eyes. You don't know why, but you instinctively reach out and grab it. But in doing so, the entire bookshelf begins to shake violently, soon slowly swinging open to reveal a sectret staircase. You slowly decend the stairs, following the tight curl, hand along the icy stone, when the bookshelf suddenly moves back in place; plunging you in complete darkness. Scared, you try and turn around and rush ack up, but fate has other plans. You lose you footing on the turn and fall backwards._Ending achieved: You see what I see?_Press escape to quit_ _ "; //ENDING (continue later after pass in for fun)

            story[12] = "Quickly running down the stairs you slide under the piano, as you listen to the mysterious steps pass by. Slowly crawling out from your hiding place, you begin to get a better look. A large mirror is centered on the wall below the rails of the upper landing. Across from that, a grandiose entrance fitted out with elegant wooden doors, a marble platform leading down to the main floor with a step. To the left and right are to large wooden arches. Walking up to the door, you find it locked. You're about to turn around, when you feel a hand graps your shoulder._Ending achieved: Need a hand?_Press escape to quit_ _ "; //ENDING (continue later after pass in for fun)

            story[13] = "You figure it'd be safest to stay where you're probably safe. You soon hear two sets of footsteps come rushing this way; holding your breath, you stay as silent as possible. 'Im talling you Lady Camilla, when I opened the door to check on her, she was just gone!' You hear that same voice from before, along with one unkown, but familiar. 'WHAT? How could you lose her? She hasn't so much as sturred for years! It's not like she just got up and walked away!' You hear loud steps pacing around. 'She can't have gone far!I want you to search EVERYWHERE!' Your heart sinks, as you realise only one pair of steps left the room; you sit in silence as you wait for the inevitable, yet instead you hear faint sound of crying. 'After all these years I've spent searching, researching for a cure, just to have you disappear now. Where have you gone my dear Mary? Why must you disappear after all i've done to save you? Please come home.' After much hesitation, you slowly open the cuboard door._Ending Achieved: Mother?_Press escape to quit_ _ "; // ENDING (FINAL)

            story[14] = "Seizing this opportunity, you quickly climb out of your hiding place, there isn't much time before that lady comes back with this Camilla person. Running out of options you quickly unlock the window and leap onto the roof. Its a lot slipperier than you thought it was, and you can't get steady footing. You quickly fall off of the slick surface, and everything fades to black.._Ending Achieved: Where are you going?_Press escape to quit_ _ "; //ENDING (continue later after pass in for fun)

            story[15] = "You walk over to the tree, jumping for the branches. But as if by magic, or just really bad luck, the branch you grab breaks under your weight. As you fall you look towards that mysterious area in the hedges, cursing budget cuts as you do._Ending achieved: Cut content_Press escape to quit_ _ "; // ENDING (continue later after pass in for fun)

            story[16] = "Slowly you waddle along the frozen roof, trying to find another way in, each window you try however wont budge a bit! After reaching the very end, you give up and make your way back to the window you came from; when you finally make it back, its locked!! with no where left to go, it getting harder to move, you curl into a ball and try to preserve heat as you think about how you got into this mess._Ending achieved: Cool idea there_Press escape to quit_ _ "; //ENDING (continue later after pass in for fun)





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
