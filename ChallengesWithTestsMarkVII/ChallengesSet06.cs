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
            bool isdupilicate = true;
            char[] strChar = str.ToCharArray();             int lastunique = 0;             int CheckCount = 0;             for (int i = 0; i < strChar.Length; i++)             {                 for (int e = 0; e < strChar.Length; e++)                 {                     if (strChar[i] != strChar[e] && i != e)                     {                         isdupilicate = false;
                        CheckCount += 1;
                                            }
                }             }              return lastunique;         }

        public int MaxConsecutiveCount(int[] numbers)
        {

            int MaxConsecutiveCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentMax = 0;
                for (int e = 0; e < numbers.Length - i; e++)
                {
                    while (numbers[i] == numbers[i + e])
                    {
                        currentMax += 1;
                        if (MaxConsecutiveCount <= currentMax)
                        {
                            MaxConsecutiveCount = currentMax;
                        }
                    }
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
