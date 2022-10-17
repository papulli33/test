using Microsoft.Office.Interop.Excel;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V102.Browser;
using OpenQA.Selenium.Interactions;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    internal class Print:IPrint
    {
        
        public static void start(IWebDriver driver)
        {
            List<int> testResultsWidth = new List<int>();
            List<int> testResultsHeight = new List<int>();

            PrintElement.printButton(driver);

            PrintMethod(driver, testResultsWidth, testResultsHeight, "/html/body/span/span/span[2]/ul/li[2]");
            PrintMethod(driver, testResultsWidth, testResultsHeight, "/html/body/span/span/span[2]/ul/li[3]");
            PrintMethod(driver, testResultsWidth, testResultsHeight, "/html/body/span/span/span[2]/ul/li[4]");
            PrintMethod(driver, testResultsWidth, testResultsHeight, "/html/body/span/span/span[2]/ul/li[5]");
            PrintMethod(driver, testResultsWidth, testResultsHeight, "/html/body/span/span/span[2]/ul/li[6]");


            bool testPassed = true;
            for (int i = 1; i < testResultsWidth.Count; i++)
            {
                if (testResultsWidth[i - 1] == testResultsWidth[i] && testResultsHeight[i-1] == testResultsHeight[i])
                {
                    testPassed = false;
                }
            }

            if(testPassed)
            {
                DateTime now = DateTime.Now;
                var jh = (TestName: typeof(Print).Name, version: "1.0", Date: now, Status: "Successfully");
                Console.WriteLine($"Test Name : {jh.TestName} || Version : {jh.version} || Status : {jh.Status} || Date: {jh.Date}.");

            }
            else
            {
                DateTime now = DateTime.Now;
                var jh = (TestName: typeof(Print).Name, version: "1.0", Date: now, Status: "Unsuccessfully");
                Console.WriteLine($"Test Name : {jh.TestName} || Version : {jh.version} || Status : {jh.Status} || Date: {jh.Date}.");
            }
            Thread.Sleep(3000);


        }

        public static void PrintMethod(IWebDriver driver,List<int> testResultsWidth, List<int> testResultsHeight, string xpath)
        {
            PrintElement.selectSize(driver);

            IWebElement size = driver.FindElement(By.XPath(xpath));
            size.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            PrintElement.onizleme(driver);

            PrintElement.SourceCoordinate(driver);

            IWebElement image = driver.FindElement(By.XPath("//*[@id=\"print_map\"]"));
            testResultsWidth.Add(image.Size.Width);
            testResultsHeight.Add(image.Size.Height);
            Thread.Sleep(1000);

            PrintElement.close(driver);
        }
    }
}