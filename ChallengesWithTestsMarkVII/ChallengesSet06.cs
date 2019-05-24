using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            throw new NotImplementedException();
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i < num; i++)             {                 if (num % i == 0)                 {                     return false;                 }             }             return true;         }


        public int IndexOfLastUniqueLetter(string str)
        {
            if (str.Length == 0)
            {
                return -1;
            }
            if(str.Length == 1)
            {
                return 0;
            }
            int lastIndex = 0;
            string temp1 = "";
            string temp2 = "";
            int sameCount = 0;
            for (int i = 0; i < str.Length; i++)
            {

                int ContainsSame = 0;
                temp1 = str.Substring(i, 1);
                for (int e = 0; e < str.Length; e++)
                {
                    temp2 = str.Substring(e, 1);
                    if ((temp1 == temp2) && (i != e))
                    {
                        ContainsSame += 1;
                        sameCount = ContainsSame;
                    }

                }
                if (ContainsSame < 1)
                {
                    lastIndex = i;
                }
            }
            if (lastIndex == 0 && sameCount == str.Length -1)
            {
                return -1;
            }
            else
            {
                return lastIndex;
            }
         }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int currentMax = 0;
            int MaxConsecutiveCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                currentMax = 0;
                for (int e = i; e < numbers.Length; e++)
                {
                    if (numbers[i] == numbers[e])
                    {
                        currentMax += 1;
                    }
                    else if (numbers[i] != numbers[e])
                    {
                        i = e - 1;
                        break;
                    }

                }
                if (currentMax > MaxConsecutiveCount)

                {
                    MaxConsecutiveCount = currentMax;

                }
            }

            return MaxConsecutiveCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            double[] emptyStringArray = new double[0];
            if ( elements == null)
            {
                return emptyStringArray;
            }
                
            List<double> everyNTH = new List<double>();             double[] elementsarray = elements.ToArray();
            if (elementsarray.Length == 0 || n < 0)
            {
                return emptyStringArray;
            }             for (int i = n; i <= elementsarray.Length; i += n)             {
                  everyNTH.Add(elementsarray[i - 1]);             }

            return everyNTH.ToArray();
        }

    }

}
