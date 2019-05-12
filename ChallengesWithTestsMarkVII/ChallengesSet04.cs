using System;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
                else if (numbers[i] % 2 != 0)
                {
                    sum -= numbers[i];
                }
                
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            throw new NotImplementedException();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            throw new NotImplementedException();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            throw new NotImplementedException();
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            else
            { 
                return false; 
            }
        }

        public bool IsStringANumber(string input)
        {
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            int notNullCount = 0;
            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                {
                    nullCount += 1;
                }
                else
                {
                    notNullCount += 1;
                }
            }
            if (nullCount > notNullCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            double averageEvenSum = 0;
            double averageEvenCount = 0;
            int nonEvenCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    averageEvenSum += numbers[i];
                    averageEvenCount += 1;
                }
                else
                {
                    nonEvenCount += 1;
                }
            }
            if (nonEvenCount != numbers.Length)
            {

                return averageEvenSum / averageEvenCount;
            }
            else
            {
                return 0;
            }
        }

        public int Factorial(int number)
        {
            int sum = 1;
            for (int i = 1; i <= number; i++)
            {
                sum = sum * i;
            }
            return sum;
        }
    }
}
