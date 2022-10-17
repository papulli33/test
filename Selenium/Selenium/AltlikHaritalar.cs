using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    internal class AltlikHaritalar:Helper

    {
        public static void start(IWebDriver driver)
        {
            /*IWebElement opening = driver.FindElement(By.XPath("/html/body/div[1]/div/div/button"));
            opening.Click();*/

            IWebElement altlikButon = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div[2]/div/ul/li[4]/a"));
            altlikButon.Click();
            Thread.Sleep(500);

            var displayFirst = Helper.display(driver, "/html/body/div[1]/div/div/div[2]/div/div/div/div/div[2]/div[1]");

            IWebElement secondButon = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[1]/div[2]/ul/li[2]/a"));
            secondButon.Click();
            Thread.Sleep(500);

            var displaySecond = Helper.display(driver, "/html/body/div[1]/div/div/div[2]/div/div/div/div/div[2]/div[1]/div[1]/div/div/div[1]/div[2]");

            IWebElement thirdButon = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[1]/div[2]/ul/li[3]/a"));
            thirdButon.Click();
            Thread.Sleep(500);

            var displayThird = Helper.display(driver, "/html/body/div[1]/div/div/div[2]/div/div/div/div/div[2]/div[1]/div[1]/div/div/div[1]/div[2]");

            if (displayFirst  == displaySecond || displayFirst == displayThird || displaySecond == displayThird)
            {
                Debug.WriteLine("It has a bug. Altlık");
            }
            else if (displayFirst != displaySecond || displayFirst != displayThird || displaySecond != displayThird)
            {
                Debug.WriteLine("It is working success. Altlık");
            }
            Thread.Sleep(3000);

        }
    }
}
