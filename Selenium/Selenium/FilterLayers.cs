using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Selenium
{
    internal class FilterLayers:InfoLayer
    {
        public static void start(IWebDriver driver)
        {
            var testResults = new List<string>();

            //Test 1
            IWebElement searchParsel = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[1]/div[2]/div[1]/input"));
            searchParsel.SendKeys(nameParsel);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement parsel = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[2]"));
            var parselchild = parsel.FindElements(By.XPath("./child::*"));
            
            if (parselchild.Count== 0)
            {
                testResults.Add("Fail");
            }
            else
            {
                IWebElement dropdownParsel = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[2]/div[1]/div[1]/button")); 
                dropdownParsel.Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                IWebElement featuresParsel = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[2]/div[1]/div[1]/div[3]/div[2]/a"));
                featuresParsel.Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                IWebElement nicknameParsel = driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/div/div/div[1]/div/div[2]/div/input"));
                string LayerNameParsel = nicknameParsel.GetAttribute("value");
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                IWebElement closeParsel = driver.FindElement(By.XPath("/html/body/div[4]/div/div[1]/div[2]/div[2]"));
                closeParsel.Click();

                if (nameParsel == LayerNameParsel)
                {
                    testResults.Add("Success");
                }
                else
                {
                    testResults.Add("Fail");
                }
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            for (int i = 0; i <= 17; i++)
            {
                IWebElement deleteParsel = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[1]/div[2]/div[1]/input"));
                deleteParsel.SendKeys(Keys.Backspace);
            };
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Test 2
            IWebElement searchKisla = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[1]/div[2]/div[1]/input"));
            searchKisla.SendKeys(nameKisla);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement kisla = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[2]"));
            var kislachild = kisla.FindElements(By.XPath("./child::*"));
            if (kislachild.Count == 0)
            {
                testResults.Add("Fail");
            }
            else
            {
                IWebElement dropdownKisla = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[2]/div/div/button")); //?
                dropdownKisla.Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                IWebElement featuresKisla = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[2]/div/div/div[3]/div[2]/a"));
                featuresKisla.Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                IWebElement nicknameKisla = driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/div/div/div[1]/div/div[2]/div/input"));
                string LayerNameKisla = nicknameKisla.GetAttribute("value");
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                IWebElement closeKisla = driver.FindElement(By.XPath("/html/body/div[4]/div/div[1]/div[2]/div[2]"));
                closeKisla.Click();

                if (nameKisla == LayerNameKisla)
                {
                    testResults.Add("Success");
                }
                else
                {
                    testResults.Add("Fail");
                }
            }


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            for (int i = 0; i <= 5; i++)
            {
                IWebElement deleteKisla = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[1]/div[2]/div[1]/input"));
                deleteKisla.SendKeys(Keys.Backspace);
            };
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Test 3
            IWebElement searchMahalle = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[1]/div[2]/div[1]/input"));
            searchMahalle.SendKeys(nameMahalle);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement mahalle = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[2]"));
            var mahallechild = mahalle.FindElements(By.XPath("./child::*"));
            if (mahallechild.Count == 0)
            {
                testResults.Add("Fail");
            }
            else
            {
                IWebElement dropdownMahalle = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[2]/div/div/button"));
                dropdownMahalle.Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                IWebElement featuresMahalle = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[2]/div[1]/div[1]/div[3]/div[2]/a"));
                featuresMahalle.Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                IWebElement nicknameMahalle = driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/div/div/div[1]/div/div[2]/div/input"));
                string LayerNameMahalle = nicknameMahalle.GetAttribute("value");
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                IWebElement closeMahalle = driver.FindElement(By.XPath("/html/body/div[4]/div/div[1]/div[2]/div[2]"));
                closeMahalle.Click();

                if (nameMahalle == LayerNameMahalle)
                {
                    testResults.Add("Success");
                }
                else
                {
                    testResults.Add("Fail");
                }
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            for (int i = 0; i <= 7; i++)
            {
                IWebElement deleteMahalle = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[1]/div[2]/div[1]/input"));
                deleteMahalle.SendKeys(Keys.Backspace);
            };
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            if (testResults.Contains("Success, Success, Success"))
            {
                DateTime now = DateTime.Now;
                var jh = (TestName: typeof(FilterLayers).Name, version: "1.0", Date: now, Status: "Successfully");
                Console.WriteLine($"Test Name : {jh.TestName} || Version : {jh.version} || Status : {jh.Status} || Date: {jh.Date}.");
            }
            else
            {
                DateTime now = DateTime.Now;
                var jh = (TestName: typeof(FilterLayers).Name, version: "1.0", Date: now, Status: "Unsuccessfully");
                Console.WriteLine($"Test Name : {jh.TestName} || Version : {jh.version} || Status : {jh.Status} || Date: {jh.Date}.");

            }

        }
    }
}
