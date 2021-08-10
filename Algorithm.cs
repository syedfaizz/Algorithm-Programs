using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Algorithm
    {
        static readonly ArrayList palindromeList = new ArrayList();
        const int LIMIT = 1000;
        public static void PrintPrime()
        {
            bool temp;
            for (int i = 11; i <= LIMIT; i++)
            {
                temp = false;
                for (int j = 11; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        temp = true;
                        break;
                    }
                }
                if (temp == false)
                    PrimePalindrome(i);
            }
            Console.WriteLine();
        }
        public static void PrimePalindrome(int num)
        {
            if (PalindromePrime.IsPalindrome(num) == true)
            {
                palindromeList.Add(num);
            }
        }
        public static void PrintPalindrome()
        {
            Console.WriteLine("Palindrome-Prime in Range");
            foreach (int prime in palindromeList)
            {
                Console.Write(prime + " ");
            }
            Console.WriteLine();
        }
    }
}