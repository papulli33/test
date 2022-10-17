using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace Selenium
{
    public class Helper // Helper Method
    {
        public static (int, int) display(IWebDriver driver, string value)
        {
            IWebElement altlikharita = driver.FindElement(By.XPath(value));
            int dimensionWidthFirstView = altlikharita.Size.Width;
            int dimensionHeightFirstView = altlikharita.Size.Height;
            Thread.Sleep(2000);
            return (dimensionWidthFirstView, dimensionHeightFirstView);

        }

        public static string map(IWebDriver driver, string value)
        {
            IWebElement sourceCoordinate = driver.FindElement(By.Id(value));
            var action = new Actions(driver);
            action.MoveByOffset(50, 40);
            action.ClickAndHold(sourceCoordinate);
            action.MoveByOffset(100, 150);
            action.Release();
            action.Build().Perform();
            Thread.Sleep(3000);
            return (value);
        }

        public static (string,string) coordinate(IWebDriver driver, string mapId, string coordinateInputXpath)
        {
            IWebElement sourceCoordinate = driver.FindElement(By.Id(mapId));
            Actions builder = new Actions(driver);
            builder.MoveToElement(sourceCoordinate).MoveByOffset(50, 40).Perform();
            Thread.Sleep(3000);

            IWebElement Coordinate = driver.FindElement(By.Id(coordinateInputXpath));
            string takeCoordinate = Coordinate.GetAttribute("value");
            Debug.WriteLine(takeCoordinate);

            return (mapId, coordinateInputXpath);
        }

    }
}
