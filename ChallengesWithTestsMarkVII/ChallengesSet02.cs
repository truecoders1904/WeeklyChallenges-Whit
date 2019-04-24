using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
                

        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if(numbers?.Any() != true)
            {
             return 0;
            }

            else
            {
                return numbers.Min() + numbers.Max();
            }


        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int str1length = str1.Length;
            int str2length = str2.Length;

            if (str1length >= str2length)
            {
                return str2length;
            }
            else if (str1length <= str2length)
            {
                return str1length;
            }
            else
            {
                return 0;
            }
            



        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int sum = 0;
            foreach (int i in numbers)
                {
                    sum += i;
                }
            return sum;


        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int sum = 0;
            foreach (int i in numbers)
                if (i % 2 == 0)
                {
                    sum += i;
                }
            return sum;

        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            else if (numbers.Sum() % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {

            if (number > 0)
            {
                return number / 2;
            }
            else
            {
                return 0;
            }
        }
    }
}
