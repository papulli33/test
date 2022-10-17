using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    internal interface IPrint
    {
        void printButton(IWebDriver driver) { }

        void selectSize(IWebDriver driver) { }

        void onizleme(IWebDriver driver) { }

        void sourceCoordinate(IWebDriver driver) { }

        void close(IWebDriver driver) { }
    }
}
