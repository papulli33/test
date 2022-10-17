using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    internal interface ILayer
    {
        void usernameLocation(IWebDriver driver) { }

        void passwordLocation(IWebDriver driver) { }

        void loginButon(IWebDriver driver) { }

    }
}
