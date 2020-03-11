using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game_of_Life
{
    public class Cells
    {

        private bool isAlive;

        public bool LivingStatus
        {
            get { return isAlive; }
            set { isAlive = value; }
        }

    }
}
