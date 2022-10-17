using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    internal class FilterbyGeometryType
    {
        public static void start(IWebDriver driver)
        {
            // Raster için bilgi tutuluyor fakat wms ve vektör veri için karışıklık olacağı için bunların testini yapabilmek için kod bazında düzenlenme yapılmalıdır.     


            IWebElement filterbyLayers = driver.FindElement(By.Id("teo_toc_toolbar_filter_button"));
            filterbyLayers.Click();
            Thread.Sleep(1000);

            IWebElement filterbyType = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[1]/div[2]/div[2]/span/span[1]/span"));
            filterbyType.Click();
            Thread.Sleep(1000);

            IWebElement filterbyGeometry = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[1]/div[2]/div[2]/span[2]/span/span[2]/ul/li[2]"));
            filterbyGeometry.Click();
            Thread.Sleep(1000);

            //Point
            IWebElement filterbyPoint = driver.FindElement(By.Id("teo_toc_toolbar_marker_check"));
            filterbyPoint.Click();
            Thread.Sleep(1000);

            IWebElement applyFilterbyPoint = driver.FindElement(By.Id("teo_toc_toolbar_apply_filter"));
            applyFilterbyPoint.Click();
            Thread.Sleep(3000);

            //Line
            IWebElement filterFilterbyLine = driver.FindElement(By.Id("teo_toc_toolbar_line_check"));
            filterFilterbyLine.Click();
            Thread.Sleep(1000);

            IWebElement applyFilterbyLine = driver.FindElement(By.Id("teo_toc_toolbar_apply_filter"));
            applyFilterbyLine.Click();
            Thread.Sleep(3000);

            //Polygon
            IWebElement filterbyPolygon = driver.FindElement(By.Id("teo_toc_toolbar_polygon_check"));
            filterbyPolygon.Click();
            Thread.Sleep(1000);

            IWebElement applyFilterbyPolygon = driver.FindElement(By.Id("teo_toc_toolbar_apply_filter"));
            applyFilterbyPolygon.Click();
            Thread.Sleep(3000);

            IWebElement resetFilter = driver.FindElement(By.Id("teo_toc_toolbar_reset_filter"));
            resetFilter.Click();
            Thread.Sleep(3000);

        }
    }
}
