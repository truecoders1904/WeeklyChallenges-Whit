using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (startNumber == 0)
            {
                return n;
            }

            List<int> firstlist = new List<int>();
            int maxLoop = startNumber * n;
            int[] numbersDivisblebyN = new int[0];

            for (int i = 0; i < maxLoop; i++)
            {
                if (i > startNumber && i % n == 0)
                {
                    firstlist.Add(i);
                }

            }

            firstlist.ToArray();
            return firstlist[0];

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
            string finalSentence = "";

            List<String> sentence = new List<String>();
            foreach (string word in words)
            {
                if (word != "" || word != " " || word != " ")
                {
                    word.Trim();
                    sentence.Add(word + " ");
                }
            }

            for (int i = 0; i < sentence.Count; i++)
            {
                finalSentence += sentence.ElementAt(i);
            }

            return finalSentence.Trim() + ".";



        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null)
            {
                return new double[0];
            }
            double[] array = elements.ToArray();
            List<double> everyFourthelement = new List<double>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 4 == 0)
                {
                    everyFourthelement.Add(array[i]);
                }
            }
            var result = everyFourthelement.ToArray();
            return result;
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
