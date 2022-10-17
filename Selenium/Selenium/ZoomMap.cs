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
            int firstNumber = Convert.ToInt32(firstScaleValue.ToString());
            Thread.Sleep(1000);

            IWebElement clickingZoom = driver.FindElement(By.XPath("/html/body/div[5]/button[2]"));
            Actions builder = new Actions(driver);
            builder.MoveByOffset(50,40).DoubleClick(clickingZoom).Build().Perform();
            Thread.Sleep(1000);

            IWebElement scaleSecond = driver.FindElement(By.XPath("/html/body/div[3]/div[1]/input"));
            string secondScaleValue = scaleSecond.GetAttribute("value");
            int secondNumber = Convert.ToInt32(secondScaleValue.ToString());
            Thread.Sleep(1000);

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("It is working success.");
            }
            else if (firstNumber <= secondNumber)
            {
                Console.WriteLine("It has bug.");
            }


        }
    }
}
