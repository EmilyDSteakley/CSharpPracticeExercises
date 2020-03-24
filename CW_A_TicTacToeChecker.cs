using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class CW_A_TicTacToeChecker
    {
        // ---------------------------------------- Problem ----------------------------------------

        // Tic-Tac-Toe Checker

        // If we were to set up a Tic-Tac-Toe game, we would want to know whether the board's current state is solved, wouldn't we? 
        // Our goal is to create a function that will check that for us!

        // Assume that the board comes in the form of a 3x3 array, where the value is 0 if a spot is empty, 1 if it is an "X", or 2 if it is an "O", like so:
        // [[0, 0, 1],
        //  [0, 1, 2],
        //  [2, 1, 0]]

        // We want our function to return:
        //   - -1 if the board is not yet finished(there are empty spots),
        //   - 1 if "X" won,
        //   - 2 if "O" won,
        //   - 0 if it's a cat's game(i.e.a draw).
        
        // You may assume that the board passed in is valid in the context of a game of Tic-Tac-Toe.



        // ---------------------------------------- My Solution ----------------------------------------
        public int IsSolved(int[,] board)
        {
            if (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2] && board[1, 1] != 0)
                return board[0, 0];
            else if (board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0] && board[1, 1] != 0)
                return board[0, 2];
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    if (board[i, 0] == board[i, 1] && board[i, 0] == board[i, 2] && board[i, 0] != 0)
                        return board[i, 0];
                    if (board[0, i] == board[1, i] && board[0, i] == board[2, i] && board[0, i] != 0)
                        return board[0, i];
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == 0)
                        return -1;
                }
            }

            return 0;
        }
        // Solved March 23, 2020



        // ---------------------------------------- Best Practices Solution on Codewars ----------------------------------------
        public int IsSolvedBest(int[,] board)
        {
            int d1 = 1, d2 = 1;
            bool empty = false;
            for (int i = 0; i < 3; i++)
            {
                d1 *= board[i, i];
                d2 *= board[2 - i, i];
                int row = 1, col = 1;
                for (int j = 0; j < 3; j++)
                {
                    row *= board[i, j];
                    col *= board[j, i];
                }
                if (row == 1 || col == 1) return 1;
                if (row == 8 || col == 8) return 2;
                if (row == 0 || col == 0) empty = true;
            }
            if (d1 == 1 || d2 == 1) return 1;
            if (d1 == 8 || d2 == 8) return 2;
            if (empty) return -1;
            return 0;
        }

    } // CW_A_TicTacToeChecker class

} // CSharpPracticeExercises namespace
