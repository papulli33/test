using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace Selenium
{
    internal class ToolbarZoom
    {
        public static void start(IWebDriver driver)
        {
            IWebElement closingLayers = driver.FindElement(By.Id("teo_drawer_toggle_button"));
            closingLayers.Click();

            IWebElement scaleFirst = driver.FindElement(By.XPath("/html/body/div[3]/div[1]/input"));
            string firstScaleValue = scaleFirst.GetAttribute("value");
            int firstNumber = Convert.ToInt32(firstScaleValue);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement toolbar = driver.FindElement(By.Id("toolbar_item_teo_toolbar_menu"));
            toolbar.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement zoom = driver.FindElement(By.XPath("/html/body/div[7]/div[5]"));
            zoom.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement sourceCoordinate = driver.FindElement(By.Id("map"));
            var action = new Actions(driver);
            action.MoveByOffset(50, 40);
            action.ClickAndHold(sourceCoordinate);
            action.MoveByOffset(100, 150);
            action.Release().Build().Perform();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement scaleSecond = driver.FindElement(By.XPath("/html/body/div[3]/div[1]/input"));
            Thread.Sleep(2000);
            string secondScaleValue = scaleSecond.GetAttribute("value");
            int secondNumber = Convert.ToInt32(secondScaleValue);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            if (firstNumber > secondNumber)
            {
                DateTime now = DateTime.Now;
                var jh = (TestName: typeof(ToolbarZoom).Name, version: "1.0", Date: now, Status: "Successfully");
                Console.WriteLine($"Test Name : {jh.TestName} || Version : {jh.version} || Status : {jh.Status} || Date: {jh.Date}.");
            }
            else
            {
                DateTime now = DateTime.Now;
                var jh = (TestName: typeof(ToolbarZoom).Name, version: "1.0", Date: now, Status: "Unsuccessfully");
                Console.WriteLine($"Test Name : {jh.TestName} || Version : {jh.version} || Status : {jh.Status} || Date: {jh.Date}.");
            }
        }
    }
}
