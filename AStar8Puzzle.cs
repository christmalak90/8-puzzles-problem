using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8PuzzleProblem
{
    class AStar8Puzzle
    {
        public List<State> OpenList { get; set; }
        public List<State> ClosedList { get; set; }
        public State StartingState { get; set; }
        public State TargetState { get; set; }
        public bool Solved { get; set; }
        public State CurrentState { get; set; }
   
        public AStar8Puzzle()
        {
            OpenList = new List<State>();
            ClosedList = new List<State>();
            TargetState = new State(0, new int[9] { 1, 2, 3, 8, 0, 4, 7, 6, 5 });
        }
        public void initialState(int[] startingState)
        {
            StartingState = new State(0, startingState);
            OpenList.Add(StartingState);
            Solved = false;
        }
        public void nextMove()
        {   
            CurrentState = OpenList[0];

            if (CurrentState.isEqual(TargetState))
                Solved = true;

            if (Solved == false && OpenList.Count != 0)
            {
                ClosedList.Add(CurrentState);
                OpenList.RemoveAt(0);

                CurrentState.getChildNodes();

                foreach (State node in CurrentState.ChildNodesList)
                {
                    node.ParentState = CurrentState;
                    //node.CostFromStartingState = node.costFromStartingState(node.ParentState);///////////////
                    bool isInClosedList = false;
                    bool isInOpenList = false;

                    foreach (State nodeCL in ClosedList)
                    {
                        if (node.isEqual(nodeCL))
                            isInClosedList = true;
                    }

                    if (isInClosedList == false)
                    {
                        foreach (State nodeOL in OpenList)
                        {
                            if (node.isEqual(nodeOL))
                            {
                                isInOpenList = true;
                                nodeOL.ParentState = CurrentState;
                                nodeOL.Depth = CurrentState.Depth + 1;
                                //nodeOL.CostFromStartingState = nodeOL.costFromStartingState(nodeOL.ParentState);///////////////////
                            }
                        }

                        if (isInOpenList == false)
                        {
                            OpenList.Add(node);
                        }
                    }
                }
                OpenList.Sort(new ManhattanDistanceAndReversalPenaltyAsHeuristic());
                //OpenList.Sort(new ManhattanDistanceAsHeuristic());
                //OpenList.Sort(new NbrOfMisplacedTilesAsHeuristic());
            }
        }
    }
}
