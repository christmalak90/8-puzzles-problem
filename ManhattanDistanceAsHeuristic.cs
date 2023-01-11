using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8PuzzleProblem
{
    class ManhattanDistanceAsHeuristic : IComparer<State>
    {
        public int Compare(State x, State y)
        {
            if (x.Depth > y.Depth)
                return -1;
            if (x.Depth < y.Depth)
                return 1;
            return x.ManhattanDistance.CompareTo(y.ManhattanDistance);
        }
    }
}
