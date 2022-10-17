using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Xml.Linq;
using OpenQA.Selenium.Internal;

namespace Selenium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //LogFile toFile = new LogFile();
            Login.start(driver);
            //FilterLayers.start(driver);
            //FilterbyGeometryType.start(driver);
            //FilterbyDataType.start(driver);
            CoordinateInput.start(driver);
            //ZoomMap.start(driver);
            //ToolbarZoom.start(driver);
            //AltlikHaritalar.start(driver);
            //Print.start(driver);
            //toFile.stop();
        }

    }

}