using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Xml.Linq;
using OpenQA.Selenium.Internal;
using System;

namespace Selenium
{
    internal class Program:InfoLogin
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            IElements elements = new Elements();
            LogFile toFile = new ();
            Login.Start(driver,elements);
            FilterLayers.start(driver);
            CoordinateInput.start(driver);
            ZoomMap.start(driver);
            ToolbarZoom.start(driver);
            BaseMaps.start(driver);
            Print.start(driver);
            toFile.Stop();
        }

    }

}