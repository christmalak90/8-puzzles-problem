using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8PuzzleProblem
{
    public partial class Form1 : Form
    {
        AStar8Puzzle aStar8Puzzle;

        public Form1()
        {
            InitializeComponent();
        }

        private void tilesLocation(int[] arrayLocation)
        {
            if (arrayLocation[0] == 0)
                Tile0.Location = new System.Drawing.Point(-1, -1);
            if (arrayLocation[0] == 1)
                Tile1.Location = new System.Drawing.Point(-1, -1);
            if (arrayLocation[0] == 2)
                Tile2.Location = new System.Drawing.Point(-1, -1);
            if (arrayLocation[0] == 3)
                Tile3.Location = new System.Drawing.Point(-1, -1);
            if (arrayLocation[0] == 4)
                Tile4.Location = new System.Drawing.Point(-1, -1);
            if (arrayLocation[0] == 5)
                Tile5.Location = new System.Drawing.Point(-1, -1);
            if (arrayLocation[0] == 6)
                Tile6.Location = new System.Drawing.Point(-1, -1);
            if (arrayLocation[0] == 7)
                Tile7.Location = new System.Drawing.Point(-1, -1);
            if (arrayLocation[0] == 8)
                Tile8.Location = new System.Drawing.Point(-1, -1);

            if (arrayLocation[1] == 0)
                Tile0.Location = new System.Drawing.Point(81, -1);
            if (arrayLocation[1] == 1)
                Tile1.Location = new System.Drawing.Point(81, -1);
            if (arrayLocation[1] == 2)
                Tile2.Location = new System.Drawing.Point(81, -1);
            if (arrayLocation[1] == 3)
                Tile3.Location = new System.Drawing.Point(81, -1);
            if (arrayLocation[1] == 4)
                Tile4.Location = new System.Drawing.Point(81, -1);
            if (arrayLocation[1] == 5)
                Tile5.Location = new System.Drawing.Point(81, -1);
            if (arrayLocation[1] == 6)
                Tile6.Location = new System.Drawing.Point(81, -1);
            if (arrayLocation[1] == 7)
                Tile7.Location = new System.Drawing.Point(81, -1);
            if (arrayLocation[1] == 8)
                Tile8.Location = new System.Drawing.Point(81, -1);

            if (arrayLocation[2] == 0)
                Tile0.Location = new System.Drawing.Point(163, -1);
            if (arrayLocation[2] == 1)
                Tile1.Location = new System.Drawing.Point(163, -1);
            if (arrayLocation[2] == 2)
                Tile2.Location = new System.Drawing.Point(163, -1);
            if (arrayLocation[2] == 3)
                Tile3.Location = new System.Drawing.Point(163, -1);
            if (arrayLocation[2] == 4)
                Tile4.Location = new System.Drawing.Point(163, -1);
            if (arrayLocation[2] == 5)
                Tile5.Location = new System.Drawing.Point(163, -1);
            if (arrayLocation[2] == 6)
                Tile6.Location = new System.Drawing.Point(163, -1);
            if (arrayLocation[2] == 7)
                Tile7.Location = new System.Drawing.Point(163, -1);
            if (arrayLocation[2] == 8)
                Tile8.Location = new System.Drawing.Point(163, -1);

            if (arrayLocation[3] == 0)
                Tile0.Location = new System.Drawing.Point(-1, 81);
            if (arrayLocation[3] == 1)
                Tile1.Location = new System.Drawing.Point(-1, 81);
            if (arrayLocation[3] == 2)
                Tile2.Location = new System.Drawing.Point(-1, 81);
            if (arrayLocation[3] == 3)
                Tile3.Location = new System.Drawing.Point(-1, 81);
            if (arrayLocation[3] == 4)
                Tile4.Location = new System.Drawing.Point(-1, 81);
            if (arrayLocation[3] == 5)
                Tile5.Location = new System.Drawing.Point(-1, 81);
            if (arrayLocation[3] == 6)
                Tile6.Location = new System.Drawing.Point(-1, 81);
            if (arrayLocation[3] == 7)
                Tile7.Location = new System.Drawing.Point(-1, 81);
            if (arrayLocation[3] == 8)
                Tile8.Location = new System.Drawing.Point(-1, 81);

            if (arrayLocation[4] == 0)
                Tile0.Location = new System.Drawing.Point(81, 81);
            if (arrayLocation[4] == 1)
                Tile1.Location = new System.Drawing.Point(81, 81);
            if (arrayLocation[4] == 2)
                Tile2.Location = new System.Drawing.Point(81, 81);
            if (arrayLocation[4] == 3)
                Tile3.Location = new System.Drawing.Point(81, 81);
            if (arrayLocation[4] == 4)
                Tile4.Location = new System.Drawing.Point(81, 81);
            if (arrayLocation[4] == 5)
                Tile5.Location = new System.Drawing.Point(81, 81);
            if (arrayLocation[4] == 6)
                Tile6.Location = new System.Drawing.Point(81, 81);
            if (arrayLocation[4] == 7)
                Tile7.Location = new System.Drawing.Point(81, 81);
            if (arrayLocation[4] == 8)
                Tile8.Location = new System.Drawing.Point(81, 81);

            if (arrayLocation[5] == 0)
                Tile0.Location = new System.Drawing.Point(163, 81);
            if (arrayLocation[5] == 1)
                Tile1.Location = new System.Drawing.Point(163, 81);
            if (arrayLocation[5] == 2)
                Tile2.Location = new System.Drawing.Point(163, 81);
            if (arrayLocation[5] == 3)
                Tile3.Location = new System.Drawing.Point(163, 81);
            if (arrayLocation[5] == 4)
                Tile4.Location = new System.Drawing.Point(163, 81);
            if (arrayLocation[5] == 5)
                Tile5.Location = new System.Drawing.Point(163, 81);
            if (arrayLocation[5] == 6)
                Tile6.Location = new System.Drawing.Point(163, 81);
            if (arrayLocation[5] == 7)
                Tile7.Location = new System.Drawing.Point(163, 81);
            if (arrayLocation[5] == 8)
                Tile8.Location = new System.Drawing.Point(163, 81);

            if (arrayLocation[6] == 0)
                Tile0.Location = new System.Drawing.Point(-1, 163);
            if (arrayLocation[6] == 1)
                Tile1.Location = new System.Drawing.Point(-1, 163);
            if (arrayLocation[6] == 2)
                Tile2.Location = new System.Drawing.Point(-1, 163);
            if (arrayLocation[6] == 3)
                Tile3.Location = new System.Drawing.Point(-1, 163);
            if (arrayLocation[6] == 4)
                Tile4.Location = new System.Drawing.Point(-1, 163);
            if (arrayLocation[6] == 5)
                Tile5.Location = new System.Drawing.Point(-1, 163);
            if (arrayLocation[6] == 6)
                Tile6.Location = new System.Drawing.Point(-1, 163);
            if (arrayLocation[6] == 7)
                Tile7.Location = new System.Drawing.Point(-1, 163);
            if (arrayLocation[6] == 8)
                Tile8.Location = new System.Drawing.Point(-1, 163);

            if (arrayLocation[7] == 0)
                Tile0.Location = new System.Drawing.Point(81, 163);
            if (arrayLocation[7] == 1)
                Tile1.Location = new System.Drawing.Point(81, 163);
            if (arrayLocation[7] == 2)
                Tile2.Location = new System.Drawing.Point(81, 163);
            if (arrayLocation[7] == 3)
                Tile3.Location = new System.Drawing.Point(81, 163);
            if (arrayLocation[7] == 4)
                Tile4.Location = new System.Drawing.Point(81, 163);
            if (arrayLocation[7] == 5)
                Tile5.Location = new System.Drawing.Point(81, 163);
            if (arrayLocation[7] == 6)
                Tile6.Location = new System.Drawing.Point(81, 163);
            if (arrayLocation[7] == 7)
                Tile7.Location = new System.Drawing.Point(81, 163);
            if (arrayLocation[7] == 8)
                Tile8.Location = new System.Drawing.Point(81, 163);

            if (arrayLocation[8] == 0)
                Tile0.Location = new System.Drawing.Point(163, 163);
            if (arrayLocation[8] == 1)
                Tile1.Location = new System.Drawing.Point(163, 163);
            if (arrayLocation[8] == 2)
                Tile2.Location = new System.Drawing.Point(163, 163);
            if (arrayLocation[8] == 3)
                Tile3.Location = new System.Drawing.Point(163, 163);
            if (arrayLocation[8] == 4)
                Tile4.Location = new System.Drawing.Point(163, 163);
            if (arrayLocation[8] == 5)
                Tile5.Location = new System.Drawing.Point(163, 163);
            if (arrayLocation[8] == 6)
                Tile6.Location = new System.Drawing.Point(163, 163);
            if (arrayLocation[8] == 7)
                Tile7.Location = new System.Drawing.Point(163, 163);
            if (arrayLocation[8] == 8)
                Tile8.Location = new System.Drawing.Point(163, 163);
        }

        //Set the position of the textbox used to set the initial state of the puzzle
        //Position them above each tile location
        private void setInitialStateTextboxPosition()
        {
            TX_Set_0.Location = new System.Drawing.Point(-4, 1);
            TX_Set_1.Location = new System.Drawing.Point(78, 1);
            TX_Set_2.Location = new System.Drawing.Point(160, 1);
            TX_Set_3.Location = new System.Drawing.Point(-4, 83);
            TX_Set_4.Location = new System.Drawing.Point(78, 83);
            TX_Set_5.Location = new System.Drawing.Point(160, 83);
            TX_Set_6.Location = new System.Drawing.Point(-4, 165);
            TX_Set_7.Location = new System.Drawing.Point(78, 165);
            TX_Set_8.Location = new System.Drawing.Point(160, 165);

            TX_Set_0.Text = "";
            TX_Set_1.Text = "";
            TX_Set_2.Text = "";
            TX_Set_3.Text = "";
            TX_Set_4.Text = "";
            TX_Set_5.Text = "";
            TX_Set_6.Text = "";
            TX_Set_7.Text = "";
            TX_Set_8.Text = "";

            TX_Set_0.Visible = true;
            TX_Set_1.Visible = true;
            TX_Set_2.Visible = true;
            TX_Set_3.Visible = true;
            TX_Set_4.Visible = true;
            TX_Set_5.Visible = true;
            TX_Set_6.Visible = true;
            TX_Set_7.Visible = true;
            TX_Set_8.Visible = true;

            BT_NextState.Text = "Start";
            BT_NextState.Enabled = false;
            TX_Move.Text = "";
            TX_Moves.Text = "";

            BT_NextState.Enabled = false;
            Tile1.BackColor = Color.White;
            Tile2.BackColor = Color.White;
            Tile3.BackColor = Color.White;
            Tile4.BackColor = Color.White;
            Tile5.BackColor = Color.White;
            Tile6.BackColor = Color.White;
            Tile7.BackColor = Color.White;
            Tile8.BackColor = Color.White;
        }

        private void initialStateChanged(object obj)
        {
            TextBox textB = (TextBox)obj;
            bool valideNbr = false;

            if (textB.Name == "TX_Set_0")
            {
                for (int i = 0; i <= 8; i++)
                {
                    if (TX_Set_0.Text == i.ToString())
                    {
                        valideNbr = true;
                    }
                }

                if (valideNbr == false || TX_Set_0.Text == TX_Set_1.Text || TX_Set_0.Text == TX_Set_2.Text || TX_Set_0.Text == TX_Set_3.Text || TX_Set_0.Text == TX_Set_4.Text || TX_Set_0.Text == TX_Set_5.Text || TX_Set_0.Text == TX_Set_6.Text || TX_Set_0.Text == TX_Set_7.Text || TX_Set_0.Text == TX_Set_8.Text)
                    TX_Set_0.Text = "";
            }

            if (textB.Name == "TX_Set_1")
            {
                for (int i = 0; i <= 8; i++)
                {
                    if (TX_Set_1.Text == i.ToString())
                    {
                        valideNbr = true;
                    }
                }
                if (valideNbr == false || TX_Set_1.Text == TX_Set_0.Text || TX_Set_1.Text == TX_Set_2.Text || TX_Set_1.Text == TX_Set_3.Text || TX_Set_1.Text == TX_Set_4.Text || TX_Set_1.Text == TX_Set_5.Text || TX_Set_1.Text == TX_Set_6.Text || TX_Set_1.Text == TX_Set_7.Text || TX_Set_1.Text == TX_Set_8.Text)
                    TX_Set_1.Text = "";
            }

            if (textB.Name == "TX_Set_2")
            {
                for (int i = 0; i <= 8; i++)
                {
                    if (TX_Set_2.Text == i.ToString())
                    {
                        valideNbr = true;
                    }
                }
                if (valideNbr == false || TX_Set_2.Text == TX_Set_0.Text || TX_Set_2.Text == TX_Set_1.Text || TX_Set_2.Text == TX_Set_3.Text || TX_Set_2.Text == TX_Set_4.Text || TX_Set_2.Text == TX_Set_5.Text || TX_Set_2.Text == TX_Set_6.Text || TX_Set_2.Text == TX_Set_7.Text || TX_Set_2.Text == TX_Set_8.Text)
                    TX_Set_2.Text = "";
            }

            if (textB.Name == "TX_Set_3")
            {
                for (int i = 0; i <= 8; i++)
                {
                    if (TX_Set_3.Text == i.ToString())
                    {
                        valideNbr = true;
                    }
                }
                if (valideNbr == false || TX_Set_3.Text == TX_Set_0.Text || TX_Set_3.Text == TX_Set_1.Text || TX_Set_3.Text == TX_Set_2.Text || TX_Set_3.Text == TX_Set_4.Text || TX_Set_3.Text == TX_Set_5.Text || TX_Set_3.Text == TX_Set_6.Text || TX_Set_3.Text == TX_Set_7.Text || TX_Set_3.Text == TX_Set_8.Text)
                    TX_Set_3.Text = "";
            }

            if (textB.Name == "TX_Set_4")
            {
                for (int i = 0; i <= 8; i++)
                {
                    if (TX_Set_4.Text == i.ToString())
                    {
                        valideNbr = true;
                    }
                }
                if (valideNbr == false || TX_Set_4.Text == TX_Set_0.Text || TX_Set_4.Text == TX_Set_1.Text || TX_Set_4.Text == TX_Set_2.Text || TX_Set_4.Text == TX_Set_3.Text || TX_Set_4.Text == TX_Set_5.Text || TX_Set_4.Text == TX_Set_6.Text || TX_Set_4.Text == TX_Set_7.Text || TX_Set_4.Text == TX_Set_8.Text)
                    TX_Set_4.Text = "";
            }

            if (textB.Name == "TX_Set_5")
            {
                for (int i = 0; i <= 8; i++)
                {
                    if (TX_Set_5.Text == i.ToString())
                    {
                        valideNbr = true;
                    }
                }
                if (valideNbr == false || TX_Set_5.Text == TX_Set_0.Text || TX_Set_5.Text == TX_Set_1.Text || TX_Set_5.Text == TX_Set_2.Text || TX_Set_5.Text == TX_Set_3.Text || TX_Set_5.Text == TX_Set_4.Text || TX_Set_5.Text == TX_Set_6.Text || TX_Set_5.Text == TX_Set_7.Text || TX_Set_5.Text == TX_Set_8.Text)
                    TX_Set_5.Text = "";
            }

            if (textB.Name == "TX_Set_6")
            {
                for (int i = 0; i <= 8; i++)
                {
                    if (TX_Set_6.Text == i.ToString())
                    {
                        valideNbr = true;
                    }
                }
                if (valideNbr == false || TX_Set_6.Text == TX_Set_0.Text || TX_Set_6.Text == TX_Set_1.Text || TX_Set_6.Text == TX_Set_2.Text || TX_Set_6.Text == TX_Set_3.Text || TX_Set_6.Text == TX_Set_4.Text || TX_Set_6.Text == TX_Set_5.Text || TX_Set_6.Text == TX_Set_7.Text || TX_Set_6.Text == TX_Set_8.Text)
                    TX_Set_6.Text = "";
            }

            if (textB.Name == "TX_Set_7")
            {
                for (int i = 0; i <= 8; i++)
                {
                    if (TX_Set_7.Text == i.ToString())
                    {
                        valideNbr = true;
                    }
                }
                if (valideNbr == false || TX_Set_7.Text == TX_Set_0.Text || TX_Set_7.Text == TX_Set_1.Text || TX_Set_7.Text == TX_Set_2.Text || TX_Set_7.Text == TX_Set_3.Text || TX_Set_7.Text == TX_Set_4.Text || TX_Set_7.Text == TX_Set_5.Text || TX_Set_7.Text == TX_Set_6.Text || TX_Set_7.Text == TX_Set_8.Text)
                    TX_Set_7.Text = "";
            }

            if (textB.Name == "TX_Set_8")
            {
                for (int i = 0; i <= 8; i++)
                {
                    if (TX_Set_8.Text == i.ToString())
                    {
                        valideNbr = true;
                    }
                }
                if (valideNbr == false || TX_Set_8.Text == TX_Set_0.Text || TX_Set_8.Text == TX_Set_1.Text || TX_Set_8.Text == TX_Set_2.Text || TX_Set_8.Text == TX_Set_3.Text || TX_Set_8.Text == TX_Set_4.Text || TX_Set_8.Text == TX_Set_5.Text || TX_Set_8.Text == TX_Set_6.Text || TX_Set_8.Text == TX_Set_7.Text)
                    TX_Set_8.Text = "";
            }

            if (TX_Set_0.Text != "" || TX_Set_1.Text != "" || TX_Set_2.Text != "" || TX_Set_3.Text != "" || TX_Set_4.Text != "" || TX_Set_5.Text != "" || TX_Set_6.Text != "" || TX_Set_7.Text != "" || TX_Set_8.Text != "")
                BT_NextState.Enabled = true;
            if (TX_Set_0.Text == "" || TX_Set_1.Text == "" || TX_Set_2.Text == "" || TX_Set_3.Text == "" || TX_Set_4.Text == "" || TX_Set_5.Text == "" || TX_Set_6.Text == "" || TX_Set_7.Text == "" || TX_Set_8.Text == "")
                BT_NextState.Enabled = false;
        }

        private void puzzleSolved()
        {
            BT_NextState.Enabled = false;
            Tile1.BackColor = Color.GreenYellow;
            Tile2.BackColor = Color.GreenYellow;
            Tile3.BackColor = Color.GreenYellow;
            Tile4.BackColor = Color.GreenYellow;
            Tile5.BackColor = Color.GreenYellow;
            Tile6.BackColor = Color.GreenYellow;
            Tile7.BackColor = Color.GreenYellow;
            Tile8.BackColor = Color.GreenYellow;
        }

        private void start(int a, int b, int c, int d, int e, int f, int g, int h, int i)
        {
            aStar8Puzzle = new AStar8Puzzle();
            aStar8Puzzle.initialState(new int[9] {a, b, c, d, e, f, g, h, i });
            tilesLocation(aStar8Puzzle.StartingState.StateElements);
            aStar8Puzzle.StartingState.NbrOfMovesToGoal = aStar8Puzzle.StartingState.nbrOfMovesToGoal(aStar8Puzzle.StartingState.StateElements);
            TX_Moves.Text = aStar8Puzzle.StartingState.NbrOfMovesToGoal.ToString();
            TX_Set_0.Visible = false;
            TX_Set_1.Visible = false;
            TX_Set_2.Visible = false;
            TX_Set_3.Visible = false;
            TX_Set_4.Visible = false;
            TX_Set_5.Visible = false;
            TX_Set_6.Visible = false;
            TX_Set_7.Visible = false;
            TX_Set_8.Visible = false;
            BT_NextState.Text = "Next";
        }

        private void nextMove()
        {
            aStar8Puzzle.nextMove();
            tilesLocation(aStar8Puzzle.CurrentState.StateElements);
            TX_Move.Text = aStar8Puzzle.CurrentState.Depth.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            setInitialStateTextboxPosition(); 
        }

        private void BT_NextState_Click(object sender, EventArgs e)
        {
            if (BT_NextState.Text == "Start")
            {
                start(int.Parse(TX_Set_0.Text), int.Parse(TX_Set_1.Text), int.Parse(TX_Set_2.Text), int.Parse(TX_Set_3.Text), int.Parse(TX_Set_4.Text), int.Parse(TX_Set_5.Text), int.Parse(TX_Set_6.Text), int.Parse(TX_Set_7.Text), int.Parse(TX_Set_8.Text));
            }

            if (BT_NextState.Text == "Next")
            {
                nextMove();
            }

            if (aStar8Puzzle.Solved == true)
            {
                puzzleSolved();
            }
        }

        private void TX_Set_0_TextChanged(object sender, EventArgs e)
        {
            initialStateChanged(sender);
        }

        private void TX_Set_1_TextChanged(object sender, EventArgs e)
        {
            initialStateChanged(sender);
        }

        private void TX_Set_2_TextChanged(object sender, EventArgs e)
        {
            initialStateChanged(sender);
        }

        private void TX_Set_3_TextChanged(object sender, EventArgs e)
        {
            initialStateChanged(sender);
        }

        private void TX_Set_4_TextChanged(object sender, EventArgs e)
        {
            initialStateChanged(sender);
        }

        private void TX_Set_5_TextChanged(object sender, EventArgs e)
        {
            initialStateChanged(sender);
        }

        private void TX_Set_6_TextChanged(object sender, EventArgs e)
        {
            initialStateChanged(sender);
        }

        private void TX_Set_7_TextChanged(object sender, EventArgs e)
        {
            initialStateChanged(sender);
        }

        private void TX_Set_8_TextChanged(object sender, EventArgs e)
        {
            initialStateChanged(sender);
        }

        private void BT_Reset_Click(object sender, EventArgs e)
        {
            setInitialStateTextboxPosition();
        }
    }
}


