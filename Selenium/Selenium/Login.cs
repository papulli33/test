using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    internal class Login
    {
        public static void start(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://130.185.119.179:83/src/Login.html");
            Thread.Sleep(1000);

            IWebElement username = driver.FindElement(By.Id("teo_login_user"));
            username.SendKeys("Administrator");
            Thread.Sleep(1000);

            IWebElement password = driver.FindElement(By.Id("teo_login_password"));
            password.SendKeys("jistbis2022*");
            Thread.Sleep(1000);

            IWebElement buton = driver.FindElement(By.Id("teo_login_submit"));
            buton.Click();

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }
    }
}
