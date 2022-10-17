using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    public class PrintElement:IPrint
    {
        public static void printButton(IWebDriver driver)
        {
            IWebElement printButon = driver.FindElement(By.CssSelector("#teo_drawer_item_teo_drawer_print > a"));
            printButon.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static void selectSize(IWebDriver driver)
        {
            Thread.Sleep(500);
            IWebElement selectSize0 = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div/div[1]/div/span/span[1]/span"));
            
            selectSize0.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        public static void onizleme(IWebDriver driver)
        {
            IWebElement onizleme0 = driver.FindElement(By.Id("teo_print_preview_button"));
            onizleme0.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static void SourceCoordinate(IWebDriver driver)
        {
            IWebElement sourceCoordinate = driver.FindElement(By.Id("map"));
            var action = new Actions(driver);
            action.ClickAndHold(sourceCoordinate);
            action.MoveByOffset(100, 100);
            action.Release().Build().Perform();
            Thread.Sleep(3000);
        }

        public static void close(IWebDriver driver)
        {
            IWebElement close = driver.FindElement(By.XPath("/html/body/div[8]/div/div/div[1]/button"));
            close.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3000);
        }

    }
}
