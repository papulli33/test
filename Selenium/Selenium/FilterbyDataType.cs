using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    internal class FilterbyDataType
    {
        public static void start(IWebDriver driver)
        {
            // Test edilemiyor çünkü site içerisinde bunu kontrol edecek bir bilgi yok.



            IWebElement filterbyLayers = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[1]/div[2]/div[2]/span/span[1]/span"));
            filterbyLayers.Click();
            Thread.Sleep(1000);

            IWebElement filterbyType = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[1]/div[2]/div[2]/span[2]/span/span[2]/ul/li[1]"));
            filterbyType.Click();
            Thread.Sleep(1000);

            IWebElement filterbyRasterData = driver.FindElement(By.Id("teo_toc_toolbar_raster_radio"));
            filterbyRasterData.Click();
            Thread.Sleep(1000);

            IWebElement applyFilterRaster = driver.FindElement(By.Id("teo_toc_toolbar_apply_filter"));
            applyFilterRaster.Click();
            Thread.Sleep(3000);

            IWebElement resetFilterRaster = driver.FindElement(By.Id("teo_toc_toolbar_reset_filter"));
            resetFilterRaster.Click();
            Thread.Sleep(2000);

            IWebElement filterbyVectorData = driver.FindElement(By.Id("teo_toc_toolbar_geometry_radio"));
            filterbyVectorData.Click();
            Thread.Sleep(1000);

            IWebElement applyFilterVector = driver.FindElement(By.Id("teo_toc_toolbar_apply_filter"));
            applyFilterVector.Click();
            Thread.Sleep(3000);

            IWebElement resetFilterVector = driver.FindElement(By.Id("teo_toc_toolbar_reset_filter"));
            resetFilterVector.Click();
            Thread.Sleep(3000);

            //Closing filter window
            IWebElement closingFilter = driver.FindElement(By.Id("teo_toc_toolbar_filter_button"));
            closingFilter.Click();
            Thread.Sleep(2000);

            //Closing layers window
            IWebElement closingLayers = driver.FindElement(By.Id("teo_drawer_toggle_button"));
            closingLayers.Click();
            Thread.Sleep(5000);

        }
    }
}
