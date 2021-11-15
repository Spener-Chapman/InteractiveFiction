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
        static int pageNumber = 0;
        static string[] story = new string[100];

        static void Main(string[] args)
        {




            story[0] = "You wake up in a dark room, groggy and confused. The first thing you notice is the dust of the bed which you're resting on, along with the scent of mildew lingering in the air. Your confusion morphs into fear, you realise you don't remember where you are, nor how you got here. Squinting around the room, you can faintly see the outline of a dresser, along with a faint glow under the crack of what you assume is the door. "; // the title page  
            story[1] = "Explore the room"; // go to story 3
            story[2] = "Open the door"; // go to story 6

            story[3] = "Thinking it probably isn't the best idea to boldly jump out into the unknown, you instead look around the room. to your left is that door, with the dresser directly across from you. To your right there appears to be some sort of cabinet, and upon closer inspection, a window covered by a long, simple curtain."; // chose story 1 
            story[4] = "Look out the window"; // go to story 9
            story[5] = "Open the door"; // go to story 6 

            story[6] = "Opening the door, you're greeted by a startling sight. Sn ornately decorated hall greets you on the other side, wall mounted candles illuminating the carpet with its swirling patterns. To your right, a large, wooden door blocks your path, to your left, a seemingly unending hall."; //  chose story 2, or 6
            story[7] = "Go right"; // 
            story[8] = "Go left"; // 

            story[9] = "";
            story[10] = "";
            story[11] = "";

            story[12] = "";
            story[13] = "";
            story[14] = "";

            story[15] = "";
            story[16] = "";
            story[17] = "";

            story[18] = "";

            
            Page();
            Console.ReadKey(true);
        }
        
        
       
        
        static void Page()
        {
            Console.WriteLine("Page " + (pageNumber + 1));
            Console.WriteLine("");
            Console.WriteLine("" + story[pageNumber]);
            Console.WriteLine("");
            Console.WriteLine("What will you do?");
            Console.WriteLine("A:" + story[(pageNumber + 1)]);
            Console.WriteLine("B:" + story[(pageNumber + 2)]);
        }
        
        static void PlayerInput()
        {
            ConsoleKeyInfo readKeyInput = Console.ReadKey(true);

            if (readKeyInput.Key == ConsoleKey.A)
            {

            }
        }
        
    }
}
