using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    internal class Login: InfoLogin
    {
        public static void Start(IWebDriver driver,IElements elements)
        {
            driver.Navigate().GoToUrl(urlLogin);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IElements elementUsername = new Elements();
            elementUsername.usernameLocation(driver);


            IElements elementPassword = new Elements();
            elementPassword.passwordLocation(driver);


            IElements elementButon = new Elements();
            elementButon.loginButon(driver);

            IElements alert = new Elements();
            alert.alert(driver);

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            String currentURL = driver.Url;
            if (currentURL == urlRelease)
            {
                DateTime now = DateTime.Now;
                var jh = (TestName: typeof(Login).Name, version: "1.0", Date: now, Status: "Successfully");
                Console.WriteLine($"Test Name : {jh.TestName} || Version : {jh.version} || Status : {jh.Status} || Date: {jh.Date}.");
            }
            else
            {
                DateTime now = DateTime.Now;
                var jh = (TestName: typeof(Login).Name, version: "1.0", Date: now, Status: "Unsuccessfully");
                Console.WriteLine($"Test Name : {jh.TestName} || Version : {jh.version} || Status : {jh.Status} || Date: {jh.Date}.");
            }

        }
    }

}