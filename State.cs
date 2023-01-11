using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8PuzzleProblem
{
    class State : IComparable
    {
        public int Depth { get; set; }
        public int ManhattanDistance { get; set; }
        public int NbrOfMisplacedTiles { get; set; }
        public int ReversalPenality { get; set; }
        //public int CostFromStartingState { get; set; }
        public int[] StateElements { get; set; }
        public List<State> ChildNodesList { get; set; }
        public State ParentState { get; set; }
        public int NbrOfMovesToGoal { get; set; }

        public State(int depth, int[] stateElements)
        {
            this.Depth = depth;
            this.StateElements = new int[9];

            for (int i = 0; i < 9; i++)
            {
                this.StateElements[i] = stateElements[i];
            }
            this.ManhattanDistance = this.manhattanDistance();
            this.NbrOfMisplacedTiles = this.nbrOfMisplacedTiles();
            this.ReversalPenality = this.reversalPenalty();
            //this.CostFromStartingState = this.costFromStartingState(ParentState);//////////////////////////
        }

        //Print Node Elements as a string 
        public override string ToString()
        {
            string toString = "";

            for (int i = 0; i < 9; i++)
            {
                toString = toString + StateElements[i].ToString();
            }
            return toString;
        }

        public int manhattanDistance()
        {
            int md = 0;

            if (StateElements[0] == 1)
                md += 0;
            else if (StateElements[0] == 2)
                md += 1;
            else if (StateElements[0] == 3)
                md += 2;
            else if (StateElements[0] == 4)
                md += 3;
            else if (StateElements[0] == 5)
                md += 4;
            else if (StateElements[0] == 6)
                md += 3;
            else if (StateElements[0] == 7)
                md += 2;
            else if (StateElements[0] == 8)
                md += 1;

            if (StateElements[1] == 1)
                md += 1;
            else if (StateElements[1] == 2)
                md += 0;
            else if (StateElements[1] == 3)
                md += 1;
            else if (StateElements[1] == 4)
                md += 2;
            else if (StateElements[1] == 5)
                md += 3;
            else if (StateElements[1] == 6)
                md += 2;
            else if (StateElements[1] == 7)
                md += 3;
            else if (StateElements[1] == 8)
                md += 2;

            if (StateElements[2] == 1)
                md += 2;
            else if (StateElements[2] == 2)
                md += 1;
            else if (StateElements[2] == 3)
                md += 0;
            else if (StateElements[2] == 4)
                md += 1;
            else if (StateElements[2] == 5)
                md += 2;
            else if (StateElements[2] == 6)
                md += 3;
            else if (StateElements[2] == 7)
                md += 4;
            else if (StateElements[2] == 8)
                md += 3;

            if (StateElements[3] == 1)
                md += 1;
            else if (StateElements[3] == 2)
                md += 2;
            else if (StateElements[3] == 3)
                md += 3;
            else if (StateElements[3] == 4)
                md += 2;
            else if (StateElements[3] == 5)
                md += 3;
            else if (StateElements[3] == 6)
                md += 2;
            else if (StateElements[3] == 7)
                md += 1;
            else if (StateElements[3] == 8)
                md += 0;

            if (StateElements[4] == 1)
                md += 2;
            else if (StateElements[4] == 2)
                md += 1;
            else if (StateElements[4] == 3)
                md += 2;
            else if (StateElements[4] == 4)
                md += 1;
            else if (StateElements[4] == 5)
                md += 2;
            else if (StateElements[4] == 6)
                md += 1;
            else if (StateElements[4] == 7)
                md += 2;
            else if (StateElements[4] == 8)
                md += 1;

            if (StateElements[5] == 1)
                md += 3;
            else if (StateElements[5] == 2)
                md += 2;
            else if (StateElements[5] == 3)
                md += 1;
            else if (StateElements[5] == 4)
                md += 0;
            else if (StateElements[5] == 5)
                md += 1;
            else if (StateElements[5] == 6)
                md += 2;
            else if (StateElements[5] == 7)
                md += 3;
            else if (StateElements[5] == 8)
                md += 2;

            if (StateElements[6] == 1)
                md += 2;
            else if (StateElements[6] == 2)
                md += 3;
            else if (StateElements[6] == 3)
                md += 4;
            else if (StateElements[6] == 4)
                md += 3;
            else if (StateElements[6] == 5)
                md += 2;
            else if (StateElements[6] == 6)
                md += 1;
            else if (StateElements[6] == 7)
                md += 0;
            else if (StateElements[6] == 8)
                md += 1;

            if (StateElements[7] == 1)
                md += 3;
            else if (StateElements[7] == 2)
                md += 2;
            else if (StateElements[7] == 3)
                md += 3;
            else if (StateElements[7] == 4)
                md += 2;
            else if (StateElements[7] == 5)
                md += 1;
            else if (StateElements[7] == 6)
                md += 0;
            else if (StateElements[7] == 7)
                md += 1;
            else if (StateElements[7] == 8)
                md += 2;

            if (StateElements[8] == 1)
                md += 4;
            else if (StateElements[8] == 2)
                md += 3;
            else if (StateElements[8] == 3)
                md += 2;
            else if (StateElements[8] == 4)
                md += 1;
            else if (StateElements[8] == 5)
                md += 0;
            else if (StateElements[8] == 6)
                md += 1;
            else if (StateElements[8] == 7)
                md += 2;
            else if (StateElements[8] == 8)
                md += 3;

            return md;
        }

        public int nbrOfMisplacedTiles()
        {
            int nbr = 0;

            if (StateElements[0] != 1)
                nbr += 1;
            if (StateElements[1] != 2)
                nbr += 1;
            if (StateElements[2] != 3)
                nbr += 1;
            if (StateElements[3] != 8)
                nbr += 1;
            if (StateElements[5] != 4)
                nbr += 1;
            if (StateElements[6] != 7)
                nbr += 1;
            if (StateElements[7] != 6)
                nbr += 1;
            if (StateElements[8] != 5)
                nbr += 1;
           
            return nbr;
        }

        public int reversalPenalty()
        {
            int rp = 0;

            if (this.StateElements[0] == 2 && this.StateElements[1] == 1)
                rp += 4;
            if (this.StateElements[0] == 8 && this.StateElements[3] == 1)
                rp += 4;
            if (this.StateElements[1] == 3 && this.StateElements[2] == 2)
                rp += 4;
            if (this.StateElements[2] == 4 && this.StateElements[5] == 3)
                rp += 4;
            if (this.StateElements[5] == 5 && this.StateElements[8] == 4)
                rp += 4;
            if (this.StateElements[3] == 7 && this.StateElements[6] == 8)
                rp += 4;
            if (this.StateElements[6] == 6 && this.StateElements[7] == 7)
                rp += 4;
            if (this.StateElements[7] == 5 && this.StateElements[8] == 6)
                rp += 4;

            return rp;
        }

        //public int costFromStartingState(State state)
        //{
        //    return state.CostFromStartingState + this.ManhattanDistance;
        //}

        public int nbrOfMovesToGoal(int[] startingState)
        {
            AStar8Puzzle aStar8Puzzle = new AStar8Puzzle();
            aStar8Puzzle.initialState(this.StateElements);

            for (int i = 0; i <= 5000; i++)
            {
                aStar8Puzzle.nextMove();

                if (aStar8Puzzle.Solved == true)
                {
                    return aStar8Puzzle.CurrentState.Depth;
                }
            }
            return aStar8Puzzle.CurrentState.Depth;
        }

        public void getChildNodes()
        {
            this.ChildNodesList = new List<State>();

            if (this.StateElements[0] == 0)
            {
                int[] nodeElement1 = new int[9];
                int[] nodeElement2 = new int[9];

                Array.Copy(this.StateElements, nodeElement1, 9);
                Array.Copy(this.StateElements, nodeElement2, 9);

                nodeElement1[0] = this.StateElements[1];
                nodeElement1[1] = this.StateElements[0];

                nodeElement2[0] = this.StateElements[3];
                nodeElement2[3] = this.StateElements[0];

                this.ChildNodesList.Add(new State(this.Depth + 1, nodeElement1));
                this.ChildNodesList.Add(new State(this.Depth + 1, nodeElement2));
            }

            else if (this.StateElements[1] == 0)
            {
                int[] nodeElement1 = new int[9];
                int[] nodeElement2 = new int[9];
                int[] nodeElement3 = new int[9];

                Array.Copy(this.StateElements, nodeElement1, 9);
                Array.Copy(this.StateElements, nodeElement2, 9);
                Array.Copy(this.StateElements, nodeElement3, 9);

                nodeElement1[1] = this.StateElements[0];
                nodeElement1[0] = this.StateElements[1];

                nodeElement2[1] = this.StateElements[2];
                nodeElement2[2] = this.StateElements[1];

                nodeElement3[1] = this.StateElements[4];
                nodeElement3[4] = this.StateElements[1];

                this.ChildNodesList.Add(new State(this.Depth + 1, nodeElement1));
                this.ChildNodesList.Add(new State(this.Depth + 1, nodeElement2));
                this.ChildNodesList.Add(new State(this.Depth + 1, nodeElement3));
            }

            else if (this.StateElements[2] == 0)
            {
                int[] nodeElement1 = new int[9];
                int[] nodeElement2 = new int[9];

                Array.Copy(this.StateElements, nodeElement1, 9);
                Array.Copy(this.StateElements, nodeElement2, 9);

                nodeElement1[2] = this.StateElements[1];
                nodeElement1[1] = this.StateElements[2];

                nodeElement2[2] = this.StateElements[5];
                nodeElement2[5] = this.StateElements[2];

                this.ChildNodesList.Add(new State(this.Depth + 1, nodeElement1));
                this.ChildNodesList.Add(new State(this.Depth + 1, nodeElement2));
            }

            else if (this.StateElements[3] == 0)
            {
                int[] nodeElement1 = new int[9];
                int[] nodeElement2 = new int[9];
                int[] nodeElement3 = new int[9];

                Array.Copy(this.StateElements, nodeElement1, 9);
                Array.Copy(this.StateElements, nodeElement2, 9);
                Array.Copy(this.StateElements, nodeElement3, 9);

                nodeElement1[3] = this.StateElements[0];
                nodeElement1[0] = this.StateElements[3];

                nodeElement2[3] = this.StateElements[4];
                nodeElement2[4] = this.StateElements[3];

                nodeElement3[3] = this.StateElements[6];
                nodeElement3[6] = this.StateElements[3];

                this.ChildNodesList.Add(new State(this.Depth + 1, nodeElement1));
                this.ChildNodesList.Add(new State(this.Depth + 1, nodeElement2));
                this.ChildNodesList.Add(new State(this.Depth + 1, nodeElement3));
            }

            else if (this.StateElements[4] == 0)
            {
                int[] nodeElement1 = new int[9];
                int[] nodeElement2 = new int[9];
                int[] nodeElement3 = new int[9];
                int[] nodeElement4 = new int[9];

                Array.Copy(this.StateElements, nodeElement1, 9);
                Array.Copy(this.StateElements, nodeElement2, 9);
                Array.Copy(this.StateElements, nodeElement3, 9);
                Array.Copy(this.StateElements, nodeElement4, 9);

                nodeElement1[4] = this.StateElements[1];
                nodeElement1[1] = this.StateElements[4];

                nodeElement2[4] = this.StateElements[5];
                nodeElement2[5] = this.StateElements[4];

                nodeElement3[4] = this.StateElements[7];
                nodeElement3[7] = this.StateElements[4];

                nodeElement4[4] = this.StateElements[3];
                nodeElement4[3] = this.StateElements[4];

                this.ChildNodesList.Add(new State(this.Depth + 1, nodeElement1));
                this.ChildNodesList.Add(new State(this.Depth + 1, nodeElement2));
                this.ChildNodesList.Add(new State(this.Depth + 1, nodeElement3));
                this.ChildNodesList.Add(new State(this.Depth + 1, nodeElement4));
            }

            else if (this.StateElements[5] == 0)
            {
                int[] nodeElement1 = new int[9];
                int[] nodeElement2 = new int[9];
                int[] nodeElement3 = new int[9];

                Array.Copy(this.StateElements, nodeElement1, 9);
                Array.Copy(this.StateElements, nodeElement2, 9);
                Array.Copy(this.StateElements, nodeElement3, 9);

                nodeElement1[5] = this.StateElements[2];
                nodeElement1[2] = this.StateElements[5];

                nodeElement2[5] = this.StateElements[4];
                nodeElement2[4] = this.StateElements[5];

                nodeElement3[5] = this.StateElements[8];
                nodeElement3[8] = this.StateElements[5];

                this.ChildNodesList.Add(new State(this.Depth + 1, nodeElement1));
                this.ChildNodesList.Add(new State(this.Depth + 1, nodeElement2));
                this.ChildNodesList.Add(new State(this.Depth + 1, nodeElement3));
            }

            else if (this.StateElements[6] == 0)
            {
                int[] nodeElement1 = new int[9];
                int[] nodeElement2 = new int[9];

                Array.Copy(this.StateElements, nodeElement1, 9);
                Array.Copy(this.StateElements, nodeElement2, 9);

                nodeElement1[6] = this.StateElements[3];
                nodeElement1[3] = this.StateElements[6];

                nodeElement2[6] = this.StateElements[7];
                nodeElement2[7] = this.StateElements[6];

                this.ChildNodesList.Add(new State(this.Depth + 1, nodeElement1));
                this.ChildNodesList.Add(new State(this.Depth + 1, nodeElement2));
            }

            else if (this.StateElements[7] == 0)
            {
                int[] nodeElement1 = new int[9];
                int[] nodeElement2 = new int[9];
                int[] nodeElement3 = new int[9];

                Array.Copy(this.StateElements, nodeElement1, 9);
                Array.Copy(this.StateElements, nodeElement2, 9);
                Array.Copy(this.StateElements, nodeElement3, 9);

                nodeElement1[7] = this.StateElements[4];
                nodeElement1[4] = this.StateElements[7];

                nodeElement2[7] = this.StateElements[6];
                nodeElement2[6] = this.StateElements[7];

                nodeElement3[7] = this.StateElements[8];
                nodeElement3[8] = this.StateElements[7];

                this.ChildNodesList.Add(new State(this.Depth + 1, nodeElement1));
                this.ChildNodesList.Add(new State(this.Depth + 1, nodeElement2));
                this.ChildNodesList.Add(new State(this.Depth + 1, nodeElement3));
            }

            else if (this.StateElements[8] == 0)
            {
                int[] nodeElement1 = new int[9];
                int[] nodeElement2 = new int[9];

                Array.Copy(this.StateElements, nodeElement1, 9);
                Array.Copy(this.StateElements, nodeElement2, 9);

                nodeElement1[8] = this.StateElements[5];
                nodeElement1[5] = this.StateElements[8];

                nodeElement2[8] = this.StateElements[7];
                nodeElement2[7] = this.StateElements[8];

                this.ChildNodesList.Add(new State(this.Depth + 1, nodeElement1));
                this.ChildNodesList.Add(new State(this.Depth + 1, nodeElement2));
            }
        }

        public bool isEqual(State node)
        {
            bool isEqual = true;

            for (int i = 0; i < 9; i++)
            {
                if (this.StateElements[i] != node.StateElements[i])
                {
                    isEqual = false;
                }
            }
            return isEqual;
        }

        public int CompareTo(object obj)
        {
            State node = (State)obj;

            if (this.Depth > node.Depth)
                return -1;
            if (this.Depth < node.Depth)
                return 1;
            return (this.ManhattanDistance + this.NbrOfMisplacedTiles + this.ReversalPenality).CompareTo(node.ManhattanDistance + node.NbrOfMisplacedTiles + node.ReversalPenality);
        }
    }
}
