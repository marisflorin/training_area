using _5._1_Password_Generator;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _5._1_PasswordTests
{
    [TestClass]
    public class PasswordGeneratorTests
    {
        string smallLetters = "abcdefghijklmnopqrstuvwxyz";
        string capitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string digits = "0123456789";
        string symbols= "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
        string similars = "l1Lo0O";
        string ambiguous = "{}[]()/\'\"~,;.<>";                                 
        [TestMethod]
        public void PasswordLength()
        {
            Password options = new Password
            {
                passwordLength = 5,
                smallLetters = true,
                numberOfCapitalLetters = 0,
                numberOfDigits = 0,
                numberOfSymbols = 0,
                exculdeSimilarChar = false,
                excludeAmbiguousChar = false
            };
            string password= PasswordGenerator.PasswordBuilder(options);            
            Assert.AreEqual(5, password.Length);
        }
        [TestMethod]
        public void TestOnlySmallLetters()
        {
            Password options = new Password
            {
                passwordLength = 5,
                smallLetters = true,
                numberOfCapitalLetters = 0,
                numberOfDigits = 0,
                numberOfSymbols = 0,
                exculdeSimilarChar = false,
                excludeAmbiguousChar = false
            };
            string password = PasswordGenerator.PasswordBuilder(options);         
            bool onlySmallLetters=PasswordGenerator.CheckOnlySmallLetters(password, smallLetters);
            Assert.AreEqual(true, onlySmallLetters);
        }
        [TestMethod]
        public void TestTwoCapitalLetters()
        {
            Password options = new Password
            {
                passwordLength = 5,
                smallLetters = true,
                numberOfCapitalLetters = 2,
                numberOfDigits = 0,
                numberOfSymbols = 0,
                exculdeSimilarChar = false,
                excludeAmbiguousChar = false
            };
            string password;
            password = PasswordGenerator.PasswordBuilder(options);
            int largeLetterCount = PasswordGenerator.Counter(password,capitalLetters);            
            Assert.AreEqual(largeLetterCount,options.numberOfCapitalLetters);
        }
        [TestMethod]
        public void TestThreeDigits()
        {
            Password options = new Password
            {
                passwordLength = 8,
                smallLetters = true,
                numberOfCapitalLetters = 2,
                numberOfDigits = 3,
                numberOfSymbols = 0,
                exculdeSimilarChar = false,
                excludeAmbiguousChar = false
            };
            string password;
            password = PasswordGenerator.PasswordBuilder(options);
            int digitCount = PasswordGenerator.Counter(password, digits);
            Assert.AreEqual(digitCount, options.numberOfDigits);
        }
        [TestMethod]
        public void TestTwoHundredSymbols()
        {
            Password options = new Password
            {
                passwordLength = 230,
                smallLetters = true,
                numberOfCapitalLetters = 2,
                numberOfDigits = 2,
                numberOfSymbols = 200,
                exculdeSimilarChar = false,
                excludeAmbiguousChar = false
            };
            string password;
            password = PasswordGenerator.PasswordBuilder(options);
            int symbolCount = PasswordGenerator.Counter(password, symbols);
            Assert.AreEqual(options.numberOfSymbols, symbolCount);
        }
        [TestMethod]
        public void PrintPassword()
        {
            Password options = new Password
            {
                passwordLength = 14,
                smallLetters = true,
                numberOfCapitalLetters = 3,
                numberOfDigits = 4,
                numberOfSymbols = 2,
                exculdeSimilarChar = false,
                excludeAmbiguousChar = false
            };
            string password;
            password = PasswordGenerator.PasswordBuilder(options);
            Console.WriteLine(password);
       }
        [TestMethod]
        public void CheckForSimilar()
        {
            Password options = new Password
            {
                passwordLength = 1000,
                smallLetters = true,
                numberOfCapitalLetters = 300,
                numberOfDigits = 400,
                numberOfSymbols = 100,
                exculdeSimilarChar = true,
                excludeAmbiguousChar = false
            };
            string password;           
            password = PasswordGenerator.PasswordBuilder(options);
            bool noSimilars = PasswordGenerator.CheckNotExistence(password, similars);            
            Assert.AreEqual(noSimilars, options.exculdeSimilarChar);            
        }
        [TestMethod]
        public void CheckForAmbiguous()
        {
            Password options = new Password
            {
                passwordLength = 1000,
                smallLetters = true,
                numberOfCapitalLetters = 300,
                numberOfDigits = 400,
                numberOfSymbols = 100,
                exculdeSimilarChar = false,
                excludeAmbiguousChar = true
            };
            string password;
            password = PasswordGenerator.PasswordBuilder(options);
            bool noAmbiguous = PasswordGenerator.CheckNotExistence(password, ambiguous);
            Assert.AreEqual(noAmbiguous, options.excludeAmbiguousChar);
        }
            [TestMethod]
            [ExpectedException(typeof(ArgumentException), "Password length is too small")]
        public void TooManyCharsTest()
        {
            Password options = new Password
            {
                passwordLength = 10,
                smallLetters = true,
                numberOfCapitalLetters = 5,
                numberOfDigits = 5,
                numberOfSymbols = 5,
                exculdeSimilarChar = false,
                excludeAmbiguousChar = true
            };
            string password;
            password = PasswordGenerator.PasswordBuilder(options);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Password length is not correct")]
        public void IncorrectPasswordLengthTest()
        {
            Password options = new Password
            {
                passwordLength = 10,
                smallLetters = false,
                numberOfCapitalLetters = 2,
                numberOfDigits = 2,
                numberOfSymbols = 2,
                exculdeSimilarChar = false,
                excludeAmbiguousChar = true
            };
            string password;
            password = PasswordGenerator.PasswordBuilder(options);
        }
    }
}
