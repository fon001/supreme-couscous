using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SeleniumTest
{
    public class Tests
    {
        IWebDriver iwdr = new ChromeDriver();

        [SetUp]
        public void BroswerWindow()
        {
            iwdr.Navigate().GoToUrl("http://bpcalapp-dev.eu-west-1.elasticbeanstalk.com");
            iwdr.Manage().Window.Maximize();
            Thread.Sleep(1000);
        }

        [Test]
        public void TextInput()
        {
            IWebElement ele_1 = iwdr.FindElement(By.Id("BP_Systolic"));
            ele_1.Clear();
            ele_1.SendKeys("120");
            Thread.Sleep(1000);
            Console.WriteLine("Systolic value entered ");

            IWebElement ele_2 = iwdr.FindElement(By.Id("BP_Diastolic"));
            ele_2.Clear();
            ele_2.SendKeys("80");
            Thread.Sleep(1000);
            Console.WriteLine("Diastolic value entered ");

            IWebElement ele_3 = iwdr.FindElement(By.XPath("//input[@type='submit']"));
            ele_3.Submit();
            Thread.Sleep(2000);

            Assert.IsTrue(iwdr.FindElement(By.TagName("body")).Text.Contains("Ideal Blood Pressure"));
        }

        [TearDown]
        public void CloseTest()
        {
            //close the browser  
            iwdr.Close();
        }
    }
}