using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_star_8tasbulmacasi
{
    public class PuzzleState
    {
        public int[,] Board { get; }
        public int EmptyTileRow { get; }
        public int EmptyTileCol { get; }
        public int GScore { get; set; }
        public int HScore { get; set; }
        public int FScore => GScore + HScore;
        public PuzzleState Parent { get; set; }
        public PuzzleState GoalState { get; }

        public PuzzleState(int[,] board, int emptyTileRow, int emptyTileCol, PuzzleState goalState)
        {
            Board = board;
            EmptyTileRow = emptyTileRow;
            EmptyTileCol = emptyTileCol;
            GoalState = goalState;
        }

        public bool IsGoal()
        {
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++) { }
                    }
        }
    }




}