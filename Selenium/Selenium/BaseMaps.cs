using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Selenium
{
    internal class BaseMaps
    {
        public static void start(IWebDriver driver)
        {
            List<int> testResultsWidth = new List<int>();
            List<int> testResultsHeight = new List<int>();

            driver.FindElement(By.XPath("/html/body/div[1]/div/div/button")).Click();

            driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div[2]/div/ul/li[4]/a")).Click();

            BaseMapsMethod(driver, testResultsWidth, testResultsHeight, "/html/body/div[1]/div/div/div[2]/div/div/div/div/div[1]/div[2]/ul/li[1]/a", "/html/body/div[1]/div/div/div[2]/div/div/div/div/div[2]/div[1]");
            BaseMapsMethod(driver, testResultsWidth, testResultsHeight, "/html/body/div[1]/div/div/div[2]/div/div/div/div/div[1]/div[2]/ul/li[2]/a", "/html/body/div[1]/div/div/div[2]/div/div/div/div/div[2]/div[1]/div[1]/div/div/div[1]/div[2]");
            BaseMapsMethod(driver, testResultsWidth, testResultsHeight, "/html/body/div[1]/div/div/div[2]/div/div/div/div/div[1]/div[2]/ul/li[3]/a", "/html/body/div[1]/div/div/div[2]/div/div/div/div/div[2]/div[1]/div[1]/div/div/div[1]/div[2]");

            bool testPassed = true;
            for (int i = 1; i < testResultsWidth.Count; i++)
            {
                for (int j = i-1 ; j > 0; j--)
                {
                    if (testResultsWidth[i] == testResultsWidth[j] && testResultsHeight[i] == testResultsHeight[j])
                    {
                        testPassed = false;
                    }
                }
            }

            if (testPassed)
            {
                DateTime now = DateTime.Now;
                var jh = (TestName: typeof(BaseMaps).Name, version: "1.0", Date: now, Status: "Successfully");
                Console.WriteLine($"Test Name : {jh.TestName} || Version : {jh.version} || Status : {jh.Status} || Date: {jh.Date}.");
            }
            else
            {
                DateTime now = DateTime.Now;
                var jh = (TestName: typeof(BaseMaps).Name, version: "1.0", Date: now, Status: "Unsuccessfully");
                Console.WriteLine($"Test Name : {jh.TestName} || Version : {jh.version} || Status : {jh.Status} || Date: {jh.Date}.");
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //if (FirstDimension == SecondDimension || FirstDimension == ThirdDimension || SecondDimension == ThirdDimension)

            static void BaseMapsMethod(IWebDriver driver, List<int> testResultsWidth, List<int> testResultsHeight, string xpath1, string xpath2)
            {
                IWebElement selectButon = driver.FindElement(By.XPath(xpath1));
                selectButon.Click();
                IWebElement basemap = driver.FindElement(By.XPath(xpath2));
                testResultsWidth.Add(basemap.Size.Width);
                testResultsHeight.Add(basemap.Size.Height);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }

        }
    }
}
