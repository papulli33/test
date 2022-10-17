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
    internal class ToolbarZoom:Helper
    {
        public static void start(IWebDriver driver)
        {
            /*IWebElement closingLayers = driver.FindElement(By.Id("teo_drawer_toggle_button"));
            closingLayers.Click();
            Thread.Sleep(1000);*/

            IWebElement toolbar = driver.FindElement(By.Id("toolbar_item_teo_toolbar_menu"));
            toolbar.Click();
            Thread.Sleep(1000);

            IWebElement zoom = driver.FindElement(By.XPath("/html/body/div[7]/div[5]"));
            zoom.Click();
            Thread.Sleep(1000);

            string map = Helper.map(driver, "map");

        }
    }
}
