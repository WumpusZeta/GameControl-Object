using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus
{
    class GameControl
    {
        //Instance variables
        //None as of now, may need to add variables for other classes. 

        public GameControl()
        {
            /*
             * Note to self - this may change depending on how the other 
             * people on the team choose to make their objects. 
             */
        }

        // Constructers
        public int HighScore(int turns, int coins, int arrows, Boolean wumpus)
        {
            int highScore = 0;
            if(wumpus == true)
            {
                highScore = 100 - turns + coins + (5 * arrows) + 50;
            }
            else
            {
                highScore = 100 - turns + coins + (5 * arrows);
            }
            /*
             * Get stats from Player object.
             * Keep track of the high score. 
             * pass is to the HighScore object.
             */
            return highScore;
        } 

        public bool GameState()
        {
            /*
             * Keeps track of if a game is running. 
             * Returns true if game is running, otherwise false. 
             */
            return true;
        }

        public int MovePlayer(int room)
        {
            /*
             * Get the room that the player
             * wants to get to from the 
             * graphical interface object,
             * call the GameLocations object 
             * to move the player. 
             * Returns the room the player wants
             * to go to. 
             */
            return 0;
        }

        public void input()
        {
            /*
             * Gets the input from the user
             * and calls the other objects. 
             * Note to self - as other people 
             * make their objects, this may 
             * be expanded 
             */
        }
        
        /*
         * May add another method for 
         * displaying an interface. 
         * Depends on how other 
         * classes are made and if
         * I can figure out how to 
         * use the drawingPanel. 
         */
    }
}
