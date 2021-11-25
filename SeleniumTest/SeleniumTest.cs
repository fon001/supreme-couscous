using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace SeleniumTest
{

    public class Tests
    {
        IWebDriver driver = new ChromeDriver(); //


        [SetUp]
        public void OpenBrowser()
        {
            driver.Navigate().GoToUrl("http://bpcalapp-dev.eu-west-1.elasticbeanstalk.com");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [Test]
        public void EnterText()
        {
            IWebElement element1 = driver.FindElement(By.Id("BP_Systolic"));  // id="BP_Systolic"
            element1.Clear();
            element1.SendKeys("89");
            Thread.Sleep(2000);
            Console.WriteLine("Systolic value entered \n");

            IWebElement element2 = driver.FindElement(By.Id("BP_Diastolic")); // id="BP_Diastolic"
            element2.Clear();
            element2.SendKeys("59");
            Thread.Sleep(2000);
            Console.WriteLine("Diastolic value entered \n");

            IWebElement element3 = driver.FindElement(By.XPath("//div[@class='form-group']//input[@type='submit']"));
            element3.Submit();
            Thread.Sleep(3000);

            Assert.IsTrue(driver.FindElement(By.TagName("body")).Text.Contains("Low Blood Pressure"));
        }

        [TearDown]
        public void EndTest()
        {
            //close the browser  
            driver.Close();
        }
    }
}