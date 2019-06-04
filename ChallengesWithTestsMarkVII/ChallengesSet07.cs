using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet07
    {
        public int CountOfBusinessesWithNegativeNetProfit(List<Business> businesses)
        {
            if (businesses == null)
            {
                return 0;
            }
            int count =0;
            foreach (var biz in businesses)
            {
                if (biz.TotalRevenue < biz.TotalExpenses)
                {
                    count += 1;
                }
            }
            return count;
        }

        public string GetCommaSeparatedListOfProfitableBusinesses(List<Business> businesses)
        {
            string result = "";
            foreach (var biz in businesses)
            {
                if (biz.TotalRevenue > biz.TotalExpenses)
                {
                    result += biz.Name + ",";
                }

            }
            if (result.Length - 1 >= 0)
            {
                string removedcomma = result.Remove(result.Length - 1);
                return removedcomma;
            }
            else
            {
                return result;
            }

        }

        public string GetNameOfHighestParentCompany(Business business)
        {
            // If there is Company A, whose parent is Company B, whose parent is Company C, then given Company A return Company C
            throw new NotImplementedException();
        }

        public enum TicTacToeResult { X, O, Draw }
        public TicTacToeResult GetTicTacToeWinner(char[,] finalBoard)
        {
            if (finalBoard[0,0] == 'O' && finalBoard[1, 0] == 'O' && finalBoard[2, 0] == 'O')
            {
                return TicTacToeResult.O;
            }
            else if (finalBoard[0, 0] == 'O' && finalBoard[0, 1] == 'O' && finalBoard[0, 2] == 'O')
            {
                return TicTacToeResult.O;
            }
            else if (finalBoard[0, 1] == 'O' && finalBoard[1, 1] == 'O' && finalBoard[2, 1] == 'O')
            {
                return TicTacToeResult.O;
            }
            else if (finalBoard[0, 2] == 'O' && finalBoard[1, 2] == 'O' && finalBoard[2, 2] == 'O')
            {
                return TicTacToeResult.O;
            }
            else if (finalBoard[0, 0] == 'O' && finalBoard[1, 1] == 'O' && finalBoard[2, 2] == 'O')
            {
                return TicTacToeResult.O;
            }
            else if (finalBoard[1, 0] == 'O' && finalBoard[1, 1] == 'O' && finalBoard[1, 2] == 'O')
            {
                return TicTacToeResult.O;
            }
            else if (finalBoard[2, 0] == 'O' && finalBoard[2, 1] == 'O' && finalBoard[2, 2] == 'O')
            {
                return TicTacToeResult.O;
            }
            else if (finalBoard[2, 0] == 'O' && finalBoard[1, 1] == 'O' && finalBoard[0, 2] == 'O')
            {
                return TicTacToeResult.O;
            }
            else if(finalBoard[0, 0] == 'X' && finalBoard[1, 0] == 'X' && finalBoard[2, 0] == 'X')
            {
                return TicTacToeResult.X;
            }
            else if (finalBoard[0, 0] == 'X' && finalBoard[0, 1] == 'X' && finalBoard[0, 2] == 'X')
            {
                return TicTacToeResult.X;
            }
            else if (finalBoard[0, 0] == 'X' && finalBoard[1, 1] == 'X' && finalBoard[2, 2] == 'X')
            {
                return TicTacToeResult.X;
            }
            else if (finalBoard[1, 0] == 'X' && finalBoard[1, 1] == 'X' && finalBoard[1, 2] == 'X')
            {
                return TicTacToeResult.X;
            }
            else if (finalBoard[2, 0] == 'X' && finalBoard[2, 1] == 'X' && finalBoard[2, 2] == 'X')
            {
                return TicTacToeResult.X;
            }
            else if (finalBoard[2, 0] == 'X' && finalBoard[1, 1] == 'X' && finalBoard[0, 2] == 'X')
            {
                return TicTacToeResult.X;
            }
            else if (finalBoard[0, 1] == 'X' && finalBoard[1, 1] == 'X' && finalBoard[2, 1] == 'X')
            {
                return TicTacToeResult.X;
            }
            else if (finalBoard[0, 2] == 'X' && finalBoard[1, 2] == 'X' && finalBoard[2, 2] == 'X')
            {
                return TicTacToeResult.X;
            }
            else
            {
                return TicTacToeResult.Draw;
            }

        }

        public bool EachArrayInJaggedArrayContainsTargetNumber(int[][] numbers, int targetNumber)
        {
            if (numbers.Length == 0)
            { return false; }

            int outerarrays = 0;
            int contains = 0;
            int arraycount = 0;

            foreach (var arrays in numbers)
            {
                outerarrays += 1;
                contains = 0;

                foreach (var num in arrays)
                {
                    if (num == targetNumber)
                    {
                    contains = 1;
                    }
                }
                if (contains == 1)
                {
                    arraycount += 1;
                }
            }
            if (arraycount == outerarrays)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}
