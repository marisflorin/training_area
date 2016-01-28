using _5._1_Password_Generator;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _5._1_PasswordTests
{
    [TestClass]
    public class PasswordGeneratorTests
    {
        [TestMethod]
        public void PasswordLength()
        {
            string password="";
            PasswordGenerator.PasswordBuilder(100, ref password);
            Assert.AreEqual(100, password.Length);
        }
        [TestMethod]
        public void TestIfSmallLetter()
        {
            string password = "";
            string smallLetters = "abcdefghijklmnopqrstuvwxyz";
            PasswordGenerator.PasswordBuilder(100, ref password);
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
    }
}
