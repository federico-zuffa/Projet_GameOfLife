using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_GameOfLife
{
    internal class Rules
    {
        public bool BasicComputeNextState(bool isAlive, int aliveNeighbors)
        {
            if (isAlive)
            {
                return aliveNeighbors == 2 || aliveNeighbors == 3;
            }
            else
            {
                return aliveNeighbors == 3;
            }
        }
    }
}
