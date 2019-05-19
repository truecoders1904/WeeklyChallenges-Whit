using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            throw new NotImplementedException();
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)             {                 if (businesses[i].TotalRevenue == 0 || businesses[i].TotalRevenue == null)                 {                     businesses[i].Name = "CLOSED";                 }              }         }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int NumbersAscendingCount = 0;
            int NumbersOutofOrderCount = 0;
            int currentNumber = 0;
            int nextNumber = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                currentNumber = numbers[i];
                nextNumber = numbers[i + 1];
                if (currentNumber <= nextNumber)
                {
                    NumbersAscendingCount += 1;
                }
                else
                {
                    NumbersOutofOrderCount += 1;
                }

            }

            if (NumbersOutofOrderCount >= 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
