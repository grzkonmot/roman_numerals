using System;

namespace RomanNumerals
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(ParseRomanNumeral("IV"));
            Console.WriteLine(ParseRomanNumeral("IX"));
            Console.WriteLine(ParseRomanNumeral("XL"));
        }

        public static int ParseRomanNumeral(string s)
        {
            int order = 1;
            int decaOrder = 1;
            int hectaOrder = 1;
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
                        sum += 10 * decaOrder;
                        order = -1;
                        //decaOrder = -1;
                        break;
                    case 'C':
                        sum += 100 * hectaOrder;
                        decaOrder = -1;
                        break;
                    case 'L':
                        sum += 50 * decaOrder;
                        decaOrder = -1;
                        break;
                    case 'D':
                        sum += 500 * hectaOrder;
                        hectaOrder = -1;
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
