namespace Game_of_Life
{
    public class Game
    {
        // Pass In - takes two arrays (one is the old gameboard, which will be used to update everything according to the game rules, and the other is changes made by the user
            // Potentially returns an array as well - this would be the updated gameboard

            // What to consider: how to save/create this new gameboard. can save the old array into a global "new" one which will make it so other methods don't need to take in the array value. 
                // copy it over, and that could make it easier to deal with changing the status of living/dead cells.


        // checkNeighbors - takes in an array (the old array passed in)
            // for the length of the array, minus the top and bottom rows
                // if value is out of bounds (on the edges of the "board")
                    // skip to next number

                // reset neighbors to 0
                // an individual if statement for each of the squares around i: i-23, i-22, i-21, i-1, i+1, i+21, i+22, i+23
                // if (array[values listed above].isAlive)
                    // array[i].increaseNeighbors()

             // call updateStatus

        // update Status - takes in old array
            // for the length of the array, minus the top and bottom rows
                // if value is out of bounds (on the edges of the board)
                    // skip to next number

                // if(array[i].isAlive)
                    // if(array[i].neighbors is greater than 3 or less than 2)
                        //array[i].isAlive = false;
                // else // aka the cell is dead
                    // if(array[i].neighbors == 3)
                        // array[i].isAlive = true;

            // save this gameboard. will depend upon how we decide to save it (global variable, or just pass it to a method)


        // merge Boards -- takes the new gameboard (after status has been updated) and the change board (changes users have added on)
            // for length of the change board,
                // if a cell is alive, make the equivalent cell in the new gameboard alive.
    }
}