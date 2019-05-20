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
            for (int i = 0; i < businesses.Length; i++)             {                 if (businesses[i].TotalRevenue == 0 || businesses[i].TotalRevenue == null)                 {                     businesses[i].Name = "CLOSED";                 }             }         }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            int NumbersOutofOrderCount = 0;
            int currentNumber = 0;
            int nextNumber = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                currentNumber = numbers[i];
                nextNumber = numbers[i + 1];
                if (currentNumber > nextNumber)
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
            if (numbers == null)
            {
                return 0;
            }

            int sum = 0;
            int currentNumber = 0;
            int nextNumber = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                currentNumber = numbers[i];
                nextNumber = numbers[i + 1];
                if (numbers[i] % 2 == 0)
                {
                    sum += nextNumber;
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            int containsLetters = 0;
           if (words == null || words.Length == 0)
            {
                return "";
            }
            string result = words[0];

            for (int i = 1; i < words.Length; i++)
            {
                if (words[i] != "" || words[i] != " "|| words[i] != "   ")
                {
                    result += " " + words[i];
                    containsLetters += 1;
                }
              
            }

            if (containsLetters == 0)
            {
                return "";
            }
            else
            {
                return result + ".";
            }
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            int CountofSumsthatEqualTarget = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int e = 0; e < nums.Length; e++)
                {
                    if (i != e)
                    {
                        if (nums[i] + nums[e] == targetNumber)
                        {
                            CountofSumsthatEqualTarget += 1;
                        }
                    }
                }
            }
            if (CountofSumsthatEqualTarget >= 1)
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
