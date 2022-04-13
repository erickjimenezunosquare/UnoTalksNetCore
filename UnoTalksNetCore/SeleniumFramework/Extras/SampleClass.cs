﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Framework
{
    public static class SampleClass
    {

        public static void DummyTest()
        {
            //https://www.kenst.com/2015/03/installing-chromedriver-on-mac-osx/
            //brew install chromedriver

            ChromeDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://google.com");
            driver.FindElement(By.Name("q")).SendKeys("Erick Eduardo Jimenez Rodriguez");

            Thread.Sleep(5000);

            driver.Quit();
        }
    }
}
