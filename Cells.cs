using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game_of_Life
{
    public class Cells
    {

        private bool isAlive;
        private int neighbors;
        // rgb


        public bool LivingStatus
        {
            get { return isAlive; }
            set { isAlive = value; }
        }
            
        public int NeighborCount
        {
            get { return neighbors; }
            set { neighbors = value; }
        }

        // get/set for rgb

        public void IncreaseNeighbors()
        {
            neighbors++;
        }


    }
}
