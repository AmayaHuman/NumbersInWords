using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumbersInWords.Converter
{
    public class NumbersInWordsConverter
    {
        private readonly Dictionary<int, string> digitOnes = new Dictionary<int, string> {
            {1, "one" },
            {2, "two" },
            {3, "three" },
            {4, "four" },
            {5, "five" },
            {6, "six" },
            {7, "seven" },
            {8, "eight" },
            {9, "nine" },
            {0, "" }
        };

        private readonly Dictionary<int, string> digitTens = new Dictionary<int, string> {
            {1, "ten" },
            {2, "twenty" },
            {3, "thirty" },
            {4, "forty" },
            {5, "fifty" },
            {6, "sixty" },
            {7, "seventy" },
            {8, "eighty" },
            {9, "ninety" },
            {0, "" }
        };

        private readonly Dictionary<int, string> tenThroughTeens = new Dictionary<int, string> {
            {10, "ten" },
            {11, "eleven" },
            {12, "twelve" },
            {13, "thirteen" },
            {14, "fourteen" },
            {15, "fifteen" },
            {16, "sixteen" },
            {17, "seventeen" },
            {18, "eighteen" },
            {19, "nineteen" }
        };

        public String ConvertToWords(double numberToConvert)
        {

            string[] numberString = numberToConvert.ToString().Split('.');
            string result;

            if (numberString[0].Length == 2)
            {
                int tenDigit;
                int onesDigit;
                bool tensDigitParsed = int.TryParse(numberString[0].Substring(0, 1), out tenDigit);
                bool onesDigitParsed = int.TryParse(numberString[0].Substring(1, 1), out onesDigit);

                if (tensDigitParsed && tenDigit == 1)
                {
                    result = ConvertTenToNineteen(int.Parse(numberString[0]));
                }
                else if (tensDigitParsed && digitTens.Keys.Contains(tenDigit))
                {
                    result = digitTens[tenDigit];

                    if (onesDigit != 0)
                    {
                        result += " " + ConvertOnesDigit(onesDigit);
                    }
                }

                else
                {
                    result = "Can't convert the Number to Words.";
                }
                

            }
            else if(numberString[0].Length == 1)
            {
                result = ConvertOnesDigit(int.Parse(numberString[0]));
            }
            else
            {
                result = "Can't convert the Number to Words.";
            }

            return result;
        }

        private string ConvertTenToNineteen(int numberToConvert)
        {
            string result;
            if (tenThroughTeens.Keys.Contains(numberToConvert))
            {
                result = tenThroughTeens[numberToConvert];
            }
            else
            {
                result = "Can't convert the Number to Words.";
            }

            return result;
        }

        private string ConvertOnesDigit(int numberToConvert)
        {
            string result;
            if (digitOnes.Keys.Contains((int)numberToConvert))
            {
                result = digitOnes[(int)numberToConvert];
            }
            else
            {
                result = "Can't convert the Number to Words.";
            }

            return result;
        }
    }
}