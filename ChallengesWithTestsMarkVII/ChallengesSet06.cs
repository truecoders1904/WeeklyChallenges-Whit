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
            for (int i = 2; i < num; i++)             {                 if (num % i == 0)                 {                     return false;                 }             }             return true;         }


        public int IndexOfLastUniqueLetter(string str)
        {
            char[] strChar = str.ToCharArray();             int lastunique = 0;             int samecount = 0;             for (int i = 0; i < strChar.Length; i++)             {                 for (int e = 0; e < strChar.Length; e++)                 {                     if (strChar[i] == strChar[e])                     {                         samecount += 1;                     }                     else                     {                         lastunique = i;                      }

                }             }             if (samecount == strChar.Length)             {                 return -1;             }             return lastunique;         }

        public int MaxConsecutiveCount(int[] numbers)
        {
            throw new NotImplementedException();
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
