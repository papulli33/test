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
    internal class CoordinateInput: Helper
    {
        public static void start(IWebDriver driver)
        {
            IWebElement sourceCoordinate = driver.FindElement(By.XPath("/html/body/div[2]"));
            Actions builder = new Actions(driver);
            builder.DoubleClick().Build().Perform();

            // First Coordinate
            (string, string) First = Helper.coordinate(driver, "map", "teo_map_coordinate_component_main_input");

            //Second Coordinate;
            (string, string) Second = Helper.coordinate(driver, "map","teo_map_coordinate_component_main_input");

            if (First != Second)
            {
                Debug.WriteLine("It is working success. Coordinate input");
            }
            else if (First == Second)
            {
                Debug.WriteLine("It has bug. Coordinate input");
            }


            Thread.Sleep(2000);

        }
    }
}
