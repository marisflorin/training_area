﻿using _5._1_Password_Generator;
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
        string symbols= "!\"#$%&'()*+-./:;<=>?@[\\]^_`{|}~";                                      
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
            bool onlySmallLetters=false;
            for (int i = 0; i < password.Length; i++)
            {
                onlySmallLetters = false;
                for (int j = 0; j < smallLetters.Length; j++)
                {
                    if (password[i] == smallLetters[j]) onlySmallLetters = true;
                }
                if (onlySmallLetters == false) break;
            }
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
            int largeLetterCount = 0;
            for (int i = 0; i < options.passwordLength; i++)
            {
              for (int j = 0; j < capitalLetters.Length; j++)
                 if (password[i] == capitalLetters[j]) largeLetterCount++;              
            }
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
            int digitCount = 0;
            for (int i = 0; i < options.passwordLength; i++)
            {
                for (int j = 0; j < digits.Length; j++)
                    if (password[i] == digits[j]) digitCount++;
            }
            Assert.AreEqual(digitCount, options.numberOfDigits);
        }
        [TestMethod]
        public void TestTwoSymbolsDigits()
        {
            Password options = new Password
            {
                passwordLength = 8,
                smallLetters = true,
                numberOfCapitalLetters = 2,
                numberOfDigits = 1,
                numberOfSymbols = 2,
                exculdeSimilarChar = false,
                excludeAmbiguousChar = false
            };
            string password;
            password = PasswordGenerator.PasswordBuilder(options);
            int symbolCount = 0;
            for (int i = 0; i < options.passwordLength; i++)
            {
                for (int j = 0; j < symbols.Length; j++)
                    if (password[i] == symbols[j]) symbolCount++;
            }
            Assert.AreEqual(symbolCount, options.numberOfSymbols);
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
                numberOfSymbols = 3,
                exculdeSimilarChar = false,
                excludeAmbiguousChar = false
            };
            string password;
            password = PasswordGenerator.PasswordBuilder(options);
            Console.WriteLine(password);
       }
    }
}