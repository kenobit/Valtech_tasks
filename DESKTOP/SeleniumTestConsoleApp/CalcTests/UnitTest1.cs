using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace CalcTests
{
    [TestFixture]
    public class UnitTest1
    {

        IWebDriver driver = new FirefoxDriver();
        [SetUp]
        public void SetupTest()
        {
            driver.Navigate().GoToUrl(@"D:\Dropbox\ValtechProjects\WEB\Calculator\index.html");
        }
        //IWebElement all_btns;
        [Test]
        [TestCase("0", "0")]
        [TestCase("1", "1")]
        [TestCase("2", "2")]
        [TestCase("3", "3")]
        [TestCase("4", "4")]
        [TestCase("5", "5")]
        [TestCase("6", "6")]
        [TestCase("7", "7")]
        [TestCase("8", "8")]
        [TestCase("9", "9")]
        [TestCase("/", "/")]
        [TestCase("*", "*")]
        [TestCase("-", "-")]
        [TestCase("+", "+")]
        [TestCase("=", "")]
        [TestCase("c", "")]
        public void FF_btn_click(string name, string res)
        {
            driver.FindElement(By.Name(name)).Click();
            string resActual = driver.FindElement(By.Id("screen_TB")).GetAttribute("value");
            Assert.AreEqual(resActual, res);
            //driver.Close();
        }

        [Test]
        [TestCase("1", "2", "3", "123")]
        [TestCase("4", "5", "6", "456")]
        [TestCase("7", "8", "9", "789")]
        [TestCase("0", "/", "*", "NaN*")]
        [TestCase("+", "-", "c", "")]
        public void FF_btn_click_more(string btn1, string btn2, string btn3, string res)
        {
            driver.FindElement(By.Name(btn1)).Click();
            driver.FindElement(By.Name(btn2)).Click();
            driver.FindElement(By.Name(btn3)).Click();
            string resActual = driver.FindElement(By.Id("screen_TB")).GetAttribute("value");
            Assert.AreEqual(resActual, res);
        }
        [Test]
        [TestCase("1", "+", "3", "=", "4")]
        [TestCase("10", "-", "8", "=", "2")]
        [TestCase("7", "*", "3", "=", "21")]
        [TestCase("10", "/", "2", "=", "5*")]
        [TestCase("15", "-", "25", "=", "-10")]
        public void Calc_two(string num1, string operation, string num2 ,string equal, string res)
        {
            driver.FindElement(By.Name(num1)).Click();
            driver.FindElement(By.Name(operation)).Click();
            driver.FindElement(By.Name(num2)).Click();
            driver.FindElement(By.Name(equal)).Click();
            driver.FindElement(By.Name(res)).Click();
            string resActual = driver.FindElement(By.Id("screen_TB")).GetAttribute("value");
            Assert.AreEqual(resActual, res);
        }
    }
}
