using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    internal interface IElements
    {
        void usernameLocation(IWebDriver driver) {}

        void passwordLocation(IWebDriver driver) {}

        void loginButon(IWebDriver driver) {}

        void alert(IWebDriver driver) { }
    }
}
