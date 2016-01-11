using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the reference for our browser
            IWebDriver driver = new FirefoxDriver();

            driver.Navigate().GoToUrl(@"D:\Dropbox\ValtechProjects\WEB\Calculator\index.html");

            //Find the element
            IWebElement btn_0 = driver.FindElement(By.Name("0"));
            IWebElement btn_1 = driver.FindElement(By.Name("1"));
            IWebElement btn_2 = driver.FindElement(By.Name("2"));
            IWebElement btn_3 = driver.FindElement(By.Name("3"));
            IWebElement btn_4 = driver.FindElement(By.Name("4"));
            IWebElement btn_5 = driver.FindElement(By.Name("5"));
            IWebElement btn_6 = driver.FindElement(By.Name("6"));
            IWebElement btn_7 = driver.FindElement(By.Name("7"));
            IWebElement btn_8 = driver.FindElement(By.Name("8"));
            IWebElement btn_9 = driver.FindElement(By.Name("9"));
            IWebElement btn_minus = driver.FindElement(By.Name("-"));
            IWebElement btn_plus = driver.FindElement(By.Name("+"));
            IWebElement btn_divide = driver.FindElement(By.Name("/"));
            IWebElement btn_multi = driver.FindElement(By.Name("*"));
            IWebElement btn_equal = driver.FindElement(By.Name("="));
            IWebElement btn_clear = driver.FindElement(By.Name("c"));
            
            btn_0.Click();
            btn_1.Click();
            btn_2.Click();
            btn_3.Click();
            btn_4.Click();
            btn_5.Click();
            btn_6.Click();
            btn_7.Click();
            btn_8.Click();
            btn_9.Click();
            btn_divide.Click();
            btn_minus.Click();
            btn_multi.Click();
            btn_plus.Click();
            btn_equal.Click();
            btn_clear.Click();
            driver.Close();
        }
    }
}
