using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    internal class Print
    {
        public static void start(IWebDriver driver)
        {
            IWebElement printButon = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div[2]/div/ul/li[6]/a"));
            printButon.Click();
            Thread.Sleep(500);

            // A0
            IWebElement selectSize0 = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div/div[1]/div/span/span[1]/span"));
            selectSize0.Click();
            Thread.Sleep(500);

            IWebElement SizeA0 = driver.FindElement(By.XPath("/html/body/span/span/span[2]/ul/li[2]"));
            SizeA0.Click();
            Thread.Sleep(500);

            IWebElement onizleme0 = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div/div[2]/div[2]/div[2]/button"));
            onizleme0.Click();
            Thread.Sleep(500);

            // Select Area to Print
            IWebElement sourceCoordinateA0 = driver.FindElement(By.Id("map"));
            var action0 = new Actions(driver);
            action0.ClickAndHold(sourceCoordinateA0);
            action0.MoveByOffset(100, 100);
            action0.Release().Build().Perform();
            Thread.Sleep(3000);

            // Take Element Width and Height
            IWebElement imagea0 = driver.FindElement(By.XPath("/html/body/div[9]/div/div/div[2]/div/div"));
            var ZerothDimension = (imagea0.Size.Width, imagea0.Size.Height);
            Thread.Sleep(1000);

            // Close Print Screen
            IWebElement close0 = driver.FindElement(By.XPath("/html/body/div[9]/div/div/div[1]/button"));
            close0.Click();
            Thread.Sleep(500);

            // A1
            // Seçim kısmına tıklama
            IWebElement paperSize1 = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div/div[1]/div/span/span[1]/span"));
            paperSize1.Click();
            Thread.Sleep(500);

            IWebElement SizeA1 = driver.FindElement(By.XPath("/html/body/span/span/span[2]/ul/li[3]"));
            SizeA1.Click();
            Thread.Sleep(500);

            IWebElement onizleme1 = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div/div[2]/div[2]/div[2]/button"));
            onizleme1.Click();
            Thread.Sleep(500);

            // Select Area to Print
            IWebElement sourceCoordinateA1 = driver.FindElement(By.Id("map"));
            var action1 = new Actions(driver);
            action1.ClickAndHold(sourceCoordinateA1);
            action1.MoveByOffset(100, 100);
            action1.Release().Build().Perform();
            Thread.Sleep(3000);

            // Take Element Width and Height
            IWebElement imagea1 = driver.FindElement(By.XPath("/html/body/div[8]/div/div/div[2]/div/div"));
            var FirstDimension = (imagea1.Size.Width, imagea1.Size.Height);
            Thread.Sleep(1000);

            // Close Print Screen
            IWebElement close1 = driver.FindElement(By.XPath("/html/body/div[8]/div/div/div[1]/button"));
            close1.Click();
            Thread.Sleep(500);

            // A2
            // Seçim kısmına tıklama
            IWebElement paperSize2 = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div/div[1]/div/span/span[1]/span"));
            paperSize2.Click();
            Thread.Sleep(500);

            IWebElement SizeA2 = driver.FindElement(By.XPath("/html/body/span/span/span[2]/ul/li[4]"));
            SizeA2.Click();
            Thread.Sleep(500);

            IWebElement onizleme2 = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div/div[2]/div[2]/div[2]/button"));
            onizleme2.Click();
            Thread.Sleep(500);

            // Select Area to Print
            IWebElement sourceCoordinateA2 = driver.FindElement(By.Id("map"));
            var action2 = new Actions(driver);
            action2.ClickAndHold(sourceCoordinateA2);
            action2.MoveByOffset(100, 100);
            action2.Release().Build().Perform();
            Thread.Sleep(500);

            // Take Element Width and Height
            IWebElement imagea2 = driver.FindElement(By.XPath("/html/body/div[8]/div/div/div[2]/div/div"));
            var SecondDimension = (imagea2.Size.Width, imagea2.Size.Height);
            Thread.Sleep(1000);

            // Close Print Screen
            IWebElement close2 = driver.FindElement(By.XPath("/html/body/div[8]/div/div/div[1]/button"));
            close2.Click();
            Thread.Sleep(500);

            // A3
            IWebElement paperSize3 = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div/div[1]/div/span/span[1]/span"));
            paperSize3.Click();
            Thread.Sleep(500); ;

            IWebElement SizeA3 = driver.FindElement(By.XPath("/html/body/span/span/span[2]/ul/li[5]"));
            SizeA3.Click();
            Thread.Sleep(500);

            IWebElement onizleme3 = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div/div[2]/div[2]/div[2]/button"));
            onizleme3.Click();
            Thread.Sleep(500);

            // Select Area to Print
            IWebElement sourceCoordinateA3 = driver.FindElement(By.Id("map"));
            var action3 = new Actions(driver);
            action3.ClickAndHold(sourceCoordinateA3);
            action3.MoveByOffset(100, 100);
            action3.Release().Build().Perform();
            Thread.Sleep(500);

            // Take Element Width and Height
            IWebElement imagea3 = driver.FindElement(By.XPath("/html/body/div[8]/div/div/div[2]/div/div"));
            var ThirdDimension = (imagea3.Size.Width, imagea3.Size.Height);
            Thread.Sleep(1000);

            // Close Print Screen
            IWebElement close3 = driver.FindElement(By.XPath("/html/body/div[8]/div/div/div[1]/button"));
            close3.Click();
            Thread.Sleep(500);

            // A4
            IWebElement paperSize4 = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div/div[1]/div/span/span[1]/span"));
            paperSize4.Click();
            Thread.Sleep(500);

            IWebElement SizeA4 = driver.FindElement(By.XPath("/html/body/span/span/span[2]/ul/li[1]"));
            SizeA4.Click();
            Thread.Sleep(500);

            IWebElement onizleme4 = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div/div[2]/div[2]/div[2]/button"));
            onizleme4.Click();
            Thread.Sleep(500); ;

            // Select Area to Print
            IWebElement sourceCoordinateA4 = driver.FindElement(By.Id("map"));
            var action4 = new Actions(driver);
            action4.ClickAndHold(sourceCoordinateA4);
            action4.MoveByOffset(100, 100);
            action4.Release().Build().Perform();
            Thread.Sleep(500);

            // Take Element Width and Height
            IWebElement imagea4 = driver.FindElement(By.XPath("/html/body/div[8]/div/div/div[2]/div/div"));
            var FourthDimension = (imagea4.Size.Width, imagea4.Size.Height);
            Thread.Sleep(1000);

            // Close Print Screen
            IWebElement close4 = driver.FindElement(By.XPath("/html/body/div[8]/div/div/div[1]/button"));
            close4.Click();
            Thread.Sleep(500);

            // A5
            IWebElement paperSize5 = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div/div[1]/div/span/span[1]/span"));
            paperSize5.Click();
            Thread.Sleep(500);

            IWebElement SizeA5 = driver.FindElement(By.XPath("/html/body/span/span/span[2]/ul/li[6]"));
            SizeA5.Click();
            Thread.Sleep(500);

            IWebElement onizleme5 = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div/div[2]/div[2]/div[2]/button"));
            onizleme5.Click();
            Thread.Sleep(500);

            // Select Area to Print
            IWebElement sourceCoordinateA5 = driver.FindElement(By.Id("map"));
            var action5 = new Actions(driver);
            action5.ClickAndHold(sourceCoordinateA5);
            action5.MoveByOffset(100, 100);
            action5.Release().Build().Perform();
            Thread.Sleep(500);

            // Take Element Width and Height
            IWebElement imagea5 = driver.FindElement(By.XPath("/html/body/div[8]/div/div/div[2]/div/div"));
            var FifthDimension = (imagea5.Size.Width, imagea5.Size.Height);
            Thread.Sleep(1000);

            // Close Print Screen
            IWebElement close5 = driver.FindElement(By.XPath("/html/body/div[8]/div/div/div[1]/button"));
            close5.Click();
            Thread.Sleep(500);


            if (ZerothDimension == FirstDimension || ZerothDimension == SecondDimension || ZerothDimension == ThirdDimension || ZerothDimension == FourthDimension || ZerothDimension == FifthDimension || 
                FirstDimension == SecondDimension || FirstDimension == ThirdDimension   || FirstDimension == FourthDimension || FirstDimension == FifthDimension   || 
                SecondDimension == ThirdDimension || SecondDimension == FourthDimension || SecondDimension == FifthDimension ||
                ThirdDimension == FourthDimension || ThirdDimension == FifthDimension   ||
                FourthDimension == FifthDimension)
            {
                Debug.WriteLine("It has bug.");
            }
            else
            {
                Debug.WriteLine("It is working success.");
            }
            Thread.Sleep(3000);


        }
    }
}