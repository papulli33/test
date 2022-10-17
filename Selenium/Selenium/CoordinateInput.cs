using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions.Internal;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;

namespace Selenium
{
    internal class CoordinateInput 
    {
        public static void start(IWebDriver driver)
        {
            IWebElement sourceCoordinate = driver.FindElement(By.XPath("/html/body/div[2]"));
            Actions builder = new (driver);

            // First Coordinate
            builder.MoveToElement(sourceCoordinate).DoubleClick().Perform();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement firstCoordinate = driver.FindElement(By.Id("teo_map_coordinate_component_main_input"));
            string first = firstCoordinate.GetAttribute("value");

            //Second Coordinate
            builder.MoveToElement(sourceCoordinate).MoveByOffset(50, 40).Perform();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement secondCoordinate = driver.FindElement(By.Id("teo_map_coordinate_component_main_input"));
            string second = secondCoordinate.GetAttribute("value");

            if (first != second)
            {
                DateTime now = DateTime.Now;
                var jh = (TestName: typeof(CoordinateInput).Name, version: "1.0", Date: now, Status: "Successfully");
                Console.WriteLine($"Test Name : {jh.TestName} || Version : {jh.version} || Status : {jh.Status} || Date: {jh.Date}.");
            }
            else if (first == second)
            {
                DateTime now = DateTime.Now;
                var jh = (TestName: typeof(CoordinateInput).Name, version: "1.0", Date: now, Status: "Unsuccessfully");
                Console.WriteLine($"Test Name : {jh.TestName} || Version : {jh.version} || Status : {jh.Status} || Date: {jh.Date}.");
            }


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }
    }
}
