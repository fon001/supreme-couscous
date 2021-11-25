using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SeleniumTest2
{
    [TestClass]
    public class SeleniumTest2
    {

        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        // URI for web app being tested
        private String webAppUri;


        [TestInitialize]                // run before each unit test
        public void Setup()
        {
            // read URL from SeleniumTest.runsettings
            //this.webAppUri = testContextInstance.Properties["webAppUri"].ToString();
            this.webAppUri = "http://bpcalapp-dev.eu-west-1.elasticbeanstalk.com";
        }


        [TestMethod]
        public void TestBrowser()
        {
            String chromeDriverPath = Environment.GetEnvironmentVariable("ChromeWebDriver");
            if (chromeDriverPath is null)
            {
                chromeDriverPath = ".";                 // for IDE
            }

            using (IWebDriver driver = new ChromeDriver(chromeDriverPath))
            {
                // any exception below results in a test fail

                // navigate to URI for temperature converter
                // web app running on IIS express
                driver.Navigate().GoToUrl(webAppUri);

                // get weight in stone element
                IWebElement SystolicEle = driver.FindElement(By.Id("BP_Systolic"));
                SystolicEle.Clear();
                SystolicEle.SendKeys("89");
                Thread.Sleep(2000);

                // get weight in stone element
                IWebElement DiastolicEle = driver.FindElement(By.Id("BP_Diastolic"));
                DiastolicEle.Clear();
                DiastolicEle.SendKeys("59");
                Thread.Sleep(2000);

                IWebElement SubmitButton = driver.FindElement(By.XPath("//div[@class='form-group']//input[@type='submit']"));
                SubmitButton.Submit();
                Thread.Sleep(3000);

                Assert.IsTrue(driver.FindElement(By.TagName("body")).Text.Contains("Low Blood Pressure"));


                driver.Quit();
            }
        }
    }
}
