using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCSharpDemo
{
    [TestFixture]
    public class MyFirstTest
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys("ojha");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            string title = driver.Title;

            Assert.AreEqual("ojha - Google search", title);
        }

        [TearDown]
        public void Clean()
        {

        }
    }
}
