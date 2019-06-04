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
                string removecomma = result.Remove(result.Length - 1);
                return removecomma;
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
            throw new NotImplementedException();
        }

        public bool EachArrayInJaggedArrayContainsTargetNumber(int[][] numbers, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
