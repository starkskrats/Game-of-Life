namespace Game_of_Life
{
    public class Game
    {

        private Cells[] gameBoard;

        /// <summary>
        /// Constructor to initialize gameboard size and set all cells on the gameboard to false.
        /// </summary>
        public Game()
        {
            gameBoard = new Cells[441];

            for(int i = 0; i < gameBoard.Length; i++)
            {
                gameBoard[i].LivingStatus = false;
            }
        }
        
        /// <summary>
        /// For the length of the game board, determine the amount of neighbors a cell has and its living status.
        /// </summary>
        public void UpdateStatus()
        {
            // For the length of the gameboard, ignoring the top and bottom row.
            for (int i = 22; i < (gameBoard.Length - 22); i++)
            {
                // Check if on the edges of the gameboard.
                int placement = i % 22;
                if ((placement == 0) || (placement == 21))
                    continue;
                
                // Reset Neighbors
                int neighbors = CountNeighbors(i);

                if(gameBoard[i].LivingStatus)
                {
                    // if the cell has less than 2 neighbors or more than 3
                    if(neighbors > 3 || neighbors < 2)
                    {
                        gameBoard[i].LivingStatus = false;
                    }                 
                }
                else
                {
                    if(neighbors == 3)
                    {
                        gameBoard[i].LivingStatus = true;
                    }
                }
            }

        }
        
        /// <summary>
        /// Check the neighbors of the indicated cell.
        /// </summary>
        /// <param name="i"></param>
        /// <returns>A count of the neighbors a cell has.</returns>
        public int CountNeighbors(int i)
        {
            int count = 0;

            // Check all the neighbors around the current cell and increase count if they are alive.
            if (gameBoard[i - 23].LivingStatus)
            {
                count++;
            }
            if (gameBoard[i - 22].LivingStatus)
            {
                count++;
            }
            if (gameBoard[i - 21].LivingStatus)
            {
                count++;
            }
            if (gameBoard[i - 1].LivingStatus)
            {
                count++;
            }
            if (gameBoard[i + 1].LivingStatus)
            {
                count++;
            }
            if (gameBoard[i + 21].LivingStatus)
            {
                count++;
            }
            if (gameBoard[i + 22].LivingStatus)
            {
                count++;
            }
            if (gameBoard[i + 23].LivingStatus)
            {
                count++;
            }

            return count;
        }
    }
}