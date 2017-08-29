using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using NumbersInWords.Converter;

namespace NumbersInWords.Tests.Controllers
{
    [TestClass]
    public class NumbersInWordsConverterTest
    {
        [TestMethod]
        public void NumberToWords_Ones()
        {
            var converter = new NumbersInWordsConverter();

            Dictionary<double, string> testValues = new Dictionary<double, string> {
                {1, "one" },
                {2, "two" },
                {3, "three" },
                {4, "four" },
                {5, "five" },
                {6, "six" },
                {7, "seven" },
                {8, "eight" },
                {9, "nine" }
            };


            foreach(var testValue in testValues)
            {
                var result = converter.ConvertToWords(testValue.Key);

                Assert.AreEqual(testValue.Value, result);
            }

        }

        [TestMethod]
        public void NumberToWords_Tens()
        {
            var converter = new NumbersInWordsConverter();

            Dictionary<double, string> testValues = new Dictionary<double, string> {
                {10, "ten" },
                {20, "twenty" },
                {30, "thirty" },
                {40, "forty" },
                {50, "fifty" },
                {60, "sixty" },
                {70, "seventy" },
                {80, "eighty" },
                {90, "ninety" }
            };


            foreach (var testValue in testValues)
            {
                var result = converter.ConvertToWords(testValue.Key);

                Assert.AreEqual(testValue.Value, result);
            }

        }


        [TestMethod]
        public void NumberToWords_LessThanHundred()
        {
            var converter = new NumbersInWordsConverter();

            Dictionary<double, string> testValues = new Dictionary<double, string> {
                {22, "twenty two" },
                {35, "thirty five" },
                {47, "forty seven" },
                {59, "fifty nine" },
                {63, "sixty three" },
                {74, "seventy four" },
                {88, "eighty eight" },
                {90, "ninety" }
            };


            foreach (var testValue in testValues)
            {
                var result = converter.ConvertToWords(testValue.Key);

                Assert.AreEqual(testValue.Value, result);
            }
        }

        [TestMethod]
        public void NumberToWords_ElevenThroughNineteen()
        {
            var converter = new NumbersInWordsConverter();

            Dictionary<double, string> testValues = new Dictionary<double, string> {
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


            foreach (var testValue in testValues)
            {
                var result = converter.ConvertToWords(testValue.Key);

                Assert.AreEqual(testValue.Value, result);
            }
        }
    }
}
