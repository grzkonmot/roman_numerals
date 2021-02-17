using System;

namespace RomanNumerals
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int ParseRomanNumeral(string s)
        {
            int order = 1;
            int sum = 0;
            s = s.ToUpper();

            for (int i = 1; s.Length - i > -1; i++)
            {
                switch (s[^i])
                {
                    case 'I':
                        sum = sum + 1 * order;
                        break;
                    case 'V':
                        order = -1;
                        sum += 5;
                        break;
                    case 'X':
                        sum += 10;
                        break;
                    case 'C':
                        sum += 100;
                        break;
                    case 'L':
                        order = -10;
                        sum += 50;
                        break;
                    case 'D':
                        sum += 500;
                        break;
                    case 'M':
                        sum += 1000;
                        break;
                }
            }
            return sum;
        }
    }
}
