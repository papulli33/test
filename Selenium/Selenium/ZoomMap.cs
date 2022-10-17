using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;


namespace Selenium
{
    internal class ZoomMap
    {
        public static void start(IWebDriver driver)
        {
            
            IWebElement scaleFirst = driver.FindElement(By.XPath("/html/body/div[3]/div[1]/input"));
            string firstScaleValue = scaleFirst.GetAttribute("value");
            int firstNumber = Convert.ToInt32(firstScaleValue);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement clickingZoom = driver.FindElement(By.XPath("/html/body/div[5]/button[2]"));
            Actions builder = new (driver);
            builder.MoveByOffset(50,40).DoubleClick(clickingZoom).Build().Perform();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement scaleSecond = driver.FindElement(By.XPath("/html/body/div[3]/div[1]/input"));
            Thread.Sleep(2000);
            string secondScaleValue = scaleSecond.GetAttribute("value");
            int secondNumber = Convert.ToInt32(secondScaleValue);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            if (firstNumber > secondNumber)
            {
                DateTime now = DateTime.Now;
                var jh = (TestName: typeof(ZoomMap).Name, version: "1.0", Date: now, Status: "Successfully");
                Console.WriteLine($"Test Name : {jh.TestName} || Version : {jh.version} || Status : {jh.Status} || Date: {jh.Date}.");
            }
            else 
            {
                DateTime now = DateTime.Now;
                var jh = (TestName: typeof(ZoomMap).Name, version: "1.0", Date: now, Status: "Unsuccessfully");
                Console.WriteLine($"Test Name : {jh.TestName} || Version : {jh.version} || Status : {jh.Status} || Date: {jh.Date}.");
            }


        }
    }
}
