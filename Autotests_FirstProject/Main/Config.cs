﻿using Autotests_FirstProject.Main.Constants;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotests_FirstProject.Main
{
    public class Config
    {
        private static IWebDriver _driver;

        protected static IWebDriver driver
        {
            get
            {
                if (_driver == null)
                {
                    ChooseBrowser();
                }
                return _driver;
            }
            private set { _driver = value; }
        }
        public static void ChooseBrowser(EnumBrowserType.BrowserType browserType = EnumBrowserType.BrowserType.Chrome, int timeout = 15)
        {
            switch (browserType)
            {
                case EnumBrowserType.BrowserType.Firefox:
                    driver = new FirefoxDriver(FirefoxDriverService.CreateDefaultService("")); //Need to add version geckodriver.exe, same version Firefox browser (https://github.com/mozilla/geckodriver/releases)
                    break;
                case EnumBrowserType.BrowserType.Chrome:
                    driver = new ChromeDriver(ChromeDriverService.CreateDefaultService("C:\\Program Files\\Google\\Chrome\\Application")); //Need to add version chromedriver.exe, same version Chrome browser (http://chromedriver.storage.googleapis.com/index.html)
                    break;
                case EnumBrowserType.BrowserType.Edge:
                    driver = new EdgeDriver(EdgeDriverService.CreateDefaultService("")); //Need to add version msedgedriver.exe, same version Edge browser (https://developer.microsoft.com/ru-ru/microsoft-edge/tools/webdriver/)
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(browserType), browserType, null);
            }
        }

        [SetUp]
        public void OpenBrowser_MainPage()
        {
            _driver = null;
            driver.Navigate().GoToUrl("https://prom.ua/ua/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(TimeConst.IMPLICIT_WAIT);
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
            driver.Quit();
        }


        #region Base interface interaction methods

        //public void LoginMainPage()
        //{
        //    var loginField = driver.FindElement(_getLoginPageP.GetLoginField());
        //    SendKeyAndClearElement(loginField, LoginConst.UserLogin);

        //    var passwordField = driver.FindElement(_getLoginPageP.GetPassField());
        //    SendKeyAndClearElement(passwordField, LoginConst.UserPass);

        //    ClickElement(_getLoginPageP.GetLoginButtonOK());
        //}

        public void ClickElement(By element)
        {
            driver.FindElement(element).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(TimeConst.IMPLICIT_WAIT);
        }
        public void SendKeyAndClearElement(IWebElement element, string keyToPress)
        {
            element.Clear();
            element.SendKeys(keyToPress);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(TimeConst.IMPLICIT_WAIT);
        }
        public void ClickElement_var(IWebElement element)
        {
            element.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(TimeConst.IMPLICIT_WAIT);
        }
        public void SelectAndSendKeysElement(IWebElement element, string keyToPress)
        {
            element.SendKeys(Keys.Control + "A");
            Thread.Sleep(TimeConst.SLEEP);
            element.SendKeys(keyToPress);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(TimeConst.IMPLICIT_WAIT);
            element.SendKeys(Keys.Enter);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(TimeConst.IMPLICIT_WAIT);
        }
        public void ThreeActionCombination(By elementFirst, By elementSecond, By elementThird)
        {
            driver.FindElement(elementFirst).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(TimeConst.IMPLICIT_WAIT);
            driver.FindElement(elementSecond).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(TimeConst.IMPLICIT_WAIT);
            driver.FindElement(elementThird).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(TimeConst.IMPLICIT_WAIT);
        }
        public void TwoActionCombination(By elementFirst, By elementSecond)
        {
            driver.FindElement(elementFirst).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(TimeConst.IMPLICIT_WAIT);
            driver.FindElement(elementSecond).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(TimeConst.IMPLICIT_WAIT);
        }

        #endregion

    }
}
