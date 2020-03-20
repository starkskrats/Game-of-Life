namespace Game_of_Life
{
    public static class Game
    {
        public static Cells[] currentGameBoard = new Cells[441]{new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells()};
        
        public static Cells[] newGameBoard = new Cells[441]{new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(), new Cells(),
            new Cells(), new Cells(), new Cells(), new Cells(), new Cells()};

        /// <summary>
        /// For the length of the game board, determine the amount of neighbors a cell has and its living status.
        /// </summary>
        public static void UpdateStatus()
        {
            for (int i = 0; i < newGameBoard.Length; i++)
            {
                newGameBoard[i].isAlive = false;
                newGameBoard[i].red = -1;
                newGameBoard[i].green = -1;
                newGameBoard[i].blue = -1;
            }
            
            // For the length of the gameboard, ignoring the top and bottom row.
            for (int i = 22; i < (currentGameBoard.Length - 23); i++)
            {
                // Check if on the edges of the gameboard.
                int placement = i % 21;
                if ((placement == 0) || (placement == 20))
                    continue;
                
                // Reset Neighbors
                int neighbors = 0;
                int red = 0;
                int green = 0;
                int blue = 0;
                
                if (currentGameBoard[i - 22].isAlive)
                {
                    red += currentGameBoard[i - 22].red;
                    green += currentGameBoard[i - 22].green;
                    blue += currentGameBoard[i - 22].blue;
                    neighbors++;
                }
                if (currentGameBoard[i - 21].isAlive)
                {
                    red += currentGameBoard[i - 21].red;
                    green += currentGameBoard[i - 21].green;
                    blue += currentGameBoard[i - 21].blue;
                    neighbors++;
                }
                if (currentGameBoard[i - 20].isAlive)
                {
                    red += currentGameBoard[i - 20].red;
                    green += currentGameBoard[i - 20].green;
                    blue += currentGameBoard[i - 20].blue;
                    neighbors++;
                }
                if (currentGameBoard[i - 1].isAlive)
                {
                    red += currentGameBoard[i - 1].red;
                    green += currentGameBoard[i - 1].green;
                    blue += currentGameBoard[i - 1].blue;
                    neighbors++;
                }
                if (currentGameBoard[i + 1].isAlive)
                {
                    red += currentGameBoard[i + 1].red;
                    green += currentGameBoard[i + 1].green;
                    blue += currentGameBoard[i + 1].blue;
                    neighbors++;
                }
                if (currentGameBoard[i + 20].isAlive)
                {
                    red += currentGameBoard[i + 20].red;
                    green += currentGameBoard[i + 20].green;
                    blue += currentGameBoard[i + 20].blue;
                    neighbors++;
                }
                if (currentGameBoard[i + 21].isAlive)
                {
                    red += currentGameBoard[i + 21].red;
                    green += currentGameBoard[i + 21].green;
                    blue += currentGameBoard[i + 21].blue;
                    neighbors++;
                }
                if (currentGameBoard[i + 22].isAlive)
                {
                    red += currentGameBoard[i + 22].red;
                    green += currentGameBoard[i + 22].green;
                    blue += currentGameBoard[i + 22].blue;
                    neighbors++;
                }

                if(currentGameBoard[i].isAlive)
                {
                    // if the cell has less than 2 neighbors or more than 3
                    if(neighbors > 3 || neighbors < 2)
                    {
                        newGameBoard[i].red = -1;
                        newGameBoard[i].green = -1;
                        newGameBoard[i].blue = -1;
                        newGameBoard[i].isAlive = false;
                    }
                    else if (neighbors == 3)
                    {
                        newGameBoard[i].red = red / 3;
                        newGameBoard[i].green = green / 3;
                        newGameBoard[i].blue = blue / 3;
                        newGameBoard[i].isAlive = true;
                    }
                    else if (neighbors == 2)
                    {
                        newGameBoard[i].red = red / 2;
                        newGameBoard[i].green = green / 2;
                        newGameBoard[i].blue = blue / 2;
                        newGameBoard[i].isAlive = true;
                    }
                }
                else
                {
                    if (neighbors == 3)
                    {
                        newGameBoard[i].red = red / 3;
                        newGameBoard[i].green = green / 3;
                        newGameBoard[i].blue = blue / 3;
                        newGameBoard[i].isAlive = true;
                    }
                }
            }

            for (int i = 0; i < currentGameBoard.Length; i++)
            {
                currentGameBoard[i].isAlive = newGameBoard[i].isAlive;
                currentGameBoard[i].red = newGameBoard[i].red;
                currentGameBoard[i].green = newGameBoard[i].green;
                currentGameBoard[i].blue = newGameBoard[i].blue;
            }
        }

        public static void UpdateCell(int index, int red, int green, int blue)
        {
            if (currentGameBoard[index].isAlive)
            {
                currentGameBoard[index].red = -1;
                currentGameBoard[index].green = -1;
                currentGameBoard[index].blue = -1;
                currentGameBoard[index].isAlive = false;
            }
            else
            {
                currentGameBoard[index].red = red;
                currentGameBoard[index].green = green;
                currentGameBoard[index].blue = blue;
                currentGameBoard[index].isAlive = true;
            }
        }
    }
}