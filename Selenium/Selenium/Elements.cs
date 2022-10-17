using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium
{
    public class Elements:IElements
    {
        public void usernameLocation(IWebDriver driver) 
        { 
            IWebElement userLoc = driver.FindElement(By.Id("teo_login_user"));
            userLoc.SendKeys("Administrator");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public void passwordLocation(IWebDriver driver) 
        {
            IWebElement passwordLoc = driver.FindElement(By.Id("teo_login_password"));
            passwordLoc.SendKeys("jistbis2022*");
            //An implicit wait is to tell WebDriver to poll the DOM for a certain amount of time
            //when trying to find an element or elements if they are not immediately available.
            //The default setting is 0. Once set, the implicit wait is set for the life of the WebDriver object instance.
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public void loginButon(IWebDriver driver) 
        { 
            driver.FindElement(By.Id("teo_login_submit")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public void alert(IWebDriver driver)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("alert('İşlem başarılı')");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.SwitchTo().Alert().Accept();

        }
    }
}
