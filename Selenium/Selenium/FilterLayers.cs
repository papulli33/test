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
    internal class FilterLayers
    {
        public static void start(IWebDriver driver)
        {
            var testResults = new List<string>();
            //Test 1
            IWebElement search = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[1]/div[2]/div[1]/input"));
            string nameParsel = "MEGSİS Parselleri";
            search.SendKeys(nameParsel);

            Thread.Sleep(1000);

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
                Thread.Sleep(500);
                IWebElement featuresParsel = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[2]/div[1]/div[1]/div[3]/div[2]/a"));
                featuresParsel.Click();
                Thread.Sleep(500);
                IWebElement nicknameParsel = driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/div/div/div[1]/div/div[2]/div/input"));
                string LayerNameParsel = nicknameParsel.GetAttribute("value");
                Thread.Sleep(500);
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

            Thread.Sleep(2000);

            for (int i = 0; i <= 17; i++)
            {
                IWebElement delete = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[1]/div[2]/div[1]/input"));
                search.SendKeys(Keys.Backspace);
            };
            Thread.Sleep(2000);

            //Test 2
            IWebElement search1 = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[1]/div[2]/div[1]/input"));
            string nameKisla = "Kışla";
            search.SendKeys(nameKisla);

            Thread.Sleep(1000);

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
                Thread.Sleep(500);
                IWebElement featuresKisla = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[2]/div/div/div[3]/div[2]/a"));
                featuresKisla.Click();
                Thread.Sleep(500);
                IWebElement nicknameKisla = driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/div/div/div[1]/div/div[2]/div/input"));
                string LayerNameKisla = nicknameKisla.GetAttribute("value");
                Thread.Sleep(500);
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


            Thread.Sleep(2000);
            for (int i = 0; i <= 5; i++)
            {
                IWebElement delete1 = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[1]/div[2]/div[1]/input"));
                search1.SendKeys(Keys.Backspace);
            };
            Thread.Sleep(2000);

            //Test 3
            IWebElement search2 = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[1]/div[2]/div[1]/input"));
            string nameMahalle = "Mahalle";
            search.SendKeys(nameMahalle);

            Thread.Sleep(1000);

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
                Thread.Sleep(500);
                IWebElement featuresMahalle = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[2]/div[1]/div[1]/div[3]/div[2]/a"));
                featuresMahalle.Click();
                Thread.Sleep(500);
                IWebElement nicknameMahalle = driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/div/div/div[1]/div/div[2]/div/input"));
                string LayerNameMahalle = nicknameMahalle.GetAttribute("value");
                Thread.Sleep(500);
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

            Thread.Sleep(2000);

            for (int i = 0; i <= 7; i++)
            {
                IWebElement delete2 = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div[1]/div[2]/div[1]/input"));
                search2.SendKeys(Keys.Backspace);
            };
            Thread.Sleep(2000);

            if (testResults.Contains("Success, Success, Success"))
            {
                Console.WriteLine("Test is succcess. Filter layers");
            }
            else
            {
                Console.WriteLine("Test is fail. . Filter layers");

            }

        }
    }
}
